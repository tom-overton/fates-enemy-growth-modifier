// Copyright (c) 2017 Tom Overton

using System;
using System.IO;

namespace FatesEnemyGrowthModifier
{
    public class GameDataModel
    {
        // Constants obtained from here: https://github.com/RainThunder/fefates-tools/wiki/BIN-(File-Format)
        private const int GAMEDATA_HEADER_SIZE = 0x20;
        private const int POINTER_SIZE = 0x4;
        private const int DATA_REGION_SIZE_OFFSET = 0x4;

        // I *think* class data is always the third block in the data region?
        // That's what this document implies: https://pastebin.com/3zHxeqUj
        private const int CLASS_DATA_BLOCK_INDEX = 2;

        // It appears the class block itself has a small header on it?
        // On a vanilla GameData.bin, the pointer points us to 0xEA08,
        // but the actual class data starts at 0xEA10
        private const int CLASS_DATA_HEADER_SIZE = 0x8;

        private FileStream file;
        private int dataRegionSize;
        private int startOfClassData;

        public ClassEntry[] classEntries = new ClassEntry[Constants.NUMBER_OF_CLASSES];

        public GameDataModel(string filename)
        {
            this.file = File.Open(filename, FileMode.Open, FileAccess.ReadWrite);
            this.dataRegionSize = this.ReadInt32FromFileAtOffset(DATA_REGION_SIZE_OFFSET);
            this.LocateStartOfClassData();
            this.file.Seek(this.startOfClassData + CLASS_DATA_HEADER_SIZE, SeekOrigin.Begin);
            byte[] classEntryBytes = new byte[Constants.CLASS_ENTRY_SIZE];
            for (int i = 0; i < Constants.NUMBER_OF_CLASSES; i++)
            {
                this.file.Read(classEntryBytes, 0, Constants.CLASS_ENTRY_SIZE);
                this.classEntries[i] = new ClassEntry(classEntryBytes);
            }
        }

        public void LocateStartOfClassData()
        {
            int startOfPointerRegion1 = GAMEDATA_HEADER_SIZE + dataRegionSize;
            int offset1 = startOfPointerRegion1 + (POINTER_SIZE * CLASS_DATA_BLOCK_INDEX);
            int pointerToClassDataPointer = this.ReadInt32FromFileAtOffset(offset1) + GAMEDATA_HEADER_SIZE;
            this.startOfClassData = this.ReadInt32FromFileAtOffset(pointerToClassDataPointer) + GAMEDATA_HEADER_SIZE;
        }

        public void WriteCurrentModelToFile()
        {
            // Seek to the first enemy growth entry
            this.file.Seek(this.startOfClassData + CLASS_DATA_HEADER_SIZE, SeekOrigin.Begin);
            this.file.Seek(ClassOffsets.ENEMY_HP_GROWTH, SeekOrigin.Current);

            for (int i = 0; i < this.classEntries.Length; i++)
            {
                this.file.WriteByte(this.classEntries[i].EnemyHpGrowth);
                this.file.WriteByte(this.classEntries[i].EnemyStrengthGrowth);
                this.file.WriteByte(this.classEntries[i].EnemyMagicGrowth);
                this.file.WriteByte(this.classEntries[i].EnemySkillGrowth);
                this.file.WriteByte(this.classEntries[i].EnemySpeedGrowth);
                this.file.WriteByte(this.classEntries[i].EnemyLuckGrowth);
                this.file.WriteByte(this.classEntries[i].EnemyDefenseGrowth);
                this.file.WriteByte(this.classEntries[i].EnemyResistanceGrowth);

                // Seek to the start of the next enemy growth entry
                this.file.Seek(Constants.CLASS_ENTRY_SIZE - 8, SeekOrigin.Current);
            }
        }

        public void IncreaseAllGrowthsByValue(int value)
        {
            for (int i = 0; i < classEntries.Length; i++)
            {
                this.classEntries[i].EnemyHpGrowth = AddValueToByteWithoutOverflow(this.classEntries[i].EnemyHpGrowth, value);
                this.classEntries[i].EnemyStrengthGrowth = AddValueToByteWithoutOverflow(this.classEntries[i].EnemyStrengthGrowth, value);
                this.classEntries[i].EnemyMagicGrowth = AddValueToByteWithoutOverflow(this.classEntries[i].EnemyMagicGrowth, value);
                this.classEntries[i].EnemySkillGrowth = AddValueToByteWithoutOverflow(this.classEntries[i].EnemySkillGrowth, value);
                this.classEntries[i].EnemySpeedGrowth = AddValueToByteWithoutOverflow(this.classEntries[i].EnemySpeedGrowth, value);
                this.classEntries[i].EnemyLuckGrowth = AddValueToByteWithoutOverflow(this.classEntries[i].EnemyLuckGrowth, value);
                this.classEntries[i].EnemyDefenseGrowth = AddValueToByteWithoutOverflow(this.classEntries[i].EnemyDefenseGrowth, value);
                this.classEntries[i].EnemyResistanceGrowth = AddValueToByteWithoutOverflow(this.classEntries[i].EnemyResistanceGrowth, value);
            }
        }

        private int ReadInt32FromFileAtOffset(int offset)
        {
            this.file.Seek(offset, SeekOrigin.Begin);
            byte[] dataBytes = new byte[4];
            this.file.Read(dataBytes, 0, 4);

            // Fire Emblem Fates stores data in little-endian format.
            // If the current platform is big endian, reverse the bytes
            // so that BitConverter reads them in correctly.
            if (!BitConverter.IsLittleEndian)
            {
                byte temp = dataBytes[0];
                dataBytes[0] = dataBytes[3];
                dataBytes[3] = temp;
                temp = dataBytes[1];
                dataBytes[1] = dataBytes[2];
                dataBytes[2] = temp;
            }

            return BitConverter.ToInt32(dataBytes, 0);
        }

        private byte AddValueToByteWithoutOverflow(byte b, int value)
        {
            long sum = b + value;
            if (sum < 0)
            {
                sum = 0;
            }
            if (sum > 255)
            {
                sum = 255;
            }

            return (byte)sum;
        }
    }
}

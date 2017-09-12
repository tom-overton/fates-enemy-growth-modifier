// Copyright (c) 2017 Tom Overton

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatesEnemyGrowthModifier
{
    public class GameDataModel
    {
        private const int START_OF_CLASS_ENTRIES = 0xEA10;
        private FileStream file;

        public ClassEntry[] classEntries = new ClassEntry[Constants.NUMBER_OF_CLASSES];

        public GameDataModel(string filename)
        {
            this.file = File.Open(filename, FileMode.Open, FileAccess.ReadWrite);
            this.file.Seek(START_OF_CLASS_ENTRIES, SeekOrigin.Begin);
            byte[] classEntryBytes = new byte[Constants.CLASS_ENTRY_SIZE];
            for (int i = 0; i < Constants.NUMBER_OF_CLASSES; i++)
            {
                this.file.Read(classEntryBytes, 0, Constants.CLASS_ENTRY_SIZE);
                this.classEntries[i] = new ClassEntry(classEntryBytes);
            }
        }

        public void WriteCurrentModelToFile()
        {
            // Seek to the first enemy growth entry
            this.file.Seek(START_OF_CLASS_ENTRIES, SeekOrigin.Begin);
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

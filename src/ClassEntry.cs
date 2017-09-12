// Copyright (c) 2017 Tom Overton

using System;

namespace FatesEnemyGrowthModifier
{
    public class ClassEntry
    {
        #region class entry member declarations

        public byte EnemyHpGrowth;
        public byte EnemyStrengthGrowth;
        public byte EnemyMagicGrowth;
        public byte EnemySkillGrowth;
        public byte EnemySpeedGrowth;
        public byte EnemyLuckGrowth;
        public byte EnemyDefenseGrowth;
        public byte EnemyResistanceGrowth;

        #endregion

        public ClassEntry()
        {
            // Only used to set the default class entry before the user loads a class from GameData.bin
        }

        public ClassEntry(byte[] classEntryBytes)
        {
            if (classEntryBytes.Length != Constants.CLASS_ENTRY_SIZE)
            {
                throw new ArgumentException("You didn't pass in an entry of the right size");
            }

            this.EnemyHpGrowth = classEntryBytes[ClassOffsets.ENEMY_HP_GROWTH];
            this.EnemyStrengthGrowth = classEntryBytes[ClassOffsets.ENEMY_STRENGTH_GROWTH];
            this.EnemyMagicGrowth = classEntryBytes[ClassOffsets.ENEMY_MAGIC_GROWTH];
            this.EnemySkillGrowth = classEntryBytes[ClassOffsets.ENEMY_SKILL_GROWTH];
            this.EnemySpeedGrowth = classEntryBytes[ClassOffsets.ENEMY_SPEED_GROWTH];
            this.EnemyLuckGrowth = classEntryBytes[ClassOffsets.ENEMY_LUCK_GROWTH];
            this.EnemyDefenseGrowth = classEntryBytes[ClassOffsets.ENEMY_DEFENSE_GROWTH];
            this.EnemyResistanceGrowth = classEntryBytes[ClassOffsets.ENEMY_RESISTANCE_GROWTH];
        }
    }

    public static class ClassOffsets
    {
        public const int ENEMY_HP_GROWTH = 0x2C;
        public const int ENEMY_STRENGTH_GROWTH = 0x2D;
        public const int ENEMY_MAGIC_GROWTH = 0x2E;
        public const int ENEMY_SKILL_GROWTH = 0x2F;
        public const int ENEMY_SPEED_GROWTH = 0x30;
        public const int ENEMY_LUCK_GROWTH = 0x31;
        public const int ENEMY_DEFENSE_GROWTH = 0x32;
        public const int ENEMY_RESISTANCE_GROWTH = 0x33;
    }
}

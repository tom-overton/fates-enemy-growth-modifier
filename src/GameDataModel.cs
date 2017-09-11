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
    }
}

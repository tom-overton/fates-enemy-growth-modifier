// Copyright (c) 2017 Tom Overton

using System.IO;
using System.Reflection;

namespace FatesEnemyGrowthModifier
{
    public class ClassNameTable
    {
        private static string[] classNameTable = new string[Constants.NUMBER_OF_CLASSES];

        public static void InitializeClassNameTable()
        {
            StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("FatesEnemyGrowthModifier.Resources.ClassNames.txt"));
            int index = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                classNameTable[index] = line;
                index++;
            }
        }

        public static string GetClassNameForIndex(int index)
        {
            return classNameTable[index];
        }
    }
}

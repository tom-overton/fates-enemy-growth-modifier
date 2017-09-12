﻿// Copyright (c) 2017 Tom Overton

using System;
using System.Windows.Forms;

namespace FatesEnemyGrowthModifier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ClassNameTable.InitializeClassNameTable();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FatesEnemyGrowthModifierForm());
        }
    }
}

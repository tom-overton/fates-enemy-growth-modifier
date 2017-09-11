// Copyright (c) 2017 Tom Overton

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FatesEnemyGrowthModifier
{
    public partial class FatesEnemyGrowthModifierForm : Form
    {
        private GameDataModel model;

        public FatesEnemyGrowthModifierForm()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            DialogResult result = gameDataOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = gameDataOpenFileDialog.FileName;
                filenameBox.Text = file;
                try
                {
                    this.model = new GameDataModel(file);
                    for (int i = 0; i < this.model.classEntries.Length; i++)
                    {
                        classSelectorComboBox.Items.Add(ClassNameTable.GetClassNameForIndex(i));
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorBox("An error occurred while opening the GameData.bin file: \n" + ex.Message);
                }
            }
        }

        private void ShowErrorBox(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void classSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassEntry currentClassEntry = this.model.classEntries[classSelectorComboBox.SelectedIndex];
            hpGrowthTextBox.Text = currentClassEntry.EnemyHpGrowth.ToString();
            strGrowthTextBox.Text = currentClassEntry.EnemyStrengthGrowth.ToString();
            magGrowthTextBox.Text = currentClassEntry.EnemyMagicGrowth.ToString();
            sklGrowthTextBox.Text = currentClassEntry.EnemySkillGrowth.ToString();
            spdGrowthTextBox.Text = currentClassEntry.EnemySpeedGrowth.ToString();
            lckGrowthTextBox.Text = currentClassEntry.EnemyLuckGrowth.ToString();
            defGrowthTextBox.Text = currentClassEntry.EnemyDefenseGrowth.ToString();
            resGrowthTextBox.Text = currentClassEntry.EnemyResistanceGrowth.ToString();
        }
    }
}

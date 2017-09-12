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
        private ClassEntry currentClassEntry = new ClassEntry();

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
            this.currentClassEntry = this.model.classEntries[classSelectorComboBox.SelectedIndex];
            hpGrowthTextBox.Text = this.currentClassEntry.EnemyHpGrowth.ToString();
            strGrowthTextBox.Text = this.currentClassEntry.EnemyStrengthGrowth.ToString();
            magGrowthTextBox.Text = this.currentClassEntry.EnemyMagicGrowth.ToString();
            sklGrowthTextBox.Text = this.currentClassEntry.EnemySkillGrowth.ToString();
            spdGrowthTextBox.Text = this.currentClassEntry.EnemySpeedGrowth.ToString();
            lckGrowthTextBox.Text = this.currentClassEntry.EnemyLuckGrowth.ToString();
            defGrowthTextBox.Text = this.currentClassEntry.EnemyDefenseGrowth.ToString();
            resGrowthTextBox.Text = this.currentClassEntry.EnemyResistanceGrowth.ToString();
        }

        private void ValidateAndSetGrowthInput(TextBox changedTextBox, ref byte growthValue)
        {
            string value = changedTextBox.Text;
            int inputGrowth;
            if (int.TryParse(value, out inputGrowth))
            {
                if (inputGrowth >= 0 && inputGrowth <= 255)
                {
                    growthValue = (byte)inputGrowth;
                    changedTextBox.BackColor = Color.White;
                    return;
                }
            }

            // If we got to this point, the input is invalid. Change the color of the input box
            // to indicate this to the user.
            changedTextBox.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void hpGrowthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndSetGrowthInput(hpGrowthTextBox, ref this.currentClassEntry.EnemyHpGrowth);
        }

        private void strGrowthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndSetGrowthInput(strGrowthTextBox, ref this.currentClassEntry.EnemyStrengthGrowth);
        }

        private void magGrowthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndSetGrowthInput(magGrowthTextBox, ref this.currentClassEntry.EnemyMagicGrowth);
        }

        private void sklGrowthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndSetGrowthInput(sklGrowthTextBox, ref this.currentClassEntry.EnemySkillGrowth);
        }

        private void spdGrowthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndSetGrowthInput(spdGrowthTextBox, ref this.currentClassEntry.EnemySpeedGrowth);
        }

        private void lckGrowthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndSetGrowthInput(lckGrowthTextBox, ref this.currentClassEntry.EnemyLuckGrowth);
        }

        private void defGrowthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndSetGrowthInput(defGrowthTextBox, ref this.currentClassEntry.EnemyDefenseGrowth);
        }

        private void resGrowthTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAndSetGrowthInput(resGrowthTextBox, ref this.currentClassEntry.EnemyResistanceGrowth);
        }
    }
}

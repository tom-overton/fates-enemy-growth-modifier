﻿// Copyright (c) 2017 Tom Overton

namespace FatesEnemyGrowthModifier
{
    partial class FatesEnemyGrowthModifierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FatesEnemyGrowthModifierForm));
            this.gameDataOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.classSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.hpGrowthLabel = new System.Windows.Forms.Label();
            this.hpGrowthTextBox = new System.Windows.Forms.TextBox();
            this.strGrowthLabel = new System.Windows.Forms.Label();
            this.strGrowthTextBox = new System.Windows.Forms.TextBox();
            this.magGrowthLabel = new System.Windows.Forms.Label();
            this.magGrowthTextBox = new System.Windows.Forms.TextBox();
            this.sklGrowthLabel = new System.Windows.Forms.Label();
            this.sklGrowthTextBox = new System.Windows.Forms.TextBox();
            this.spdGrowthLabel = new System.Windows.Forms.Label();
            this.spdGrowthTextBox = new System.Windows.Forms.TextBox();
            this.lckGrowthLabel = new System.Windows.Forms.Label();
            this.lckGrowthTextBox = new System.Windows.Forms.TextBox();
            this.defGrowthLabel = new System.Windows.Forms.Label();
            this.defGrowthTextBox = new System.Windows.Forms.TextBox();
            this.resGrowthLabel = new System.Windows.Forms.Label();
            this.resGrowthTextBox = new System.Windows.Forms.TextBox();
            this.topMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameDatabinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameDatabinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.growthRateBuffTextBox = new System.Windows.Forms.TextBox();
            this.growthRateBuffButton = new System.Windows.Forms.Button();
            this.topMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameDataOpenFileDialog
            // 
            this.gameDataOpenFileDialog.Filter = "Uncompressed GameData file|*.bin";
            // 
            // classSelectorComboBox
            // 
            this.classSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classSelectorComboBox.FormattingEnabled = true;
            this.classSelectorComboBox.Location = new System.Drawing.Point(13, 26);
            this.classSelectorComboBox.Name = "classSelectorComboBox";
            this.classSelectorComboBox.Size = new System.Drawing.Size(259, 21);
            this.classSelectorComboBox.TabIndex = 2;
            this.classSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.classSelectorComboBox_SelectedIndexChanged);
            // 
            // hpGrowthLabel
            // 
            this.hpGrowthLabel.AutoSize = true;
            this.hpGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.hpGrowthLabel.Location = new System.Drawing.Point(17, 62);
            this.hpGrowthLabel.Name = "hpGrowthLabel";
            this.hpGrowthLabel.Size = new System.Drawing.Size(68, 13);
            this.hpGrowthLabel.TabIndex = 3;
            this.hpGrowthLabel.Text = "HP Growth";
            // 
            // hpGrowthTextBox
            // 
            this.hpGrowthTextBox.Location = new System.Drawing.Point(90, 60);
            this.hpGrowthTextBox.MaxLength = 4;
            this.hpGrowthTextBox.Multiline = true;
            this.hpGrowthTextBox.Name = "hpGrowthTextBox";
            this.hpGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.hpGrowthTextBox.TabIndex = 7;
            this.hpGrowthTextBox.TextChanged += new System.EventHandler(this.hpGrowthTextBox_TextChanged);
            // 
            // strGrowthLabel
            // 
            this.strGrowthLabel.AutoSize = true;
            this.strGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.strGrowthLabel.Location = new System.Drawing.Point(18, 90);
            this.strGrowthLabel.Name = "strGrowthLabel";
            this.strGrowthLabel.Size = new System.Drawing.Size(67, 13);
            this.strGrowthLabel.TabIndex = 8;
            this.strGrowthLabel.Text = "Str Growth";
            // 
            // strGrowthTextBox
            // 
            this.strGrowthTextBox.Location = new System.Drawing.Point(90, 88);
            this.strGrowthTextBox.MaxLength = 4;
            this.strGrowthTextBox.Multiline = true;
            this.strGrowthTextBox.Name = "strGrowthTextBox";
            this.strGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.strGrowthTextBox.TabIndex = 9;
            this.strGrowthTextBox.TextChanged += new System.EventHandler(this.strGrowthTextBox_TextChanged);
            // 
            // magGrowthLabel
            // 
            this.magGrowthLabel.AutoSize = true;
            this.magGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.magGrowthLabel.Location = new System.Drawing.Point(10, 118);
            this.magGrowthLabel.Name = "magGrowthLabel";
            this.magGrowthLabel.Size = new System.Drawing.Size(75, 13);
            this.magGrowthLabel.TabIndex = 10;
            this.magGrowthLabel.Text = "Mag Growth";
            // 
            // magGrowthTextBox
            // 
            this.magGrowthTextBox.Location = new System.Drawing.Point(90, 116);
            this.magGrowthTextBox.MaxLength = 4;
            this.magGrowthTextBox.Multiline = true;
            this.magGrowthTextBox.Name = "magGrowthTextBox";
            this.magGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.magGrowthTextBox.TabIndex = 11;
            this.magGrowthTextBox.TextChanged += new System.EventHandler(this.magGrowthTextBox_TextChanged);
            // 
            // sklGrowthLabel
            // 
            this.sklGrowthLabel.AutoSize = true;
            this.sklGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sklGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.sklGrowthLabel.Location = new System.Drawing.Point(16, 146);
            this.sklGrowthLabel.Name = "sklGrowthLabel";
            this.sklGrowthLabel.Size = new System.Drawing.Size(69, 13);
            this.sklGrowthLabel.TabIndex = 12;
            this.sklGrowthLabel.Text = "Skl Growth";
            // 
            // sklGrowthTextBox
            // 
            this.sklGrowthTextBox.Location = new System.Drawing.Point(90, 144);
            this.sklGrowthTextBox.MaxLength = 4;
            this.sklGrowthTextBox.Multiline = true;
            this.sklGrowthTextBox.Name = "sklGrowthTextBox";
            this.sklGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.sklGrowthTextBox.TabIndex = 13;
            this.sklGrowthTextBox.TextChanged += new System.EventHandler(this.sklGrowthTextBox_TextChanged);
            // 
            // spdGrowthLabel
            // 
            this.spdGrowthLabel.AutoSize = true;
            this.spdGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spdGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.spdGrowthLabel.Location = new System.Drawing.Point(148, 62);
            this.spdGrowthLabel.Name = "spdGrowthLabel";
            this.spdGrowthLabel.Size = new System.Drawing.Size(73, 13);
            this.spdGrowthLabel.TabIndex = 14;
            this.spdGrowthLabel.Text = "Spd Growth";
            // 
            // spdGrowthTextBox
            // 
            this.spdGrowthTextBox.Location = new System.Drawing.Point(227, 60);
            this.spdGrowthTextBox.MaxLength = 4;
            this.spdGrowthTextBox.Multiline = true;
            this.spdGrowthTextBox.Name = "spdGrowthTextBox";
            this.spdGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.spdGrowthTextBox.TabIndex = 15;
            this.spdGrowthTextBox.TextChanged += new System.EventHandler(this.spdGrowthTextBox_TextChanged);
            // 
            // lckGrowthLabel
            // 
            this.lckGrowthLabel.AutoSize = true;
            this.lckGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lckGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.lckGrowthLabel.Location = new System.Drawing.Point(149, 90);
            this.lckGrowthLabel.Name = "lckGrowthLabel";
            this.lckGrowthLabel.Size = new System.Drawing.Size(72, 13);
            this.lckGrowthLabel.TabIndex = 16;
            this.lckGrowthLabel.Text = "Lck Growth";
            // 
            // lckGrowthTextBox
            // 
            this.lckGrowthTextBox.Location = new System.Drawing.Point(227, 88);
            this.lckGrowthTextBox.MaxLength = 4;
            this.lckGrowthTextBox.Multiline = true;
            this.lckGrowthTextBox.Name = "lckGrowthTextBox";
            this.lckGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.lckGrowthTextBox.TabIndex = 17;
            this.lckGrowthTextBox.TextChanged += new System.EventHandler(this.lckGrowthTextBox_TextChanged);
            // 
            // defGrowthLabel
            // 
            this.defGrowthLabel.AutoSize = true;
            this.defGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.defGrowthLabel.Location = new System.Drawing.Point(150, 118);
            this.defGrowthLabel.Name = "defGrowthLabel";
            this.defGrowthLabel.Size = new System.Drawing.Size(71, 13);
            this.defGrowthLabel.TabIndex = 18;
            this.defGrowthLabel.Text = "Def Growth";
            // 
            // defGrowthTextBox
            // 
            this.defGrowthTextBox.Location = new System.Drawing.Point(227, 116);
            this.defGrowthTextBox.MaxLength = 4;
            this.defGrowthTextBox.Multiline = true;
            this.defGrowthTextBox.Name = "defGrowthTextBox";
            this.defGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.defGrowthTextBox.TabIndex = 19;
            this.defGrowthTextBox.TextChanged += new System.EventHandler(this.defGrowthTextBox_TextChanged);
            // 
            // resGrowthLabel
            // 
            this.resGrowthLabel.AutoSize = true;
            this.resGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.resGrowthLabel.Location = new System.Drawing.Point(148, 146);
            this.resGrowthLabel.Name = "resGrowthLabel";
            this.resGrowthLabel.Size = new System.Drawing.Size(73, 13);
            this.resGrowthLabel.TabIndex = 20;
            this.resGrowthLabel.Text = "Res Growth";
            // 
            // resGrowthTextBox
            // 
            this.resGrowthTextBox.Location = new System.Drawing.Point(227, 144);
            this.resGrowthTextBox.MaxLength = 4;
            this.resGrowthTextBox.Multiline = true;
            this.resGrowthTextBox.Name = "resGrowthTextBox";
            this.resGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.resGrowthTextBox.TabIndex = 21;
            this.resGrowthTextBox.TextChanged += new System.EventHandler(this.resGrowthTextBox_TextChanged);
            // 
            // topMenuStrip
            // 
            this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topMenuStrip.Name = "topMenuStrip";
            this.topMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.topMenuStrip.TabIndex = 22;
            this.topMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGameDatabinToolStripMenuItem,
            this.saveGameDatabinToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openGameDatabinToolStripMenuItem
            // 
            this.openGameDatabinToolStripMenuItem.Name = "openGameDatabinToolStripMenuItem";
            this.openGameDatabinToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.openGameDatabinToolStripMenuItem.Text = "Open GameData.bin";
            this.openGameDatabinToolStripMenuItem.Click += new System.EventHandler(this.openGameDatabinToolStripMenuItem_Click);
            // 
            // saveGameDatabinToolStripMenuItem
            // 
            this.saveGameDatabinToolStripMenuItem.Enabled = false;
            this.saveGameDatabinToolStripMenuItem.Name = "saveGameDatabinToolStripMenuItem";
            this.saveGameDatabinToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveGameDatabinToolStripMenuItem.Text = "Save GameData.bin";
            this.saveGameDatabinToolStripMenuItem.Click += new System.EventHandler(this.saveGameDatabinToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Increase growths for all classes by";
            // 
            // growthRateBuffTextBox
            // 
            this.growthRateBuffTextBox.Location = new System.Drawing.Point(227, 189);
            this.growthRateBuffTextBox.MaxLength = 4;
            this.growthRateBuffTextBox.Multiline = true;
            this.growthRateBuffTextBox.Name = "growthRateBuffTextBox";
            this.growthRateBuffTextBox.Size = new System.Drawing.Size(34, 18);
            this.growthRateBuffTextBox.TabIndex = 24;
            this.growthRateBuffTextBox.TextChanged += new System.EventHandler(this.growthRateBuffTextBox_TextChanged);
            // 
            // growthRateBuffButton
            // 
            this.growthRateBuffButton.Enabled = false;
            this.growthRateBuffButton.Location = new System.Drawing.Point(15, 213);
            this.growthRateBuffButton.Name = "growthRateBuffButton";
            this.growthRateBuffButton.Size = new System.Drawing.Size(248, 23);
            this.growthRateBuffButton.TabIndex = 25;
            this.growthRateBuffButton.Text = "Apply Growth Rate Buffs";
            this.growthRateBuffButton.UseVisualStyleBackColor = true;
            this.growthRateBuffButton.Click += new System.EventHandler(this.growthRateBuffButton_Click);
            // 
            // FatesEnemyGrowthModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.growthRateBuffButton);
            this.Controls.Add(this.growthRateBuffTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resGrowthTextBox);
            this.Controls.Add(this.resGrowthLabel);
            this.Controls.Add(this.defGrowthTextBox);
            this.Controls.Add(this.defGrowthLabel);
            this.Controls.Add(this.lckGrowthTextBox);
            this.Controls.Add(this.lckGrowthLabel);
            this.Controls.Add(this.spdGrowthTextBox);
            this.Controls.Add(this.spdGrowthLabel);
            this.Controls.Add(this.sklGrowthTextBox);
            this.Controls.Add(this.sklGrowthLabel);
            this.Controls.Add(this.magGrowthTextBox);
            this.Controls.Add(this.magGrowthLabel);
            this.Controls.Add(this.strGrowthTextBox);
            this.Controls.Add(this.strGrowthLabel);
            this.Controls.Add(this.hpGrowthTextBox);
            this.Controls.Add(this.hpGrowthLabel);
            this.Controls.Add(this.classSelectorComboBox);
            this.Controls.Add(this.topMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenuStrip;
            this.Name = "FatesEnemyGrowthModifierForm";
            this.Text = "Fates Enemy Growth Modifier Tool";
            this.topMenuStrip.ResumeLayout(false);
            this.topMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog gameDataOpenFileDialog;
        private System.Windows.Forms.ComboBox classSelectorComboBox;
        private System.Windows.Forms.Label hpGrowthLabel;
        private System.Windows.Forms.TextBox hpGrowthTextBox;
        private System.Windows.Forms.Label strGrowthLabel;
        private System.Windows.Forms.TextBox strGrowthTextBox;
        private System.Windows.Forms.Label magGrowthLabel;
        private System.Windows.Forms.TextBox magGrowthTextBox;
        private System.Windows.Forms.Label sklGrowthLabel;
        private System.Windows.Forms.TextBox sklGrowthTextBox;
        private System.Windows.Forms.Label spdGrowthLabel;
        private System.Windows.Forms.TextBox spdGrowthTextBox;
        private System.Windows.Forms.Label lckGrowthLabel;
        private System.Windows.Forms.TextBox lckGrowthTextBox;
        private System.Windows.Forms.Label defGrowthLabel;
        private System.Windows.Forms.TextBox defGrowthTextBox;
        private System.Windows.Forms.Label resGrowthLabel;
        private System.Windows.Forms.TextBox resGrowthTextBox;
        private System.Windows.Forms.ToolStripMenuItem openGameDatabinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip topMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveGameDatabinToolStripMenuItem;
        private System.Windows.Forms.TextBox growthRateBuffTextBox;
        private System.Windows.Forms.Button growthRateBuffButton;
        private System.Windows.Forms.Label label2;
    }
}


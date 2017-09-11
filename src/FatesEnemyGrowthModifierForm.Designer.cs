// Copyright (c) 2017 Tom Overton

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
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.resGrowthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filenameBox
            // 
            this.filenameBox.Location = new System.Drawing.Point(13, 13);
            this.filenameBox.Multiline = true;
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(184, 23);
            this.filenameBox.TabIndex = 0;
            this.filenameBox.WordWrap = false;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(203, 13);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(69, 23);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // classSelectorComboBox
            // 
            this.classSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classSelectorComboBox.FormattingEnabled = true;
            this.classSelectorComboBox.Location = new System.Drawing.Point(13, 43);
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
            this.hpGrowthLabel.Location = new System.Drawing.Point(14, 88);
            this.hpGrowthLabel.Name = "hpGrowthLabel";
            this.hpGrowthLabel.Size = new System.Drawing.Size(68, 13);
            this.hpGrowthLabel.TabIndex = 3;
            this.hpGrowthLabel.Text = "HP Growth";
            // 
            // hpGrowthTextBox
            // 
            this.hpGrowthTextBox.Location = new System.Drawing.Point(87, 86);
            this.hpGrowthTextBox.Multiline = true;
            this.hpGrowthTextBox.Name = "hpGrowthTextBox";
            this.hpGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.hpGrowthTextBox.TabIndex = 7;
            // 
            // strGrowthLabel
            // 
            this.strGrowthLabel.AutoSize = true;
            this.strGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.strGrowthLabel.Location = new System.Drawing.Point(15, 116);
            this.strGrowthLabel.Name = "strGrowthLabel";
            this.strGrowthLabel.Size = new System.Drawing.Size(67, 13);
            this.strGrowthLabel.TabIndex = 8;
            this.strGrowthLabel.Text = "Str Growth";
            // 
            // strGrowthTextBox
            // 
            this.strGrowthTextBox.Location = new System.Drawing.Point(87, 114);
            this.strGrowthTextBox.Multiline = true;
            this.strGrowthTextBox.Name = "strGrowthTextBox";
            this.strGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.strGrowthTextBox.TabIndex = 9;
            // 
            // magGrowthLabel
            // 
            this.magGrowthLabel.AutoSize = true;
            this.magGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.magGrowthLabel.Location = new System.Drawing.Point(7, 144);
            this.magGrowthLabel.Name = "magGrowthLabel";
            this.magGrowthLabel.Size = new System.Drawing.Size(75, 13);
            this.magGrowthLabel.TabIndex = 10;
            this.magGrowthLabel.Text = "Mag Growth";
            // 
            // magGrowthTextBox
            // 
            this.magGrowthTextBox.Location = new System.Drawing.Point(87, 142);
            this.magGrowthTextBox.Multiline = true;
            this.magGrowthTextBox.Name = "magGrowthTextBox";
            this.magGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.magGrowthTextBox.TabIndex = 11;
            // 
            // sklGrowthLabel
            // 
            this.sklGrowthLabel.AutoSize = true;
            this.sklGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sklGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.sklGrowthLabel.Location = new System.Drawing.Point(13, 172);
            this.sklGrowthLabel.Name = "sklGrowthLabel";
            this.sklGrowthLabel.Size = new System.Drawing.Size(69, 13);
            this.sklGrowthLabel.TabIndex = 12;
            this.sklGrowthLabel.Text = "Skl Growth";
            // 
            // sklGrowthTextBox
            // 
            this.sklGrowthTextBox.Location = new System.Drawing.Point(87, 170);
            this.sklGrowthTextBox.Multiline = true;
            this.sklGrowthTextBox.Name = "sklGrowthTextBox";
            this.sklGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.sklGrowthTextBox.TabIndex = 13;
            // 
            // spdGrowthLabel
            // 
            this.spdGrowthLabel.AutoSize = true;
            this.spdGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spdGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.spdGrowthLabel.Location = new System.Drawing.Point(145, 88);
            this.spdGrowthLabel.Name = "spdGrowthLabel";
            this.spdGrowthLabel.Size = new System.Drawing.Size(73, 13);
            this.spdGrowthLabel.TabIndex = 14;
            this.spdGrowthLabel.Text = "Spd Growth";
            // 
            // spdGrowthTextBox
            // 
            this.spdGrowthTextBox.Location = new System.Drawing.Point(224, 86);
            this.spdGrowthTextBox.Multiline = true;
            this.spdGrowthTextBox.Name = "spdGrowthTextBox";
            this.spdGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.spdGrowthTextBox.TabIndex = 15;
            // 
            // lckGrowthLabel
            // 
            this.lckGrowthLabel.AutoSize = true;
            this.lckGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lckGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.lckGrowthLabel.Location = new System.Drawing.Point(146, 116);
            this.lckGrowthLabel.Name = "lckGrowthLabel";
            this.lckGrowthLabel.Size = new System.Drawing.Size(72, 13);
            this.lckGrowthLabel.TabIndex = 16;
            this.lckGrowthLabel.Text = "Lck Growth";
            // 
            // lckGrowthTextBox
            // 
            this.lckGrowthTextBox.Location = new System.Drawing.Point(224, 114);
            this.lckGrowthTextBox.Multiline = true;
            this.lckGrowthTextBox.Name = "lckGrowthTextBox";
            this.lckGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.lckGrowthTextBox.TabIndex = 17;
            // 
            // defGrowthLabel
            // 
            this.defGrowthLabel.AutoSize = true;
            this.defGrowthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defGrowthLabel.ForeColor = System.Drawing.Color.Black;
            this.defGrowthLabel.Location = new System.Drawing.Point(147, 144);
            this.defGrowthLabel.Name = "defGrowthLabel";
            this.defGrowthLabel.Size = new System.Drawing.Size(71, 13);
            this.defGrowthLabel.TabIndex = 18;
            this.defGrowthLabel.Text = "Def Growth";
            // 
            // defGrowthTextBox
            // 
            this.defGrowthTextBox.Location = new System.Drawing.Point(224, 142);
            this.defGrowthTextBox.Multiline = true;
            this.defGrowthTextBox.Name = "defGrowthTextBox";
            this.defGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.defGrowthTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(145, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Res Growth";
            // 
            // resGrowthTextBox
            // 
            this.resGrowthTextBox.Location = new System.Drawing.Point(224, 170);
            this.resGrowthTextBox.Multiline = true;
            this.resGrowthTextBox.Name = "resGrowthTextBox";
            this.resGrowthTextBox.Size = new System.Drawing.Size(34, 18);
            this.resGrowthTextBox.TabIndex = 21;
            // 
            // FatesEnemyGrowthModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resGrowthTextBox);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.filenameBox);
            this.Name = "FatesEnemyGrowthModifierForm";
            this.Text = "Fates Enemy Growth Modifier Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.Button openFile;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resGrowthTextBox;
    }
}


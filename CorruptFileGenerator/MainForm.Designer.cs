namespace CorruptFileGenerator
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameInputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FileSizeInputBox = new System.Windows.Forms.NumericUpDown();
            this.UnitOfMeasure = new System.Windows.Forms.ComboBox();
            this.IsRandom = new System.Windows.Forms.CheckBox();
            this.ResultFilePathInputBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChooseFolderButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.MinRandInput = new System.Windows.Forms.NumericUpDown();
            this.MaxRandInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FileSizeInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRandInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRandInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(297, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corrupted File Generator";
            // 
            // FileNameInputBox
            // 
            this.FileNameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileNameInputBox.Location = new System.Drawing.Point(73, 114);
            this.FileNameInputBox.Name = "FileNameInputBox";
            this.FileNameInputBox.Size = new System.Drawing.Size(195, 22);
            this.FileNameInputBox.TabIndex = 1;
            this.FileNameInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FileNameInputBox.TextChanged += new System.EventHandler(this.FileNameInputBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Approximate file size";
            // 
            // FileSizeInputBox
            // 
            this.FileSizeInputBox.Location = new System.Drawing.Point(94, 210);
            this.FileSizeInputBox.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.FileSizeInputBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FileSizeInputBox.Name = "FileSizeInputBox";
            this.FileSizeInputBox.Size = new System.Drawing.Size(120, 20);
            this.FileSizeInputBox.TabIndex = 5;
            this.FileSizeInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FileSizeInputBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UnitOfMeasure
            // 
            this.UnitOfMeasure.FormattingEnabled = true;
            this.UnitOfMeasure.Location = new System.Drawing.Point(220, 210);
            this.UnitOfMeasure.Name = "UnitOfMeasure";
            this.UnitOfMeasure.Size = new System.Drawing.Size(50, 21);
            this.UnitOfMeasure.TabIndex = 6;
            this.UnitOfMeasure.SelectedIndexChanged += new System.EventHandler(this.UnitOfMeasure_SelectedIndexChanged);
            // 
            // IsRandom
            // 
            this.IsRandom.AutoSize = true;
            this.IsRandom.Location = new System.Drawing.Point(351, 214);
            this.IsRandom.Name = "IsRandom";
            this.IsRandom.Size = new System.Drawing.Size(131, 17);
            this.IsRandom.TabIndex = 7;
            this.IsRandom.Text = "Random size between";
            this.IsRandom.UseVisualStyleBackColor = true;
            this.IsRandom.CheckedChanged += new System.EventHandler(this.IsRandom_CheckedChanged);
            // 
            // ResultFilePathInputBox
            // 
            this.ResultFilePathInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultFilePathInputBox.Location = new System.Drawing.Point(187, 378);
            this.ResultFilePathInputBox.Name = "ResultFilePathInputBox";
            this.ResultFilePathInputBox.Size = new System.Drawing.Size(405, 22);
            this.ResultFilePathInputBox.TabIndex = 8;
            this.ResultFilePathInputBox.TextChanged += new System.EventHandler(this.ResultFilePathInputBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(299, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Path to the folder to create it in";
            // 
            // ChooseFolderButton
            // 
            this.ChooseFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChooseFolderButton.Location = new System.Drawing.Point(621, 365);
            this.ChooseFolderButton.Name = "ChooseFolderButton";
            this.ChooseFolderButton.Size = new System.Drawing.Size(149, 44);
            this.ChooseFolderButton.TabIndex = 10;
            this.ChooseFolderButton.Text = "Choose folder";
            this.ChooseFolderButton.UseVisualStyleBackColor = true;
            this.ChooseFolderButton.Click += new System.EventHandler(this.ChooseFolderButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButton.Location = new System.Drawing.Point(321, 457);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(149, 55);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(290, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = " (with extension)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "and";
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(229, 417);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(340, 16);
            this.WarningLabel.TabIndex = 16;
            this.WarningLabel.Text = "Warning. A file with this name already exists in this folder.";
            this.WarningLabel.Visible = false;
            // 
            // MinRandInput
            // 
            this.MinRandInput.Enabled = false;
            this.MinRandInput.Location = new System.Drawing.Point(488, 214);
            this.MinRandInput.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.MinRandInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinRandInput.Name = "MinRandInput";
            this.MinRandInput.Size = new System.Drawing.Size(50, 20);
            this.MinRandInput.TabIndex = 17;
            this.MinRandInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinRandInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaxRandInput
            // 
            this.MaxRandInput.Enabled = false;
            this.MaxRandInput.Location = new System.Drawing.Point(575, 214);
            this.MaxRandInput.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.MaxRandInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxRandInput.Name = "MaxRandInput";
            this.MaxRandInput.Size = new System.Drawing.Size(50, 20);
            this.MaxRandInput.TabIndex = 18;
            this.MaxRandInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxRandInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 567);
            this.Controls.Add(this.MaxRandInput);
            this.Controls.Add(this.MinRandInput);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ChooseFolderButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultFilePathInputBox);
            this.Controls.Add(this.IsRandom);
            this.Controls.Add(this.UnitOfMeasure);
            this.Controls.Add(this.FileSizeInputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileNameInputBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Corrupt";
            ((System.ComponentModel.ISupportInitialize)(this.FileSizeInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRandInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRandInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FileSizeInputBox;
        private System.Windows.Forms.ComboBox UnitOfMeasure;
        private System.Windows.Forms.CheckBox IsRandom;
        private System.Windows.Forms.TextBox ResultFilePathInputBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChooseFolderButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.NumericUpDown MinRandInput;
        private System.Windows.Forms.NumericUpDown MaxRandInput;
    }
}


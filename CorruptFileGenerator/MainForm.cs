using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using static CorruptFileGenerator.Master;

namespace CorruptFileGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string[] Source = { "Kb", "Mb" };
            UnitOfMeasure.DataSource = Source;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void UnitOfMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IsRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (IsRandom.Checked)
            {
                FileSizeInputBox.Enabled = false;
                UnitOfMeasure.Enabled = false;

                MinRandInput.Enabled = true;
                MaxRandInput.Enabled = true;
            }
            else
            {
                FileSizeInputBox.Enabled = true;
                UnitOfMeasure.Enabled = true;

                MinRandInput.Enabled = false;
                MaxRandInput.Enabled = false;
            }
        }

        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            dialog.Description = "Choose the folder you want the file in.";
            dialog.ShowNewFolderButton = true;

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                ResultFilePathInputBox.Text = dialog.SelectedPath;
            }
            else
            {
                ResultFilePathInputBox.Text = "Error resolving foldername.";
            }

            ResultFilePathInputBox.Enabled = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ResultFilePathInputBox.Text))
            {
                MessageBox.Show("Empty or invalid path.");
                return;
            } 

            string FileName = FileNameInputBox.Text;

            string FullPath = ResultFilePathInputBox.Text + @"\" + FileName;

            if (!IsValidFilename(FileName) || !FileName.Contains('.'))
            {
                MessageBox.Show("Invalid filename.");
                return;
            }

            int min = (int)MinRandInput.Value;
            int max = (int)MaxRandInput.Value;

            int size = IsRandom.Checked ? new Random().Next(min, max) * 1024 : (int)FileSizeInputBox.Value * 1024;

            if (UnitOfMeasure.SelectedIndex == 1) size *= 1024;

            MakeFile(size, FullPath);

            if (File.Exists(FullPath)) MessageBox.Show("Successfully created file!");
        }

        private bool IsValidFilename(string s)
        {
            char[] ForbiddenChars = @"\/:*?<>|".ToCharArray();

            foreach (char c in s)
            {
                if (ForbiddenChars.Contains(c)) return false;
            }

            return true;
        }

        private void ResultFilePathInputBox_TextChanged(object sender, EventArgs e)
        {
            string path = ResultFilePathInputBox.Text + @"\" + FileNameInputBox.Text;
            if (File.Exists(path)) WarningLabel.Visible = true;
        }

        private void FileNameInputBox_TextChanged(object sender, EventArgs e)
        {
            WarningLabel.Visible = false;
            if (string.IsNullOrWhiteSpace(FileNameInputBox.Text)) StartButton.Enabled = false;
            else { StartButton.Enabled = true; }
        }
    }
}

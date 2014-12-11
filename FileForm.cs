using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SlideshowMaker
{
    public partial class FileForm : Form
    {
        private string[] filesToAdd; // from dialog
        private string fileToAdd; // from dialog
        List<string> currentFiles = new List<string>();
        private int slideLength; // in seconds
        private StreamReader streamReader;
        private StreamWriter streamWriter;

        public FileForm()
        {
            InitializeComponent();
            openFileDialog.Filter = "*.jpg;*.gif;*.png;*.bmp|*.jpg;*.gif;*.png;*.bmp|*.* ( All Files)|*.*";
            openCollectionDialog.Filter = "*.pix|*.pix";
            saveCollectionDialog.Filter = "*.pix|*.pix";
            openFileDialog.Multiselect = true;
            fileNamesList.SelectionMode = SelectionMode.MultiExtended;
            intervalChooserBox.Text = "5";
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            filesToAdd = openFileDialog.FileNames;
            if (filesToAdd.Length == 0) return;
            for (int i = 0; i < filesToAdd.Length; i++)
            {
                fileToAdd = filesToAdd[i];
                fileNamesList.Items.Add(fileToAdd);
            }
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            if (fileNamesList.SelectedIndices.Count == 0) return;
            for (int i = fileNamesList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                fileNamesList.Items.RemoveAt(fileNamesList.SelectedIndices[i]);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (fileNamesList.Items.Count == 0)
            {
                MessageBox.Show("No images to show.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!timeIntervalOk()) return;

            (new SlideViewForm(){
                Owner = this 
            }).ShowDialog();
        }

        public List<string> fileNames()
        {
            currentFiles.Clear();
            for (int i = 0; i < fileNamesList.Items.Count; i++)
            {
                currentFiles.Add(fileNamesList.Items[i].ToString());
            }
            return currentFiles;
        }

        public int getSlideLength()
        {
            return 1000 * slideLength;
        }

        public bool timeIntervalOk()
        {
            try
            {
                slideLength = Convert.ToInt32(intervalChooserBox.Text);
                if (slideLength <= 0)
                {
                    throw new Exception();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Please enter an integer time interval > 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private void openCollectionToolStripMenuItem_Click(object sender, EventArgs e) // read in files by name line by line
        {
            if (openCollectionDialog.ShowDialog() == DialogResult.OK)
            {
                fileNamesList.Items.Clear();
                streamReader = new StreamReader(openCollectionDialog.OpenFile());
                while ((fileToAdd = streamReader.ReadLine()) != null)
                {
                    fileNamesList.Items.Add(fileToAdd);
                }
                streamReader.Close();
            }
        }

        private void saveCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileNamesList.Items.Count == 0)
            {
                MessageBox.Show("No file names to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (fileToAdd != null)
            {
                saveCollectionDialog.FileName = fileToAdd;
            }
            else
            {
                saveCollectionDialog.FileName = null;
            }
            if (saveCollectionDialog.ShowDialog() == DialogResult.OK)
            {
                streamWriter = new StreamWriter(saveCollectionDialog.OpenFile());
                foreach (string itemToAdd in fileNamesList.Items)
                {
                    streamWriter.WriteLine(itemToAdd);
                }
                streamWriter.Close();
            }
        }
    }
}

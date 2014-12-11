namespace SlideshowMaker
{
    partial class FileForm
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
            this.fileNamesList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addFileButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalChooserBox = new System.Windows.Forms.TextBox();
            this.openCollectionDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveCollectionDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileNamesList
            // 
            this.fileNamesList.FormattingEnabled = true;
            this.fileNamesList.Location = new System.Drawing.Point(12, 27);
            this.fileNamesList.Name = "fileNamesList";
            this.fileNamesList.Size = new System.Drawing.Size(288, 95);
            this.fileNamesList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCollectionToolStripMenuItem,
            this.saveCollectionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCollectionToolStripMenuItem
            // 
            this.openCollectionToolStripMenuItem.Name = "openCollectionToolStripMenuItem";
            this.openCollectionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openCollectionToolStripMenuItem.Text = "Open Collection";
            this.openCollectionToolStripMenuItem.Click += new System.EventHandler(this.openCollectionToolStripMenuItem_Click);
            // 
            // saveCollectionToolStripMenuItem
            // 
            this.saveCollectionToolStripMenuItem.Name = "saveCollectionToolStripMenuItem";
            this.saveCollectionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveCollectionToolStripMenuItem.Text = "Save Collection";
            this.saveCollectionToolStripMenuItem.Click += new System.EventHandler(this.saveCollectionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(20, 41);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(75, 23);
            this.addFileButton.TabIndex = 2;
            this.addFileButton.Text = "Add";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteFileButton);
            this.groupBox1.Controls.Add(this.addFileButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Location = new System.Drawing.Point(101, 41);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFileButton.TabIndex = 3;
            this.deleteFileButton.Text = "Delete";
            this.deleteFileButton.UseVisualStyleBackColor = true;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(396, 168);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Show";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval";
            // 
            // intervalChooserBox
            // 
            this.intervalChooserBox.Location = new System.Drawing.Point(400, 226);
            this.intervalChooserBox.Name = "intervalChooserBox";
            this.intervalChooserBox.Size = new System.Drawing.Size(56, 20);
            this.intervalChooserBox.TabIndex = 6;
            // 
            // openCollectionDialog
            // 
            this.openCollectionDialog.FileName = "openFileDialog1";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 295);
            this.Controls.Add(this.intervalChooserBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileNamesList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileForm";
            this.Text = "Slideshow Maker (Deven Dayal)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fileNamesList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteFileButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intervalChooserBox;
        private System.Windows.Forms.ToolStripMenuItem openCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openCollectionDialog;
        private System.Windows.Forms.SaveFileDialog saveCollectionDialog;
    }
}


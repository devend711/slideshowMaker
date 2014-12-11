using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideshowMaker
{
    public partial class SlideViewForm : Form
    {
        private int slideNumber = 0;
        private string currentFileName;
        private Image thisImage;
        private SizeF clientSize;
        private int currentImageWidth, currentImageHeight;
        private float padding; // to center the image
        private Font font = new Font("Arial", 30);
        private Brush brush = Brushes.Red;
        private FileForm controller;
        Graphics graphics;

        public SlideViewForm()
        {
            InitializeComponent();
        }

        private void SlideViewForm_Load(object sender, EventArgs e) // setup stuff when the form is loaded
        {
            controller = (FileForm)base.Owner;
            slideTimer.Interval = controller.getSlideLength();
            slideTimer.Enabled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;

            if (slideNumber > controller.fileNames().Count - 1) // done playing
            {
                DialogResult = DialogResult.OK;
                return;
            }

            currentFileName = controller.fileNames()[slideNumber]; // get file name for current slide
            try {
                thisImage = Image.FromFile(currentFileName);
                clientSize = ClientSize;
                currentImageHeight = thisImage.Height;
                currentImageWidth = thisImage.Width;
                padding = Math.Min(clientSize.Height / (float)currentImageHeight, clientSize.Width / (float)currentImageWidth);
                // draw the image
                graphics.DrawImage(thisImage, (clientSize.Width - (float)currentImageWidth * padding) / 2f, (clientSize.Height - (float)currentImageHeight * padding) / 2f, (float)currentImageWidth * padding, (float)currentImageHeight * padding);
            }
            catch
            {
                graphics.DrawString("Not an image file!", font, brush, 25, 25);
            } 
        }

        private void slideTimer_Tick(object sender, EventArgs e) // advance the slide
        {
            slideNumber++;
            Invalidate();
        }

        private void SlideViewForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) base.DialogResult = DialogResult.OK;
        }
    }
}

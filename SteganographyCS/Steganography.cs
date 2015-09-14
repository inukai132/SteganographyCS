using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteganographyCS
{
    public partial class Steganography : Form
    {
        FileStream image;

        public Steganography()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            fileLoadDialog.ShowDialog();
        }

        private void fileLoadDialog_FileOk(object sender, CancelEventArgs e)
        {
            browseTextBox.Text = fileLoadDialog.FileName;
            loadImage((FileStream)fileLoadDialog.OpenFile());
        }

        private void Steganography_Resize(object sender, System.EventArgs e)
        {
            browseTextBox.Width = this.Width - 41;
            stegTextBox.Width = browseTextBox.Width;
        }
        
        private void loadImage(Stream fileStream)
        {
            //Get List Of File Headers From Here http://www.garykessler.net/library/file_sigs.html
        }
    }
}

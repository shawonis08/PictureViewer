using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Form1 : Form
    {
        double u_X, u_Y, d_X, d_Y;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                formBox.Load(openFileDialog1.FileName);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            formBox.Image = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            formBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            formBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnAutoSize_Click(object sender, EventArgs e)
        {
            formBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btnStretch_Click(object sender, EventArgs e)
        {
            formBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

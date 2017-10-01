using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Form1 : Form
    {

        double u_X, u_Y, d_X, d_Y;
        public List<Item> items = new List<Item>();
        private BindingSource datasource = new BindingSource();
        //PdfReader pdfReader;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //pdfReader = new PdfReader(openFileDialog1.FileName                 
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

        private void formBox_MouseDown(object sender, MouseEventArgs e)
        {
            d_X = e.X;
            d_Y = e.Y;
        }

        private void formBox_MouseUp(object sender, MouseEventArgs e)
        {
            u_X = e.X;
            u_Y = e.Y;

            Defination frmDefination = new Defination();

            frmDefination.x1 = d_X;
            frmDefination.x2 = u_X;
            frmDefination.y1 = d_Y;
            frmDefination.y2 = u_Y;

            frmDefination.Show();
            frmDefination.frm1 = this;
            this.Hide();
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

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
    public partial class Defination : Form
    {
        public double x1, x2, y1, y2 = 0;
        int len = 0;
        public Form1 frm1;
        public Defination()
        {
            InitializeComponent();
            cmbType.DataSource  = Enum.GetValues(typeof(FieldTypeEnum));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.BottomRight = new Position();
            item.TopLeft = new Position();
            item.TopLeft.X = x1;
            item.TopLeft.Y = y1;
            item.BottomRight.X = x2;
            item.BottomRight.Y = y2;

            item.Name = txtName.Text;
            if (int.TryParse(txtLength.Text, out len))
            {
                item.Length = len;
            }
            item.Type = (FieldTypeEnum)cmbType.SelectedIndex;

            frm1.items.Add(item);
            frm1.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtLength.Text = "";
            txtName.Text = "";
            frm1.Show();
            this.Hide();
        }
    }
}

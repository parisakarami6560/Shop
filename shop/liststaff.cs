using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{
    public partial class liststaff : Form
    {
        public liststaff()
        {
            InitializeComponent();
        }

        private void liststaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet55.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter1.Fill(this.shopDataSet55.staff);
            // TODO: This line of code loads data into the 'shopDataSet5.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.shopDataSet5.staff);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.staffTableAdapter.FillBy(shopDataSet5.staff, int.Parse(TXT_code_staff.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_code_staff_TextChanged(object sender, EventArgs e)
        {
            if (TXT_code_staff.Text != string.Empty)
            {
                this.staffTableAdapter.FillBy(shopDataSet5.staff, int.Parse(TXT_code_staff.Text));
            }
            else
            {
                this.staffTableAdapter.Fill(shopDataSet5.staff);
            }
        }
    }
}

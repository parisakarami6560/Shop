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
    public partial class list_employment : Form
    {
        public list_employment()
        {
            InitializeComponent();
        }

        private void list_employment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet8.managment' table. You can move, or remove it, as needed.
            this.managmentTableAdapter.Fill(this.shopDataSet8.managment);
            // TODO: This line of code loads data into the 'shopDataSet6.employment' table. You can move, or remove it, as needed.
            this.employmentTableAdapter.Fill(this.shopDataSet6.employment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.employmentTableAdapter.FillBy(shopDataSet6.employment, int.Parse(TXT_code_emplo.Text));
        }

        private void TXT_code_emplo_TextChanged(object sender, EventArgs e)
        {
            if (TXT_code_emplo.Text != string.Empty)
            {
                this.employmentTableAdapter.FillBy(shopDataSet6.employment, int.Parse(TXT_code_emplo.Text));
            }
            else
            {
                this.employmentTableAdapter.Fill(shopDataSet6.employment);
            }
        }
    }
}

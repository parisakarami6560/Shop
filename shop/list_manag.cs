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
    public partial class list_manag : Form
    {
        public list_manag()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list_manag_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet7.managment' table. You can move, or remove it, as needed.
            this.managmentTableAdapter.Fill(this.shopDataSet7.managment);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
    }
}

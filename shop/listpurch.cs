using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace shop
{
    public partial class listpurch : Form
    {
        public listpurch()
        {
            InitializeComponent();
        }
       
        //string sql;
        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void listpurchcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet49.purchase_Invoice' table. You can move, or remove it, as needed.
            this.purchase_InvoiceTableAdapter3.Fill(this.shopDataSet49.purchase_Invoice);
            // TODO: This line of code loads data into the 'shopDataSet22.purchase_Invoice' table. You can move, or remove it, as needed.
            this.purchase_InvoiceTableAdapter3.Fill(this.shopDataSet49.purchase_Invoice);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           
        }

        

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TXT_code.Text != string.Empty)
            {
                this.purchase_InvoiceTableAdapter3.FillBy(shopDataSet49.purchase_Invoice, int.Parse(TXT_code.Text));
                
            }
            else
            {
                this.purchase_InvoiceTableAdapter3.Fill(this.shopDataSet49.purchase_Invoice);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void TXT_code_TextChanged(object sender, EventArgs e)
        {
            if (TXT_code.Text != string.Empty)
            {
                this.purchase_InvoiceTableAdapter3.FillBy(shopDataSet49.purchase_Invoice, int.Parse(TXT_code.Text));
            }
            else
            {
                this.purchase_InvoiceTableAdapter3.Fill(this.shopDataSet49.purchase_Invoice);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {


                panel1.Visible = true;
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con7 = new SqlConnection(sql);
                con7.Open();
                string query7 = "select  p.code_invoic,p.number_product,p.pay_product,p.pay_saled,p.stor,p.tatal_pay,name_product from purchase_list p  inner join product on p.code_invoice_product=product.code_product  where code_invoic=@code  ";
                SqlCommand com7 = new SqlCommand(query7, con7);
                com7.Parameters.AddWithValue("@code", dataGridView1.CurrentCell.Value);
                SqlDataAdapter sdr = new SqlDataAdapter(com7);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = "کد فاکتور ";
                dataGridView2.Columns[1].HeaderText = "تعداد محصول";
                dataGridView2.Columns[2].HeaderText = "قیمت خرید";
                dataGridView2.Columns[3].HeaderText = "مبلغ فروش";
                dataGridView2.Columns[4].HeaderText = "ثبت در انبار";
                dataGridView2.Columns[5].HeaderText = "جمع کل";
                dataGridView2.Columns[6].HeaderText = "نام محصول";

                con7.Close();
            }
            catch
            {
                MessageBox.Show("لطفا بر روی شماره فاکتور کلیک نمایید");
            }

        }
    }
}

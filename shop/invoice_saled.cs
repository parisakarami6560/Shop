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
    public partial class invoice_saled : Form
    {
        public invoice_saled()
        {
            InitializeComponent();
        }
        string sql;
        private void button3_Click(object sender, EventArgs e)
        {/*
            button2.ForeColor = Color.FromArgb(139, 155, 179);
            button5.ForeColor = Color.FromArgb(139, 155, 179);
            button1.ForeColor = Color.FromArgb(139, 155, 179);
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con = new SqlConnection(sql);

            string query = "insert into customer (code_customer,fname_customer,lname_customer,tell_customer,adress_customer)  values( '" + maskedTextBox1.Text + "','" + fname.Text + "','" + lname.Text + "','" + tell.Text + "','" + adres.Text + "')";
            SqlCommand com = new SqlCommand(query, con);
            try
            {
                con.Open();

                SqlDataAdapter sd = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                com.ExecuteScalar();
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = "کد ملی";
                dataGridView2.Columns[1].HeaderText = "نام ";
                dataGridView2.Columns[2].HeaderText = "نام خانوادگی";
                dataGridView2.Columns[3].HeaderText = "آدرس";
                dataGridView2.Columns[3].HeaderText = "تلفن";

                MessageBox.Show("ذخیره اطلاعات با موفقیت انجام شد");
                invoice_saled_Load(sender, e);

                maskedTextBox1.Text = "";
                lname.Text = "";
                fname.Text = "";
                tell.Text = "";
                adres.Text = "";
                maskedTextBox1.Focus();

            }
            catch
            {
                maskedTextBox1.Text = "";
                lname.Text = "";
                fname.Text = "";
                tell.Text = "";
                adres.Text = "";
                maskedTextBox1.Focus();
                MessageBox.Show("ثبت انجام نشد اطلاعات را به درستی وارد کنید");


            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(139, 155, 179);
            button5.ForeColor = Color.FromArgb(139, 155, 179);
            button1.ForeColor = Color.FromArgb(139, 155, 179);

            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
            SqlConnection con = new SqlConnection(sql);

            string query = "update customer set  fname_customer=@fname,lname_customer=@lname,tell_customer=@tell,adress_customer=@adress   where  code_customer=@code ";

            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@fname", fname.Text);
            com.Parameters.AddWithValue("@lname", lname.Text);
            com.Parameters.AddWithValue("@tell", tell.Text);
            com.Parameters.AddWithValue("@adress", adres.Text);
            com.Parameters.AddWithValue("@code", maskedTextBox1.Text);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("تغییرات اطلاعات با موفقیت انجام شد");
                invoice_saled_Load(sender, e);
                maskedTextBox1.Text = "";
                lname.Text = "";
                fname.Text = "";
                tell.Text = "";
                adres.Text = "";
                maskedTextBox1.Focus();

            }
            catch
            {
                maskedTextBox1.Text = "";
                lname.Text = "";
                fname.Text = "";
                tell.Text = "";
                adres.Text = "";
                maskedTextBox1.Focus();
                MessageBox.Show("تغییرات انجام نشد اطلاعات را به درستی وارد کنید");


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
            SqlConnection con = new SqlConnection(sql);

            string query = "delete customer   where  code_customer=@code ";

            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@code", maskedTextBox1);


            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("حذف اطلاعات با موفقیت انجام شد");
                invoice_saled_Load(sender, e);
                maskedTextBox1.Text = "";
                lname.Text = "";
                fname.Text = "";
                tell.Text = "";
                adres.Text = "";
                maskedTextBox1.Focus();

            }
            catch
            {
                maskedTextBox1.Text = "";
                lname.Text = "";
                fname.Text = "";
                tell.Text = "";
                adres.Text = "";
                maskedTextBox1.Focus();
                MessageBox.Show("حذف انجام نشد اطلاعات را به درستی وارد کنید");


            }
        }

        private void p_invoicepurch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void invoice_saled_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                // string query = @"select * from  product  where  name_product=@name ";
                string query = "select* from  customer where  lname_customer like '%'+@name+'%' ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", textBox3.Text);
                SqlDataAdapter sd = new SqlDataAdapter(com);

                DataTable dt = new DataTable();
                sd.Fill(dt);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label68.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query = "insert into saled(code_customer)  values( '"  + txt_cus.Text + "')";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
           
        }
    }
}

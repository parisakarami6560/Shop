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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void گزارشات_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet43.product' table. You can move, or remove it, as needed.
            this.productTableAdapter2.Fill(this.shopDataSet43.product);
            // TODO: This line of code loads data into the 'shopDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.shopDataSet1.product);
            // TODO: This line of code loads data into the 'shopDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.shopDataSet.product);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioname.Checked == true)
            {
                try
                {

                    string n_server = Form1.servername;
                    string n_database = Form1.database;
                    string user = Form1.user;
                    string password = Form1.pass;
                    string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                    SqlConnection con = new SqlConnection(sql);
                    con.Open();

                    string query = "select * from  product where  name_product like '%'+@lname+'%' ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@lname", TXT_code.Text);
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    com.ExecuteScalar();
                    dataGridView1.DataSource = dt;

                    TXT_code.Text = "";
                   


                }
                catch
                {
                    MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                    TXT_code.Text = "";
                }
            }
            if (radio_code.Checked == true)
            {
                try
                {

                    string n_server = Form1.servername;
                    string n_database = Form1.database;
                    string user = Form1.user;
                    string password = Form1.pass;
                    string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                    SqlConnection con = new SqlConnection(sql);
                    con.Open();

                    string query = "select * from  product where code_product =@code ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@code", TXT_code.Text);
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    com.ExecuteScalar();
                    dataGridView1.DataSource = dt;

                    TXT_code.Text = "";
                   

                }
                catch
                {
                    MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                    TXT_code.Text = "";

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter1.InsertQuery(int.Parse(txtcode.Text), txt_name.Text, txtbrand.Text, txtcategori.Text);
                MessageBox.Show("ثبت شد");
                txtbrand.Text = "";
                txtcategori.Text = "";
                txtcode.Text = "";
                txt_name.Text = "";
                txtcode.Focus();

            }
            catch
            {
                MessageBox.Show("خطایی رخ داده دوباره تلاش کنید");
                txtbrand.Text = "";
                txtcategori.Text = "";
                txtcode.Text = "";
                txt_name.Text = "";
                txtcode.Focus();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();

                string query = "delete from  product where code_product =@code";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", textBox3.Text);
                SqlDataAdapter sd = new SqlDataAdapter(com);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                com.ExecuteScalar();
                dataGridView1.DataSource = dt;
               
                textBox3.Text = "";
               

            }
            catch
            {
                MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                TXT_code.Text = "";
                
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {


                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = "update  product   set  name_product=@name,brand=@brand,kind=@kind,WEIGHT_PRODUCT=@wp   where   code_product=@code ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", txtnameedit.Text);
                com.Parameters.AddWithValue("@brand", txtbrand.Text);
                com.Parameters.AddWithValue("@kind", txtcategoori.Text);
                com.Parameters.AddWithValue("@code", txtcodesupp.Text);
                com.Parameters.AddWithValue("@wp", txtw.Text);
               
                com.ExecuteNonQuery();





                MessageBox.Show("تغییر اطلاعات با موفقیت انجام شد");



                txtw.Text = "";
                txtbranddit.Text = "";
                txtw.Text = "";
                txtnameedit.Text = "";
                txtcategoori.Text = "";

            }


            catch
            {

              
                txtbranddit.Text = "";
                txtw.Text = "";
                txtnameedit.Text = "";

                MessageBox.Show("تغییر انجام نشد اطلاعات را به درستی وارد کنید");


            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }
        public string code;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
        textBox3.Text= txtcodesupp.Text =txtcode.Text= TXT_code.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            code= txtcodesupp.Text = txtcode.Text = TXT_code.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        public void gride()
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con = new SqlConnection(sql);
            con.Open();

            string query = "select * from  product  ";
            SqlCommand com = new SqlCommand(query, con);

            SqlDataAdapter sd = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            sd.Fill(dt);
            com.ExecuteScalar();
            dataGridView1.DataSource = dt;
        }
        private void TXT_code_TextChanged(object sender, EventArgs e)
        {
            if (radioname.Checked == true)
            {
                if (TXT_code.Text != string.Empty)
                {
                    try
                    {

                        string n_server = Form1.servername;
                        string n_database = Form1.database;
                        string user = Form1.user;
                        string password = Form1.pass;
                        string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                        SqlConnection con = new SqlConnection(sql);
                        con.Open();

                        string query = "select * from  product where  name_product like '%'+@lname+'%' ";
                        SqlCommand com = new SqlCommand(query, con);
                        com.Parameters.AddWithValue("@lname", TXT_code.Text);
                        SqlDataAdapter sd = new SqlDataAdapter(com);

                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                       // com.ExecuteScalar();
                        dataGridView1.DataSource = dt;


                    }
                    catch
                    {
                        MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                        TXT_code.Text = "";
                    }
                }
                else
                {
                    gride();
                }
            }

            if (radio_code.Checked == true)
            {
                if (TXT_code.Text != string.Empty)
                {

                    try
                    {
                        string n_server = Form1.servername;
                        string n_database = Form1.database;
                        string user = Form1.user;
                        string password = Form1.pass;
                        string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                        SqlConnection con = new SqlConnection(sql);
                        con.Open();

                        string query = "select * from  product where code_product =@code ";
                        SqlCommand com = new SqlCommand(query, con);
                        com.Parameters.AddWithValue("@code", TXT_code.Text);
                        SqlDataAdapter sd = new SqlDataAdapter(com);

                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        com.ExecuteScalar();
                        dataGridView1.DataSource = dt;


                    }
                    catch
                    {
                        MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                        TXT_code.Text = "";

                    }
                }

                else
                {
                    gride();
                }
            }
         
        }
    }
}

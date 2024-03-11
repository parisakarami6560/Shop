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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
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

                    string query = "select * from  customer  where  lname_customer like '%'+@lname+'%' ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@lname", TXT_code.Text);
                    com.ExecuteNonQuery();
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);
               
                 dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "نام";
                    dataGridView1.Columns[1].HeaderText = "نام خانوادگی";
                    dataGridView1.Columns[2].HeaderText = "تلفن";
                    dataGridView1.Columns[3].HeaderText = "ادرس";
                    dataGridView1.Columns[4].HeaderText = "کد مشتری";

                    customer_Load(sender, e);
                   


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

                    string query = "select * from  customer  where  code_customer =@code ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@code", TXT_code.Text);
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    com.ExecuteScalar();
                    dataGridView1.DataSource = dt;
                   
                
                    customer_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");
                    
                    TXT_code.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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

                string query = "delete from  customer where  code_customer =@code";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", textBox1.Text);
                SqlDataAdapter sd = new SqlDataAdapter(com);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                com.ExecuteScalar();
                dataGridView1.DataSource = dt;

                TXT_code.Text = "";
                textBox1.Text = "";
                customer_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                TXT_code.Text = "";
                textBox1.Text = "";
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            
        }

        private void TXT_code_TextChanged(object sender, EventArgs e)
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

                    string query = "select * from  customer  where  lname_customer like '%'+@lname+'%' ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@lname", TXT_code.Text);
                    com.ExecuteNonQuery();
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "نام";
                    dataGridView1.Columns[1].HeaderText = "نام خانوادگی";
                    dataGridView1.Columns[2].HeaderText = "تلفن";
                    dataGridView1.Columns[3].HeaderText = "ادرس";
                    dataGridView1.Columns[4].HeaderText = "کد مشتری";

                    customer_Load(sender, e);



                }
                catch
                {
                    MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                    TXT_code.Text = "";
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

                        string query = "select * from  customer  where  code_customer =@code ";
                        SqlCommand com = new SqlCommand(query, con);
                        com.Parameters.AddWithValue("@code", TXT_code.Text);
                        com.ExecuteNonQuery();
                        SqlDataAdapter sd = new SqlDataAdapter(com);

                        DataTable dt = new DataTable();
                        sd.Fill(dt);

                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].HeaderText = "نام";
                        dataGridView1.Columns[1].HeaderText = "نام خانوادگی";
                        dataGridView1.Columns[2].HeaderText = "تلفن";
                        dataGridView1.Columns[3].HeaderText = "ادرس";
                        dataGridView1.Columns[4].HeaderText = "کد مشتری";

                        customer_Load(sender, e);

                    }
                    catch
                    {
                        MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                        TXT_code.Text = "";
                    }
                }
                else
                {
                    string n_server = Form1.servername;
                    string n_database = Form1.database;
                    string user = Form1.user;
                    string password = Form1.pass;
                    string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                    SqlConnection con = new SqlConnection(sql);
                    con.Open();

                    string query = "select * from  customer  ";
                    SqlCommand com = new SqlCommand(query, con);
                   
                    com.ExecuteNonQuery();
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radio_code_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioname_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

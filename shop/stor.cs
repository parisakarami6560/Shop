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
    public partial class stor : Form
    {
        public stor()
        {
            InitializeComponent();
        }

        private void stor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet42.stor' table. You can move, or remove it, as needed.
            this.storTableAdapter1.Fill(this.shopDataSet42.stor);
            // TODO: This line of code loads data into the 'shopDataSet41.purchase_list' table. You can move, or remove it, as needed.
            this.purchase_listTableAdapter.Fill(this.shopDataSet41.purchase_list);
            // TODO: This line of code loads data into the 'shopDataSet21.stor' table. You can move, or remove it, as needed.
            //   this.storTableAdapter.Fill(this.shopDataSet21.stor);
            // TODO: This line of code loads data into the 'shopDataSet20.stor' table. You can move, or remove it, as needed.
            //  this.storTableAdapter1.Fill(this.shopDataSet20.stor);
            // TODO: This line of code loads data into the 'shopDataSet2.stor' table. You can move, or remove it, as needed.
            //   this.storTableAdapter.Fill(this.shopDataSet2.stor);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

                    string query = "select * from  stor where  name_product like '%'+@lname+'%' ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@lname", TXT_code.Text);
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    com.ExecuteScalar();
                    dataGridView2.DataSource = dt;

                }
                catch
                {
                    MessageBox.Show("خطایی رخ داده");
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

                        string query = "select * from  stor where  code_stro_product=@code ";
                        SqlCommand com = new SqlCommand(query, con);
                        com.Parameters.AddWithValue("@code", TXT_code.Text);
                        SqlDataAdapter sd = new SqlDataAdapter(com);

                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        com.ExecuteScalar();
                        dataGridView2.DataSource = dt;

                     
                    }
                catch
                {
                    MessageBox.Show("خطایی رخ داده");
                    TXT_code.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.storTableAdapter.InsertQuery(int.Parse(TXT_code.Text));
            this.purchase_listTableAdapter.UpdateQuery(int.Parse(TXT_code.Text));
            stor_Load(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("برای حذف مطمعن هستید؟?", "هشدار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.Yes)
            {
                this.storTableAdapter.DeleteQuery(int.Parse(TXT_code.Text));
                dataGridView2.Refresh();
            }
            stor_Load(sender, e);
        }
        public int perpay ;
        public int number;
        public int paysaled;
        private void button5_Click(object sender, EventArgs e)
        {
          //  try
          //  {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
            con.Open();
                string query = "select * from purchase_list where code_invoice_product = @code";
                SqlCommand comm = new SqlCommand(query, con);
                comm.Parameters.AddWithValue("@code", int.Parse(TXT_code.Text));
                SqlDataReader reader = comm.ExecuteReader();
                if(reader.Read())
                {
                    perpay = int.Parse(reader["pay_product"].ToString());
                number= int.Parse(reader["number_product"].ToString());
                paysaled = int.Parse(reader["pay_saled"].ToString());
            }
            con.Close();
            string query1 = "update stor set number_p_stor=number_p_stor+@number ,  pay_saled=@pay, pay_pur=@pu where code_stro_product=@code ";
            SqlConnection con1 = new SqlConnection(sql);
            con1.Open();
          
            SqlCommand com1 = new SqlCommand(query1, con1);
            com1.Parameters.AddWithValue("@code", int.Parse(TXT_code.Text));
            com1.Parameters.AddWithValue("@number", number);
            com1.Parameters.AddWithValue("@pay", paysaled);
            com1.Parameters.AddWithValue("@pu", perpay);
            com1.ExecuteNonQuery();
            stor_Load(sender, e);
            con1.Close();
            this.purchase_listTableAdapter.UpdateQuery(int.Parse(TXT_code.Text));
            stor_Load(sender, e);
            // }
            /*  catch
              {

                  TXT_code.Text = "";
                  MessageBox.Show("خطایی رخ داده دوباره تلاش کنید");
              }*/

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
          TXT_code.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

                string query = "select * from  stor  ";
                SqlCommand com = new SqlCommand(query, con);

                SqlDataAdapter sd = new SqlDataAdapter(com);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                com.ExecuteScalar();
                dataGridView2.DataSource = dt;

            
            }
            catch
            {
                MessageBox.Show("خطایی رخ داده");
                TXT_code.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            TXT_code.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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

                    string query = "select * from  stor where  name_product like '%'+@lname+'%' ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@lname", TXT_code.Text);
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    com.ExecuteScalar();
                    dataGridView2.DataSource = dt;

                
                }
                catch
                {
                    MessageBox.Show("خطایی رخ داده");
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

                    string query = "select * from  stor where  code_stro_product=@code ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@code", TXT_code.Text);
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    com.ExecuteScalar();
                    dataGridView2.DataSource = dt;

                   
                }
                catch
                {
                    MessageBox.Show("خطایی رخ داده");
                    TXT_code.Text = "";
                }
            }
        }
    }
}

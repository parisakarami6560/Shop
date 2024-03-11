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
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
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
                string query = "insert into supplier(name_supplier,tell,adress,name_marketer,tell_marketere)values(@namesupp,@t,@a,@name,@tell_m) ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@namesupp", txtnamesupp.Text);
                com.Parameters.AddWithValue("@t", txt_tell.Text);
                com.Parameters.AddWithValue("@a", txtadress.Text);
                com.Parameters.AddWithValue("@name", txtlnamemarketer.Text);
                com.Parameters.AddWithValue("@tell_m", txttellmarketer.Text);
                com.ExecuteNonQuery();
             MessageBox.Show("تامیین کننده ی جدید ثیت شد");
             /*   SqlDataAdapter sdr = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;*/
                supplier_Load(sender, e);
                txtadress.Text = "";
                txtcodesupp.Text = "";
                txttellmarketer.Text = "";
                txt_tell.Text = "";
                txtlnamemarketer.Text = "";
                txtnamesupp.Text = "";
                
               
                dataGridView1.Refresh();
                // supplier_Load(sender, e);
                con.Close();
            }
            catch
            {
                MessageBox.Show("اطلاعات را به درستی وارد کنید");
            }
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet44.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.shopDataSet44.supplier);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query = "select * from supplier ";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            supplier_Load(sender, e);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

                    string query = "select * from  supplier  where  name_supplier like '%'+@lname+'%' ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@lname", TXT_code.Text);
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    com.ExecuteScalar();
                    dataGridView1.DataSource = dt;


                    TXT_code.Text = "";
                    supplier_Load(sender, e);


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

                    string query = "select * from  supplier  where  code_SUPPLIER =@code ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@code", TXT_code.Text);
                    SqlDataAdapter sd = new SqlDataAdapter(com);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    com.ExecuteScalar();
                    dataGridView1.DataSource = dt;

                    TXT_code.Text = "";
                    supplier_Load(sender, e);

                }
                catch
                {
                    MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                    TXT_code.Text = "";

                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
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

                string query = "delete from  supplier  where  code_SUPPLIER =@code";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", textBox1.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("حذف با موفقیت انجام شد");
              /*  SqlDataAdapter sd = new SqlDataAdapter(com);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                com.ExecuteScalar();
                dataGridView1.DataSource = dt;*/
                supplier_Load(sender, e);
             
                textBox1.Text = "";
                
            }
            catch
            {
                MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                TXT_code.Text = "";
                textBox1.Text = "";
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
                string query = "update  supplier   set  name_supplier=@fname,tell=@tell,adress=@adress,name_marketer=@namem ,tell_marketere=@tellma  where   code_SUPPLIER=@code ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@fname", txtnameedit.Text);
                com.Parameters.AddWithValue("@tell", txtfamilyedit.Text);
                com.Parameters.AddWithValue("@adress",txtadreessupp.Text);
                com.Parameters.AddWithValue("@code", txtcodesupp.Text);
                com.Parameters.AddWithValue("@namem", txttelledit.Text);
                com.Parameters.AddWithValue("@tellma", txtadresedit.Text);
                com.ExecuteNonQuery();

                supplier_Load(sender, e);



                MessageBox.Show("تغییر اطلاعات با موفقیت انجام شد");



                txtadresedit.Text = "";
                txtfamilyedit.Text = "";
                txttelledit.Text = "";
                txtnameedit.Text = "";
                txtadreessupp.Text = "";
                txtcodesupp.Text = "";

            }


            catch
            {

                txtadresedit.Text = "";
                txtfamilyedit.Text = "";
                txttelledit.Text = "";
                txtnameedit.Text = "";
                txtcodesupp.Text = "";

                MessageBox.Show("تغییر انجام نشد اطلاعات را به درستی وارد کنید");


            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

         public void graid()

                {
                    string n_server = Form1.servername;
        string n_database = Form1.database;
        string user = Form1.user;
        string password = Form1.pass;
        string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
        SqlConnection con = new SqlConnection(sql);
        con.Open();

                    string query = "select * from  supplier   ";
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

                        string query = "select * from  supplier  where  name_supplier like '%'+@lname+'%' ";
                        SqlCommand com = new SqlCommand(query, con);
                        com.Parameters.AddWithValue("@lname", TXT_code.Text);
                        SqlDataAdapter sd = new SqlDataAdapter(com);

                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        com.ExecuteScalar();
                        dataGridView1.DataSource = dt;


                        supplier_Load(sender, e);


                    }
                    catch
                    {
                        MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                        TXT_code.Text = "";
                    }
                }
                else
                {
                    graid();

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

                        string query = "select * from  supplier  where  code_SUPPLIER =@code ";
                        SqlCommand com = new SqlCommand(query, con);
                        com.Parameters.AddWithValue("@code", TXT_code.Text);
                        SqlDataAdapter sd = new SqlDataAdapter(com);

                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        com.ExecuteScalar();
                        dataGridView1.DataSource = dt;

                        supplier_Load(sender, e);

                    }
                    catch
                    {
                        MessageBox.Show("خطایی رخ داده دوباره امتحان کنید");

                        TXT_code.Text = "";

                    }
                }
                else
                {

                    graid();
                }
            }
        }
        public string code;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
       TXT_code.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            code= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
    }
}

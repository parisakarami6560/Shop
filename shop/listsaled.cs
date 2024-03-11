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
    public partial class listsaled : Form
    {
        public listsaled()
        {
            InitializeComponent();
        }
        string sql;
        private void button3_Click(object sender, EventArgs e)
        {/*
            button2.ForeColor = Color.FromArgb(139, 155, 179);
            button5.ForeColor = Color.FromArgb(139, 155, 179);
            button1.ForeColor = Color.FromArgb(139, 155, 179);
            button4.ForeColor = Color.FromArgb(139, 155, 179);
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            // sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
            SqlConnection con = new SqlConnection(sql);

            string query = "insert into prilistsail(code_lsaled_product,number_product_s,code_list,kindpay)  values( '" + txtcodecus.Text + "','" + txtnumberpro.Text + "','" + txtcodlist.Text + "','" + com_lsaild.Text + "')";
            SqlCommand com = new SqlCommand(query, con);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("ذخیره اطلاعات با موفقیت انجام شد");

                txtcodlist.Text = "";
                txtcodecus.Text = "";
                txtnumberpro.Text = "";
                com_lsaild.Text = "";
                txtcodecus.Focus();

            }
            catch
            {
                txtcodlist.Text = "";
                txtcodecus.Text = "";
                txtnumberpro.Text = "";
                com_lsaild.Text = "";
                txtcodecus.Focus();
                MessageBox.Show("ثبت انجام نشد اطلاعات را به درستی وارد کنید");


            }*/
        }

        private void listsaled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet47.saled' table. You can move, or remove it, as needed.
          //  this.saledTableAdapter3.Fill(this.shopDataSet47.saled);
            // TODO: This line of code loads data into the 'shopDataSet33.saled' table. You can move, or remove it, as needed.
          //  this.saledTableAdapter1.Fill(this.shopDataSet33.saled);
            // TODO: This line of code loads data into the 'shopDataSet34.saled' table. You can move, or remove it, as needed.
          //  this.saledTableAdapter2.Fill(this.shopDataSet34.saled);
            // TODO: This line of code loads data into the 'shopDataSet33.saled' table. You can move, or remove it, as needed.
           // this.saledTableAdapter1.Fill(this.shopDataSet33.saled);
            // TODO: This line of code loads data into the 'shopDataSet23.saled' table. You can move, or remove it, as needed.
          //  this.saledTableAdapter.Fill(this.shopDataSet23.saled);
           //txtcodecus.Focus();
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
            SqlConnection con = new SqlConnection(sql);
            con.Open();

            SqlCommand comm = new SqlCommand();
            comm.CommandText = ("select  * from saled");
            comm.Connection = con;
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = comm;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].HeaderText = " قیمت کل هر محصول";
            dataGridView2.Columns[1].HeaderText = "تعداد خرید";
            dataGridView2.Columns[2].HeaderText = "مالیات";
            dataGridView2.Columns[3].HeaderText = "تعداد کل با مالیات";
            dataGridView2.Columns[4].HeaderText = "تاریخ فاکتور";
            dataGridView2.Columns[5].HeaderText = "زمان فاکتور";
            dataGridView2.Columns[6].HeaderText = "کد فاکتور";
            dataGridView2.Columns[7].HeaderText = "کد مشتری";
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  button2.ForeColor = Color.FromArgb(139, 155, 179);
            button5.ForeColor = Color.FromArgb(139, 155, 179);
            button3.ForeColor = Color.FromArgb(139, 155, 179);
            button4.ForeColor = Color.FromArgb(139, 155, 179);
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
            SqlConnection con = new SqlConnection(sql);

            string query = "update code_list set code_lsaled_product=@code ,number_product_s=@numberp,code_list=@codcus,kindpay=@kind ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@code", txtcodecus.Text);
            com.Parameters.AddWithValue("@numberp", txtnumberpro.Text);
            com.Parameters.AddWithValue("@codcus", txtcodlist.Text);
            com.Parameters.AddWithValue("@kind", com_lsaild.Text);
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("تغییر اطلاعات با موفقیت انجام شد");
                txtcodlist.Text = "";
                txtcodecus.Text = "";
        
                txtcodecus.Focus();

            }
            catch
            {
                txtcodlist.Text = "";
                txtcodecus.Text = "";

                txtcodecus.Focus();
                MessageBox.Show("تغییر انجام نشد اطلاعات را به درستی وارد کنید");
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
      
         /*   DialogResult = MessageBox.Show("ایا برای حذف مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                // sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
                SqlConnection con = new SqlConnection(sql);

                string query = "delete  from  list_saled  where ccode_customer=@code ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", txtcodlist.Text);
                try
                {

                    con.Open();
                    com.ExecuteNonQuery(); MessageBox.Show("حذف اطلاعات با موفقیت انجام شد");
                    txtcodlist.Text = "";
                    txtcodecus.Text = "";
                
                    txtcodecus.Focus();

                }
                catch
                {
                    txtcodlist.Text = "";
                    txtcodecus.Text = "";
                 
                    txtcodecus.Focus();
                    MessageBox.Show("حذف انجام نشد اطلاعات را به درستی وارد کنید");
                }*/

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  this.saledTableAdapter1.FillBy(shopDataSet33.saled, int.Parse(txtcodlist.Text));
            //  listsaled_Load(sender, e);


            if (radio_code.Checked == true)
            {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
                SqlConnection con = new SqlConnection(sql);

                string query = "select *  from  saled  where code_customer=@code";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", TXT_code.Text);
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = com;
                DataTable dt1 = new DataTable();
                ad.Fill(dt1);
                dataGridView2.DataSource = dt1;
            }

            if (radioname.Checked == true)
            {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
                SqlConnection con = new SqlConnection(sql);

                string query = "select *  from  saled  where code_saled=@code";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", TXT_code.Text);
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = com;
                DataTable dt1 = new DataTable();
                ad.Fill(dt1);
                dataGridView2.DataSource = dt1;
            }

            if (radiodate.Checked == true)
            {
                label7.Visible =false;
                TXT_code.Visible = false;

                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
                SqlConnection con = new SqlConnection(sql);

                string query = "select *  from  saled  where data_saled  between  @p and @n  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@p",Convert.ToDateTime( dateTimePicker2.Text));
                com.Parameters.AddWithValue("@n",Convert.ToDateTime( dateTimePicker1.Text));
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = com;
                DataTable dt1 = new DataTable();
                ad.Fill(dt1);
                dataGridView2.DataSource = dt1;
            }

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel4.Enabled = false;
        }

        private void lblsaled_Click(object sender, EventArgs e)
        {
         //   lblproduvt.Enabled = false;
         
        }

        private void lblproduvt_Click(object sender, EventArgs e)
        {
           
          //  this.saledTableAdapter.FillBy_codsaled(shopDataSet23.saled, int.Parse(txtcodecus.Text));
          //  dataGridView2.Refresh();


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcodlist_TextChanged(object sender, EventArgs e)
        {
           // txtcodecus.Enabled = false;
        //  txtcodlist.Enabled = true;
        }

        private void txtcodecus_TextChanged(object sender, EventArgs e)
        {
          //  txtcodlist.Enabled = false;
          //  txtcodecus.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void p_لیستخرید_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
            SqlConnection con = new SqlConnection(sql);

            string query = "select *  from  saled ";
            SqlCommand com = new SqlCommand(query, con);
           
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = com;
            DataTable dt1 = new DataTable();
            ad.Fill(dt1);
            dataGridView2.DataSource = dt1;
           // dataGridView2.Refresh();
            //listsaled_Load(sender, e);
            }

        private void radiodate_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label7.Visible = false;
            TXT_code.Visible = false;
        }

        private void radioname_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label7.Visible = true;
            TXT_code.Visible = true;
        }

        private void radio_code_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label7.Visible = true;
            TXT_code.Visible = true;
        }

        private void TXT_code_TextChanged(object sender, EventArgs e)
        {
            if (TXT_code.Text != string.Empty)
            {
                if (radio_code.Checked == true)
                {
                    string n_server = Form1.servername;
                    string n_database = Form1.database;
                    string user = Form1.user;
                    string password = Form1.pass;
                    sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                    //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
                    SqlConnection con = new SqlConnection(sql);

                    string query = "select *  from  saled  where code_customer=@code";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@code", TXT_code.Text);
                    SqlDataAdapter ad = new SqlDataAdapter();
                    ad.SelectCommand = com;
                    DataTable dt1 = new DataTable();
                    ad.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                }

                if (radioname.Checked == true)
                {
                    string n_server = Form1.servername;
                    string n_database = Form1.database;
                    string user = Form1.user;
                    string password = Form1.pass;
                    sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                    //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
                    SqlConnection con = new SqlConnection(sql);

                    string query = "select *  from  saled  where code_saled=@code";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@code", TXT_code.Text);
                    SqlDataAdapter ad = new SqlDataAdapter();
                    ad.SelectCommand = com;
                    DataTable dt1 = new DataTable();
                    ad.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                }

                if (radiodate.Checked == true)
                {
                    label7.Visible = false;
                    TXT_code.Visible = false;

                    string n_server = Form1.servername;
                    string n_database = Form1.database;
                    string user = Form1.user;
                    string password = Form1.pass;
                    sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                    //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
                    SqlConnection con = new SqlConnection(sql);

                    string query = "select *  from  saled  where data_saled  between  @p and @n  ";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@p", dateTimePicker2.Text);
                    com.Parameters.AddWithValue("@n", dateTimePicker1.Text);
                    SqlDataAdapter ad = new SqlDataAdapter();
                    ad.SelectCommand = com;
                    DataTable dt1 = new DataTable();
                    ad.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                }
            }
            else {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
                SqlConnection con = new SqlConnection(sql);

                string query = "select *  from  saled ";
                SqlCommand com = new SqlCommand(query, con);

                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = com;
                DataTable dt1 = new DataTable();
                ad.Fill(dt1);
                dataGridView2.DataSource = dt1;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
       try
       {
                panel3.Visible = true;
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con7 = new SqlConnection(sql);
                con7.Open();
                string query7 = "select * from list_saled where code_saled=@code  ";
                SqlCommand com7 = new SqlCommand(query7, con7);
                com7.Parameters.AddWithValue("@code",dataGridView2.CurrentCell.Value);
                SqlDataAdapter sdr = new SqlDataAdapter(com7);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "کد محصول ";
                dataGridView1.Columns[1].HeaderText = "تعداد محصول";
                dataGridView1.Columns[2].HeaderText = "قیمت واحد";
                dataGridView1.Columns[3].HeaderText = "جمع کل";
                dataGridView1.Columns[4].HeaderText = "کد فاکتور";
                dataGridView1.Columns[5].HeaderText = "نام محصول";


                con7.Close();
      }
         catch
           { MessageBox.Show("لطفا بر روی شماره فاکتور کلیک نمایید"); }
        }
    }
}


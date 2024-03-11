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
    public partial class pruceduredatesaled : Form
    {
        public pruceduredatesaled()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void pruceduredatesaled_Load(object sender, EventArgs e)
        {

        }

      

      

        private void textBox1_Enter(object sender, EventArgs e)
        {
            report s = new report();
            s.ShowDialog();
            textBox1.Text = s.code;
            s.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query = "select * from codeproduct where  code_lsaled_product=@code and data_saled between @parametr  and @value ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@code", textBox1.Text);
            com.Parameters.AddWithValue("@parametr", Convert.ToDateTime(dateTimePicker1.Text));
            com.Parameters.AddWithValue("@value",Convert.ToDateTime (dateTimePicker2.Text));
            com.ExecuteNonQuery();
            SqlDataAdapter rd = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            rd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "کد محصول";
            dataGridView1.Columns[1].HeaderText = "نام محصول";
            dataGridView1.Columns[2].HeaderText = "کد فاکتور ";
            dataGridView1.Columns[3].HeaderText = "تاریخ فروش ";
            dataGridView1.Columns[4].HeaderText = "جمع کل فروش";

            SqlDataAdapter sd = new SqlDataAdapter(com);
            DataSet dt1 = new DataSet();
            sd.Fill(dt1, "codeproduct");
            dataGridView1.DataSource = dt1.Tables["codeproduct"].DefaultView;
            CrystalReport2 rpt = new CrystalReport2();
            rpt.SetDataSource(dt1);
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            string tarikh = p.GetYear(DateTime.Now) + "\\";
            tarikh += p.GetMonth(DateTime.Now) + "\\";
            tarikh += p.GetDayOfMonth(DateTime.Now);
            rpt.SetParameterValue(0, tarikh);
           Formprint frm = new Formprint();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
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
            string query = "select * from codeproduct where  code_lsaled_product=@code and data_saled between @parametr  and @value ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@code", textBox1.Text);
            com.Parameters.AddWithValue("@parametr", Convert.ToDateTime(dateTimePicker1.Text));
            com.Parameters.AddWithValue("@value", Convert.ToDateTime(dateTimePicker2.Text));
            com.ExecuteNonQuery();
            SqlDataAdapter rd = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            rd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "کد محصول";
            dataGridView1.Columns[1].HeaderText = "نام محصول";
            dataGridView1.Columns[2].HeaderText = "کد فاکتور ";
            dataGridView1.Columns[3].HeaderText = "تاریخ فروش ";
            dataGridView1.Columns[4].HeaderText = "جمع کل فروش";

            string query1 = " select sum(total_pay) as total from list_saled inner join saled on list_saled.code_saled=saled.code_saled group by code_lsaled_product having code_lsaled_product=@code  ";

            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con1 = new SqlConnection(sql);
            con1.Open();
            SqlCommand com1 = new SqlCommand(query1, con1);
            com1.Parameters.AddWithValue("@code", textBox1.Text);
            SqlDataReader read = com1.ExecuteReader();
            if (read.Read())
            {
                label4.Text = read["total"].ToString();
            }
            dataGridView1.Columns[0].HeaderText = "کد محصول";
            dataGridView1.Columns[1].HeaderText = "نام محصول";
            dataGridView1.Columns[2].HeaderText = "کد فاکتور ";
            dataGridView1.Columns[3].HeaderText = "تاریخ فروش ";
            dataGridView1.Columns[4].HeaderText = "جمع کل فروش";
        }
    }
}

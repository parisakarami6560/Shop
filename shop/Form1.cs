using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = "server.txt";
      
        static public   string servername = "";
        static public string database = "";
        static public string user = "";
        static public string pass = "";
        static public string sql;
        static public string typ="";
        public void conection()
        {
            if (File.Exists(path))
            {
               try
              {
                    string[] q = File.ReadAllText(path).Split('/');
                    servername = q[0];
                    database = q[1];
                    user = q[2];
                    pass = q[3];
                    sql = "Data Source=" + servername + ";Initial Catalog=" + database + ";User Id=" + user + ";password=" + pass;
                    SqlConnection con = new SqlConnection(sql);
                    SqlCommand com = new SqlCommand("select * from employment ",con);
                    con.Open();
                    panel1.Visible = true;
                    panel1.Location = new Point(100, 50);
                    panel1.Height = 0;
                    timer3.Enabled = true;
                    button3.Visible = false;

                }
              catch
                {
                    panel1.Visible = false;
                    panel1.Dock = DockStyle.None;

                    panel2.Visible = true;
                    //panel2.Dock = DockStyle.Fill;
                  panel2.Location = new Point(100, 50);
                 panel2.Height = 0;
                    timer2.Enabled = true;

                }
            }
           else
            {
                //File.WriteAllText(path, "");
                // panel2.Dock = DockStyle.Fill;
                // panel1.Dock = DockStyle.None;
                panel2.Visible = true;
                panel2.Location = new Point(100, 50);
                panel2.Height = 0;
                timer2.Enabled = true;
            }
            }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            // panel1.Dock = DockStyle.Fill;
            // panel1.Location = new Point(100,50);
            // panel1.Height = 0;
            panel1.Visible = false;
            button3.Top = 250;
            button3.Left = 12;
            button3.Height = 50;
            button3.Text = "خروج";
            conection();
            //this.BackgroundImage = Image.FromFile("D:\\OIP(2).jpg");
        }

      private void timer1_Tick(object sender, EventArgs e)
        {
           panel1.Height +=20;
          if (panel1.Height==140)
              timer1.Enabled = false;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            servername = txtserver.Text;
            database = txtdata.Text;
            user = txtuser.Text;
            pass = txtpass.Text;
            sql = "Data Source=" + servername + ";Initial Catalog=" + database + ";User Id=" + user + ";password=" + pass;
            try
            {
                SqlConnection con = new SqlConnection(sql);
                SqlCommand com = new SqlCommand("select * from employment ",con);
                con.Open();
                string s = txtserver.Text + "/" + txtdata.Text + "/" + txtuser.Text + "/" + txtpass.Text;
                File.WriteAllText(path, s);
                MessageBox.Show("Conected");
                panel2.Visible = false;
                panel1.Visible = true;
                panel1.Location = new Point(100, 50);
                panel1.Height = 0;
                timer3.Enabled = true;
                button3.Visible = false;
            }
            catch
            {
                MessageBox.Show("not connect");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query = @"select * from employment  where username=@user and pass=@pass  " ;
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@user", TXT_USER.Text);
            com.Parameters.AddWithValue("@pass", TXT_PASS.Text);
            
            SqlDataReader reader = com.ExecuteReader();
            if(reader.Read())
            {
              typ = reader["typ"].ToString();
                // MessageBox.Show(reader[1].ToString() + " " + reader[2].ToString() + " " + "wellcom");
                if (typ == "manager")
                {
                    MessageBox.Show("ورود به کارتابل مدیریت");
                         }
                else
                {
                    MessageBox.Show("ورود به کارتابل فروش");
                }
                Form2 a = new Form2();
                a.Top = this.Top;
                a.Left = this.Left;
                this.Hide();
                a.ShowDialog();
                
            }
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Height += 20;
            if (panel2.Height == 295)
            timer2.Enabled = false; 
              
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel1.Height += 20;
            if (panel1.Height == 140)
                timer3.Enabled = false;

        }
    }
}

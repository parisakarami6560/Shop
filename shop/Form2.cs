using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace shop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static public string code_product = "";
        static public string name_product = "";
        static public string code = "";
        static public string perpay = "";
        static public string number1 = "";
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            // panel3.Visible = true;
            // panel3.Height =0;
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            //panel3.Height = 0;
            label1.ForeColor = Color.Black;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            timer1.Enabled = true;
            panel3.Location = new Point(1260, 68);
            panel3.Height = 0;
            panel2.Visible = false;
            panel2.Height = 0;
            panel4.Visible = false;
            panel4.Height = 0;
            label1.ForeColor = Color.Red;
            panel13.Visible = false;
            panel13.Height = 0;

            panel17.Height = 0;
            panel17.Visible = false;
            panel37.Visible = false;
            panel37.Height = 0;
            panel6.Visible = false;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            panel2.Location = new Point(1180, 68);
            panel2.Visible = true;
            panel2.Height = 0;
            timer1.Enabled = true;
            panel3.Visible = false;
            panel3.Height = 0;
            panel4.Visible = false;
            panel4.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;

            panel17.Height = 0;
            panel17.Visible = false;
            panel37.Visible = false;
            panel37.Height = 0;
            panel12.Visible = false;

            label2.ForeColor = Color.Red;
            panel6.Visible = false;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
            panel3.Visible = false;
            panel3.Height = 0;
            panel4.Visible = true;
            panel4.Location = new Point(1070, 65);
            panel4.Height = 0;
            timer1.Enabled = true;
            panel2.Visible = false;
            panel2.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;

            panel17.Height = 0;
            panel17.Visible = false;
            panel37.Visible = false;
            panel37.Height = 0;
            panel12.Visible = false;
            panel6.Visible = false;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            listpurch a = new listpurch();
            a.MdiParent = this;
            panel3.Visible = false;
            a.Show();




        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void p_لیستخرید_Click(object sender, EventArgs e)
        {

        }

        private void p_لیستخرید_MouseHover(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            invoicepurch a = new invoicepurch();
            panel3.Visible = false;
            a.MdiParent = this;
            a.Show();
            panel12.Visible = false;
            panel2.Visible = false;
            panel37.Visible = false;
            panel17.Visible = false;





        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("برای خروج اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
                Application.Exit();
            else
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            timer1.Enabled = true;
            panel3.Location = new Point(1260, 68);
            panel3.Height = 0;
            panel2.Visible = false;
            panel2.Height = 0;
            panel4.Visible = false;
            panel4.Height = 0;
            label1.ForeColor = Color.Red;
            panel13.Visible = false;
            panel13.Height = 0;

            panel17.Height = 0;
            panel17.Visible = false;
            panel37.Visible = false;
            panel37.Height = 0;
            panel12.Visible = false;


        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            //panel3.Height = 0;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            //  panel3.Height = 60;
            //  panel3.Visible = true;
        }

        private void label1_DragLeave(object sender, EventArgs e)
        {
            // panel3.Height = 60;
            // panel3.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(1180, 68);
            panel2.Visible = true;
            panel2.Height = 0;
            timer1.Enabled = true;
            panel3.Visible = false;
            panel3.Height = 0;
            panel4.Visible = false;
            panel4.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;

            panel17.Height = 0;
            panel17.Visible = false;
            panel37.Visible = false;
            panel37.Height = 0;
            panel12.Visible = false;

            label2.ForeColor = Color.Red;
        }

        private void Form2_Load(object sender, EventArgs e)

        {
            // TODO: This line of code loads data into the 'shopDataSet53.prilistsail' table. You can move, or remove it, as needed.
            this.prilistsailTableAdapter9.Fill(this.shopDataSet53.prilistsail);
            Rang_Amizi();
            // TODO: This line of code loads data into the 'shopDataSet38.prilistsail' table. You can move, or remove it, as needed.
            this.prilistsailTableAdapter8.Fill(this.shopDataSet38.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet37.prilistsail' table. You can move, or remove it, as needed.
            this.prilistsailTableAdapter7.Fill(this.shopDataSet37.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet36.prilistsail' table. You can move, or remove it, as needed.
            this.prilistsailTableAdapter6.Fill(this.shopDataSet36.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet36.prilistsail' table. You can move, or remove it, as needed.
            this.prilistsailTableAdapter6.Fill(this.shopDataSet36.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet361.prilistsail' table. You can move, or remove it, as needed.
            this.prilistsailTableAdapter6.Fill(this.shopDataSet361.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet36.prilistsail' table. You can move, or remove it, as needed.
            this.prilistsailTableAdapter6.Fill(this.shopDataSet36.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet36.prilistsail' table. You can move, or remove it, as needed.
            this.prilistsailTableAdapter6.Fill(this.shopDataSet36.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet36.prilistsail' table. You can move, or remove it, as needed.
            this.prilistsailTableAdapter6.Fill(this.shopDataSet36.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet351.prilistsail' table. You can move, or remove it, as needed.
            //  this.prilistsailTableAdapter5.Fill(this.shopDataSet351.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet351.prilistsail' table. You can move, or remove it, as needed.
            //this.prilistsailTableAdapter5.Fill(this.shopDataSet351.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet35.prilistsail' table. You can move, or remove it, as needed.
            this.prilistsailTableAdapter5.Fill(this.shopDataSet35.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet32.saled' table. You can move, or remove it, as needed.
            this.saledTableAdapter.Fill(this.shopDataSet32.saled);
            // TODO: This line of code loads data into the 'shopDataSet31.prilistsail' table. You can move, or remove it, as needed.
           // this.prilistsailTableAdapter4.Fill(this.shopDataSet31.prilistsail);


            // TODO: This line of code loads data into the 'shopDataSet15.prilistsail' table. You can move, or remove it, as needed.
            //is.prilistsailTableAdapter3.Fill(this.shopDataSet15.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet14.prilistsail' table. You can move, or remove it, as needed.
           // this.prilistsailTableAdapter2.Fill(this.shopDataSet14.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet13.prilistsail' table. You can move, or remove it, as needed.
            //this.prilistsailTableAdapter1.Fill(this.shopDataSet13.prilistsail);
            // TODO: This line of code loads data into the 'shopDataSet12.prilistsail' table. You can move, or remove it, as needed.
            // this.prilistsailTableAdapter.Fill(this.shopDataSet12.prilistsail);
            // (Form1.typ == "manager")
            //  label10.Enabled = false;
            // TODO: This line of code loads data into the 'shopDataSet4.staff' table. You can move, or remove it, as needed.
           // this.staffTableAdapter1.Fill(this.shopDataSet55.staff);
            // TODO: This line of code loads data into the 'shopDataSet3.managment' table. You can move, or remove it, as needed.
           // this.managmentTableAdapter.Fill(this.shopDataSet3.managment);
            // TODO: This line of code loads data into the 'shopDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(shopDataSet.product);
            panel3.Height = 0;
            panel2.Height = 0;
            panel4.Height = 0;

            panel13.Height = 0;
            panelshir.Height = 0;
            panel_dogh.Height = 0;
            panel_panir.Height = 0;
            panel_mast.Height = 0;
            panel_gosht.Height = 0;
            if (Form1.typ== "manager")
            {
                panel15.Visible = false;
                panel15.Height =0;
                panel16.Visible = false;
                panel16.Height = 0;
                panel18.Visible = false;
                panel18.Height = 0;
                panel19.Visible = false;
                panel19.Height = 0;
                panel20.Visible = false;
                panel20.Height = 0;
                panel21.Visible = false;
                panel21.Height = 0;
                panel22.Visible = false;
                panel22.Height = 0;
                panel14.Visible = false;
                panel14.Height = 0;
                panel_dogh.Visible = false;
                // panel14.Height = 0;
                panel24.Visible = false;
                panel25.Visible = false;
             
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                button1.Visible = false;
             label95.Visible = false;
                label94.Visible = false;
                label76.Visible = false;
                label74.Visible = false;
             panel34.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;


            }
            else
            {
                panel1.Enabled = false;

            }

            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query = "select sum(total_pay * 1.09) as totalwith from prilistsail ";
            SqlCommand com = new SqlCommand(query, con);



            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                label94.Text = reader["totalwith"].ToString();


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
           listsaled a = new listsaled();
            a.MdiParent = this;
            panel2.Visible = false;
            a.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
            panel3.Visible = false;
            panel3.Height = 0;
            panel4.Visible = true;
            panel4.Location = new Point(1070, 65);
            panel4.Height = 0;
            timer1.Enabled = true;
            panel2.Visible = false;
            panel2.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;

            panel17.Height = 0;
            panel17.Visible = false;
            panel37.Visible = false;
            panel37.Height = 0;
            panel12.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            report a = new report();
            a.MdiParent = this;
            panel17.Visible = false;
            panel17.Height = 0;
            a.Show();
            panel4.Visible = false;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            invoice_saled a = new invoice_saled();
            a.MdiParent = this;
            panel2.Visible = false;
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Height += 20;
            if (panel3.Height == 60)
            {
                timer1.Enabled = false;
            }

            panel2.Height += 20;
            if (panel2.Height == 60)
            {
                timer1.Enabled = false;
            }
            panel4.Height += 20;
            if (panel4.Height == 60)
            {
                timer1.Enabled = false;
            }

            panel17.Height += 20;
            if (panel17.Height == 100)
            {
                timer1.Enabled = false;
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

            timer3.Enabled = true;

            panel13.Visible = false;
            panel13.Height = 0;
            panel2.Visible = false;
            panel2.Height = 0;
            panel3.Visible = false;
            panel3.Height = 0;
            panel4.Visible = false;
            panel4.Height = 0;
            panel17.Visible = false;
            panel17.Height = 0;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            panel13.Height += 20;

            if (panel13.Height == 200)
            {
                timer2.Enabled = false;
            }

            panel37.Height += 20;

            if (panel37.Height ==60)
            {
                timer2.Enabled = false;
            }
            panel_coput.Height += 20;

            if (panel_coput.Height == 200)
            {
                timer2.Enabled = false;
            }

            panel7.Height += 20;

            if (panel7.Height == 200)
            {
                timer2.Enabled = false;
            }

            panel_conserhobobat.Height += 20;

            if (panel_conserhobobat.Height == 200)
            {
                timer2.Enabled = false;
            }
            

          

           panel_sharbat.Height += 20;

            if (panel_sharbat.Height == 200)
            {
                timer2.Enabled = false;
            }

           panel_maoshaeer.Height += 20;

            if (panel_maoshaeer.Height == 200)
            {
                timer2.Enabled = false;
            }

         

        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel10_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel11_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel12_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // panel6.Visible = false;
            //panel6.Height = 0;
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            invoicepurch a = new invoicepurch();
            a.ShowDialog();

            panel3.Visible = false;

        }

        private void label11_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel10_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel11_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel7_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void panel12_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void panel9_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {


        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            listpurch a = new listpurch();
            a.MdiParent = this;
            a.Show();

            panel3.Visible = false;

        }

        private void label15_Click(object sender, EventArgs e)
        {
            listsaled a = new listsaled();
            a.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {

            invoice_saled a = new invoice_saled();
            a.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            report a = new report();
            a.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            panel13.Location = new Point(850, 65);
            panel13.Height = 0;
            panel13.Visible = true;
            timer2.Enabled = true;

            panel2.Visible = false;
            panel2.Height = 0;
            panel3.Visible = false;
            panel3.Height = 0;
            panel4.Visible = false;
            panel4.Height = 0;
            panel12.Visible = false;

            panel37.Visible = false;
            panel37.Height = 0;
            panel17.Visible = false;

        }

        private void label10_MouseHover(object sender, EventArgs e)
        {

            timer2.Enabled = true;

            panel13.Visible = false;
            panel13.Height = 0;
            panel2.Visible = false;
            panel2.Height = 0;
            panel3.Visible = false;
            panel3.Height = 0;
            panel4.Visible = false;
            panel4.Height = 0;
            panel17.Visible = false;
            panel17.Height = 0;
        }

        private void label17_MouseHover(object sender, EventArgs e)
        {
            panel13.Location = new Point(870, 65);
            panel13.Height = 0;
            panel13.Visible = true;
            timer2.Enabled = true;

            panel2.Visible = false;
            panel2.Height = 0;
            panel3.Visible = false;
            panel3.Height = 0;
            panel4.Visible = false;
            panel4.Height = 0;
            panel12.Visible = false;

            panel37.Visible = false;
            panel37.Height = 0;
            panel17.Visible = false;
            panel6.Visible = false;

        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            //label17.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //  panel6.Location = new Point(80, 62);
            // panel6.Width = 300;
            //timer3.Enabled = true;
            //panel6.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel_noshabe.Height += 40;

            if (panel_noshabe.Height == 300)
            {
                timer3.Enabled = false;
            }

            panel_ab.Height += 20;

            if (panel_ab.Height == 200)
            {
                timer3.Enabled = false;
            }

            panelmavadshoyande.Height += 20;

            if (panelmavadshoyande.Height == 250)
            {
                timer3.Enabled = false;
            }
            panelsofre.Height += 20;

            if (panelsofre.Height == 250)
            {
                timer3.Enabled = false;
            }
            paneleskaj.Height += 20;

            if (paneleskaj.Height == 250)
            {
                timer3.Enabled = false;
            }
            paneldastkesh.Height += 20;

            if (paneldastkesh.Height == 250)
            {
                timer3.Enabled = false;
            }
           paneldastmal.Height += 20;

            if (paneldastmal.Height == 250)
            {
                timer3.Enabled = false;
            }

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form2_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {



        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {


        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            // panel6.Visible = false;
            // panel6.Width = 0;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            panel2.Height = 0;
            timer1.Enabled = true;
            panel17.Location = new Point(980, 65);
            panel17.Height = 0;
            panel17.Visible = true;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Height = 0;
            panel4.Visible = false;

            panel13.Visible = false;
            panel13.Height = 0;
            panel37.Visible = false;
            panel37.Height = 0;
            panel12.Visible = false;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            stor a = new stor();
            a.MdiParent = this;
            panel4.Visible = false;
            panel17.Visible = false;
            panel17.Height = 0;
            a.Show();

        }

        private void label20_MouseHover(object sender, EventArgs e)
        {
            panel2.Height = 0;
            timer1.Enabled = true;
            panel17.Location = new Point(970, 65);
            panel17.Height = 0;
            panel17.Visible = true;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Height = 0;
            panel4.Visible = false;

            panel13.Visible = false;
            panel13.Height = 0;
            panel37.Visible = false;
            panel37.Height = 0;
            panel12.Visible = false;
            panel6.Visible = false;
        }













        private void label18_MouseHover(object sender, EventArgs e)
        {

        }

        private void label19_MouseHover(object sender, EventArgs e)
        {

        }

        private void label21_MouseHover(object sender, EventArgs e)
        {

        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel13.Visible = false;
            panel13.Height = 0;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            list_manag a = new list_manag();
            a.MdiParent = this;
            a.Show();
            panel13.Visible = false;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            liststaff a = new liststaff();
            a.MdiParent = this;
            a.Show();
            panel13.Visible = false;

        }

        private void label21_Click(object sender, EventArgs e)
        {
            list_employment a = new list_employment();
            a.MdiParent = this;
            a.Show();
            panel13.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void panel17_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel17_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {
           panel_gosht.Visible = true;
            panel_gosht.Location = new Point(1150, 270);
            panel_gosht.Height = 0;
            timer4.Enabled = true;
           
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }
        void Rang_Amizi()
        {
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.FromArgb(70, 130, 180);
                    break;
                }
            }
        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            panel_cheebs.Visible = false;
            panel_cheebs.Height = 0;
            panel_pofak.Visible = false;
            panel_pofak.Height = 0;
            panel_keyk.Visible = false;
            panel_keyk.Height = 0;
            panel_bastani.Visible = false;
            panel_bastani.Height = 0;
            panel_biiscoeet.Visible = false;
            panel_biiscoeet.Height = 0;


            panel_behdashdandan.Height = 0;
            panel_moraghebatpoost.Visible = false;
            panel_moraghebatpoost.Height = 0;
            panel_dastmalkhaghaz.Visible = false;
            panel_dastmalkhaghaz.Height = 0;
            panel_saboon.Visible = false;
            panel_saboon.Height = 0;
            panelmavadshoyande.Visible = false;
            panelmavadshoyande.Height = 0;
            paneldastmal.Visible = false;
            paneldastmal.Height = 0;
            paneldastkesh.Visible = false;
            paneldastkesh.Height = 0;
            paneleskaj.Visible = false;
            panelsofre.Height = 0;

            panelshir.Visible = true;
           panelshir.Height = 100;
            panelshir.Top = 200;
           panelshir.Left = 1150;
            panelshir.Width = 65;

            panele_kashk.Visible = true;
            panele_kashk.Height = 100;
            panele_kashk.Top = 200;
            panele_kashk.Left = 1050;
            panele_kashk.Width = 65;

            panel_dogh.Visible = true;
            panel_dogh.Height = 100;
            panel_dogh.Top = 200;
            panel_dogh.Left = 950;
            panel_dogh.Width = 65;

            panel_panir.Visible = true;
            panel_panir.Height = 150;
            panel_panir.Top = 200;
            panel_panir.Left = 840;
            panel_panir.Width = 65;

            panel_mast.Visible = true;
            panel_mast.Height = 150;
            panel_mast.Top = 200;
            panel_mast.Left = 740;
            panel_mast.Width = 65;

            panel15.Visible = true;
            panel15.Height =430;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            //  panel9.Visible = false;
            // panel9.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;

            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
           panel_noshabe.Visible = false;
            panel_noshabe.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;

            panel_sharbat.Visible = false;
            panel_sharbat.Height = 0;
        }

        private void label27_Click(object sender, EventArgs e)
        {
               panelshir.Visible = true;
            panelshir.Location = new Point(1150, 200);
            panelshir.Height = 0;
            panelshir.Width = 65;
            timer4.Enabled = true;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panel_dogh.Visible = false;
          panel_dogh.Height = 0;
            panel_panir.Visible = false;
           panel_panir.Height = 0;
            panel_mast.Visible = false;
         panel_mast.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
      
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panele_kashk.Visible = false;
            panele_kashk.Height = 0;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
          //  panel9.Height += 20;

           // if (panel9.Height == 127)
          //  {
               // timer4.Enabled = false;
          //  }
            panelshir.Height += 20;

            if (panelshir.Height == 100)
            {
                timer4.Enabled = false;
            }

            panel_dogh.Height += 20;

            if (panel_dogh.Height == 100)
            {
                timer4.Enabled = false;
            }
            panel_panir.Height += 20;

            if (panel_panir.Height == 140)
            {
                timer4.Enabled = false;
            }



            panel_gosht.Height += 20;

            if (panel_gosht.Height == 100)
            {
                timer4.Enabled = false;
            }
            panel_morgh.Height += 20;

            if (panel_morgh.Height == 200)
            {
                timer4.Enabled = false;
            }
            panel_mahi.Height += 20;

            if (panel_mahi.Height == 100)
            {
                timer4.Enabled = false;
            }
            panel_tokhmmorgh.Height += 20;

            if (panel_tokhmmorgh.Height == 100)
            {
                timer4.Enabled = false;
            }
            panel_socic.Height += 20;

            if (panel_socic.Height == 100)
            {
                timer4.Enabled = false;
            }
            panel_کنسرو.Height += 20;

            if (panel_کنسرو.Height == 100)
            {
                timer4.Enabled = false;
            }

            panel_coput.Height += 20;

            if (panel_coput.Height == 100)
            {
                timer4.Enabled = false;
            }

            panele_kashk.Height += 20;

            if (panele_kashk.Height == 100)
            {
                timer4.Enabled = false;
            }


           
        }
        private void label58_Click(object sender, EventArgs e)
        {
           try
           {

           
            label76.Visible = true;
            label74.Visible = true;
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label58.Text);


            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text)  <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                    }
                    Form2_Load(sender, e);

                }


             else
          {
               MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
  }

      }
          catch
          {
               MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
         }
  


        }

        private void panel23_MouseLeave(object sender, EventArgs e)
        {
            /*  panel23.Visible = false;
              panel16.Visible = true;
              panel16.Height = 65;
              panel18.Visible = true;
              panel18.Height = 65;
              panel19.Visible = true;
              panel19.Height = 65;
              panel20.Visible = true;
              panel20.Height = 65;
              panel21.Visible = true;
              panel21.Height = 65;
              panel22.Visible = true;
             */
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label58_MouseMove(object sender, MouseEventArgs e)
        {
            /* panel23.Visible = false;
             panel16.Visible = true;
             panel16.Height = 65;
             panel18.Visible = true;
             panel18.Height = 65;
             panel19.Visible = true;
             panel19.Height = 65;
             panel20.Visible = true;
             panel20.Height = 65;
             panel21.Visible = true;
             panel21.Height = 65;
             panel22.Visible = true;*/
        }

        private void label59_MouseMove(object sender, MouseEventArgs e)
        {
            /* panel23.Visible = false;
             panel16.Visible = true;
             panel16.Height = 65;
             panel18.Visible = true;
             panel18.Height = 65;
             panel19.Visible = true;
             panel19.Height = 65;
             panel20.Visible = true;
             panel20.Height = 65;
             panel21.Visible = true;
             panel21.Height = 65;
             panel22.Visible = true;*/
        }
        
        private void label26_Click(object sender, EventArgs e)
        {
           panele_kashk.Visible = true;
            panele_kashk.Location = new Point(1050, 200);
            panele_kashk.Height = 0;
            timer4.Enabled = true;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
           
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;

            /*
            try
            {

                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label26.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();

                }
                this.prilistsailTableAdapter3.InsertQuery1(int.Parse(code_product), name_product);
                Form2_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }*/

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
        public int number;
        public int total;
        public string str;
        private void button1_Click(object sender, EventArgs e)
        {
          try
                  {
              
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                
                string query_number = " select  top(1) sum(number_product) as  number_product from prilistsail  group by code_product  order by  code_product desc ";
                SqlConnection con_number = new SqlConnection(sql);
            con_number.Open();
                SqlCommand com_number = new SqlCommand(query_number, con_number);
                SqlDataReader reader_number = com_number.ExecuteReader();
                if (reader_number.Read())
                {
                    number1 = reader_number["number_product"].ToString();


                    if (int.Parse(label74.Text) < int.Parse(number1))
                    {
                        MessageBox.Show("موجودی انبار کافی نمی باشد");
                        return;
                    }
                }
            con_number.Close();
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != null)
                {
                    if (int.Parse(label74.Text) > 0)
                         {
                      //  label74.Text = "";
                    label94.Text = "";
                    panelfactor.Visible = true;
                       
                       panelfactor.Height = 450;
                        panelfactor.Width = 411;
                        panelfactor.Top = 338;
                       panelfactor.Left = 282;
                        Random r = new Random();
                    int blue = r.Next(0, 255);
                    int red = r.Next(0, 255);
                    int green = r.Next(0, 255);
                    this.BackColor = Color.FromArgb(blue, red, green);


                    string n_server = Form1.servername;
                    string n_database = Form1.database;
                    string user = Form1.user;
                    string password = Form1.pass;
                   sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";

                    string query = "insert into saled (code_customer )  values (null)";
                    SqlConnection con = new SqlConnection(sql);
                    SqlCommand comm = new SqlCommand(query, con);
                    con.Open();
                    comm.ExecuteNonQuery();
                    string query1 = "select  top(1) code_saled from saled order by  code_saled desc ";
                    SqlCommand com = new SqlCommand(query1, con);
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.Read())
                    {
                        str = reader["code_saled"].ToString();
                    }
                    con.Close();

                    string query2 = "select sum(number_product) as number ,sum(total_pay) as pay from prilistsail";
                    SqlConnection con2 = new SqlConnection(sql);
                    SqlCommand com2 = new SqlCommand(query2, con2);
                    con2.Open();
                    SqlDataReader reader1 = com2.ExecuteReader();
                    if (reader1.Read())
                    {

                        number = int.Parse(reader1["number"].ToString());
                        total = int.Parse(reader1["pay"].ToString());
                        con2.Close();
                        string query3 = @"update saled set total_perproduct=@total,number_saled=@number where code_saled=@str ";
                        SqlConnection con3 = new SqlConnection(sql);
                        SqlCommand com3 = new SqlCommand(query3, con3);
                        con3.Open();
                        com3.Parameters.AddWithValue("@total", total);
                        com3.Parameters.AddWithValue("@number", number);
                        com3.Parameters.AddWithValue("@str", str);
                        com3.ExecuteNonQuery();
                        con3.Close();


                        SqlConnection con8 = new SqlConnection(sql);
                        string query8 = "select  top(1) * from saled     order by  code_saled desc ";
                        SqlCommand comm8 = new SqlCommand(query8, con);
                        con.Open();
                        SqlDataAdapter dr = new SqlDataAdapter(comm8);
                        DataTable dt = new DataTable();
                        dr.Fill(dt);
                        dataGridView4.DataSource = dt;
                    }

                    }
                    else
                    {
                        MessageBox.Show("کاربر گرامی به موجودی انبار توجه نمایید");
                    }
                    
                }
                else
                {
                    MessageBox.Show("کد کالا را وارد نمایید");
                }
             }
                  catch
                    {
                        panelfactor.Visible = false;
                        MessageBox.Show("اطلاعات را به درستی وارد کنید", "هشدار");
                    }

              
            }

          
            
       
       

        private void btn7_Click(object sender, EventArgs e)
        {
            label10.Text += "7";
        }

        private void label27_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            label10.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            label10.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label10.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            label10.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            label10.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label10.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label10.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            label10.Text += "3";
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_MouseLeave_1(object sender, EventArgs e)
        {

        }

        private void btnc_Click(object sender, EventArgs e)
        {
            label10.Text = " ";
        }

        private void btnchar_Click(object sender, EventArgs e)
        {
            if (label10.Text.Length != 0)
                label10.Text = label10.Text.Remove(label10.Text.Length - 1);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            label10.Text += "0";
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            label10.Text += ".";
        }

        private void btnploss_Click(object sender, EventArgs e)
        {
         //result1 = double.Parse(label10.Text);
            label10.Text = "";
            str = "+";
        }

        private void btntafrigh_Click(object sender, EventArgs e)
        {
           // result1 = double.Parse(label10.Text);
            label10.Text = "";
            str = "-";
        }

        private void btnzarb_Click(object sender, EventArgs e)
        {
          //  result1 = double.Parse(label10.Text);
            label10.Text = "";
            str = "/";
        }

        private void btnmosavi_Click(object sender, EventArgs e)
        {
           /* result2 = double.Parse(label1.Text);
            switch (str)
            {
                case "+":
                    label1.Text = (result1 + result2).ToString();
                    break;
                case "-":
                    label1.Text = (result1 - result2).ToString();
                    break;
                case "/":
                    label1.Text = (result1 / result2).ToString();
                    break;
                case "*":
                    label1.Text = (result1 * result2).ToString();
                    break;
            }*/
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel_cheebs.Visible = false;
            panel_cheebs.Height = 0;
            panel_pofak.Visible = false;
            panel_pofak.Height = 0;
            panel_keyk.Visible = false;
            panel_keyk.Height = 0;
            panel_bastani.Visible = false;
            panel_bastani.Height = 0;
            panel_biiscoeet.Visible = false;
            panel_biiscoeet.Height = 0;



            panel_behdashdandan.Height = 0;
            panel_moraghebatpoost.Visible = false;
            panel_moraghebatpoost.Height = 0;
            panel_dastmalkhaghaz.Visible = false;
            panel_dastmalkhaghaz.Height = 0;
            panel_saboon.Visible = false;
            panel_saboon.Height = 0;
            panelmavadshoyande.Visible = false;
            panelmavadshoyande.Height = 0;
            paneldastmal.Visible = false;
            paneldastmal.Height = 0;
            paneldastkesh.Visible = false;
            paneldastkesh.Height = 0;
            paneleskaj.Visible = false;
            panelsofre.Height = 0;
            panel_sharbat.Visible = false;
            panel_sharbat.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_gosht.Visible = true;
            panel_gosht.Height = 100;
            panel_gosht.Top = 200;
            panel_gosht.Left = 1150;
            panel_gosht.Width = 65;

            panel_morgh.Visible = true;
            panel_morgh.Height = 100;
            panel_morgh.Top = 200;
            panel_morgh.Left = 1050;
            panel_morgh.Width = 65;

            panel_mahi.Visible = true;
            panel_mahi.Height = 100;
            panel_mahi.Top = 200;
            panel_mahi.Left = 950;
            panel_mahi.Width = 65;

            panel_tokhmmorgh.Visible = true;
            panel_tokhmmorgh.Height = 100;
            panel_tokhmmorgh.Top = 200;
            panel_tokhmmorgh.Left = 850;
            panel_tokhmmorgh.Width= 65;

            panel_socic.Visible = true;
            panel_socic.Height = 100;
            panel_socic.Top = 200;
            panel_socic.Left = 750;
            panel_socic.Width = 65;

            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel16.Visible = true;
            panel16.Height = 450;
            panel16.Top = 137;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_mast.Height = 0;
            panel_mast.Visible = false;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            //panel1.Visible = false;
            //panel1.Height = 0;
           // panel11.Visible = false;
           // panel11.Height = 0;
           // panel29.Visible = false;
           // panel29.Height = 0;
           // panel31.Visible = false;
          //  panel31.Height = 0;
            //panel32.Visible = false;
            //panel32.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panele_kashk.Visible = false;
            panele_kashk.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_noshabe.Visible = false;
            panel_noshabe.Height = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_cheebs.Visible = false;
            panel_cheebs.Height = 0;
            panel_pofak.Visible = false;
            panel_pofak.Height = 0;
            panel_keyk.Visible = false;
            panel_keyk.Height = 0;
            panel_bastani.Visible = false;
            panel_bastani.Height = 0;
            panel_biiscoeet.Visible = false;
            panel_biiscoeet.Height = 0;



            panel_behdashdandan.Height = 0;
            panel_moraghebatpoost.Visible = false;
            panel_moraghebatpoost.Height = 0;
            panel_dastmalkhaghaz.Visible = false;
            panel_dastmalkhaghaz.Height = 0;
            panel_saboon.Visible = false;
            panel_saboon.Height = 0;

            panelmavadshoyande.Visible = false;
            panelmavadshoyande.Height = 0;
            paneldastmal.Visible = false;
            paneldastmal.Height = 0;
            paneldastkesh.Visible = false;
            paneldastkesh.Height = 0;
            paneleskaj.Visible = false;
            panelsofre.Height = 0;
            panel_sharbat.Visible = false;
            panel_sharbat.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_conserhobobat.Visible = true;
            panel_conserhobobat.Height = 100;
            //  panel7.Dock = DockStyle.Right;
            panel_conserhobobat.Top = 200;
            panel_conserhobobat.Left = 850;
            panel_conserhobobat.Width = 65;


            panel_coput.Visible = true;
            panel_coput.Height = 100;
          
           panel_coput.Top = 200;
            panel_coput.Left = 1050;
            panel_coput.Width = 65;
            panel_کنسرو.Visible = true;
            panel_کنسرو.Height = 100;
          
            panel_کنسرو.Top = 200;
            panel_کنسرو.Left = 1150;
            panel_کنسرو.Width = 65;
            /*  panel8.Visible = true;
              panel8.Height = 100;
              //  panel7.Dock = DockStyle.Right;
              panel8.Top = 340;
              panel8.Left = 1050;*/


            panel7.Visible = true;
            panel7.Height = 100;
            //  panel7.Dock = DockStyle.Right;
            panel7.Top = 200;
            panel7.Left = 950;
            panel7.Width = 65;
            /*  timer4.Enabled = true;
              panel33.Visible = true;
              panel33.Location = new Point(1150, 340);
              panel33.Height = 0;
              panel35.Visible = true;
              panel35.Location = new Point(1050, 340);
              panel35.Height = 0;*/

            //   panel18.Top = 208;
            panel15.Visible = false;
            panel15.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = true;
            panel18.Height = 450;
          panel18.Top = 137;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
           // panel1.Visible = false;
           // panel1.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            //   panel33.Visible = false;
            // panel33.Height = 0;
            panele_kashk.Visible = false;
            panele_kashk.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_noshabe.Visible = false;
            panel_noshabe.Height = 0;

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel_cheebs.Visible = false;
            panel_cheebs.Height = 0;
            panel_pofak.Visible = false;
            panel_pofak.Height = 0;
            panel_keyk.Visible = false;
            panel_keyk.Height = 0;
            panel_bastani.Visible = false;
            panel_bastani.Height = 0;
            panel_biiscoeet.Visible = false;
            panel_biiscoeet.Height = 0;


            panel_behdashdandan.Height = 0;
            panel_moraghebatpoost.Visible = false;
            panel_moraghebatpoost.Height = 0;
            panel_dastmalkhaghaz.Visible = false;
            panel_dastmalkhaghaz.Height = 0;
            panel_saboon.Visible = false;
            panel_saboon.Height = 0;
            panelmavadshoyande.Visible = false;
            panelmavadshoyande.Height = 0;
            paneldastmal.Visible = false;
            paneldastmal.Height = 0;
            paneldastkesh.Visible = false;
            paneldastkesh.Height = 0;
            paneleskaj.Visible = false;
            panelsofre.Height = 0;
            panel_ab.Top = 200;
            panel_ab.Left = 1150;
            panel_ab.Visible = true;
            panel_ab.Height = 110;
            panel_ab.Width = 65;

            panel_maoshaeer.Top = 200;
            panel_maoshaeer.Left = 1050;
            panel_maoshaeer.Visible = true;
            panel_maoshaeer.Height = 110;
            panel_maoshaeer.Width = 65;

            panel_noshabe.Top = 200;
            panel_noshabe.Left = 820;
            panel_noshabe.Visible = true;
            panel_noshabe.Height = 250;
            panel_noshabe.Width = 65;

            panel_sharbat.Top = 200;
            panel_sharbat.Left = 720;
            panel_sharbat.Visible = true;
            panel_sharbat.Height = 150;
            panel_sharbat.Height = 65;


            panel19.Top = 279;
            
            panel15.Visible = false;
            panel15.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel19.Visible = true;
            panel19.Height = 450;
            panel19.Top = 137;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
           // panel1.Visible = false;
           // panel1.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panele_kashk.Visible = false;
            panele_kashk.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel_cheebs.Visible = false;
            panel_cheebs.Height = 0;
            panel_pofak.Visible = false;
            panel_pofak.Height = 0;
            panel_keyk.Visible = false;
            panel_keyk.Height = 0;
            panel_bastani.Visible = false;
            panel_bastani.Height = 0;
            panel_biiscoeet.Visible = false;
            panel_biiscoeet.Height = 0;


            panelmavadshoyande.Visible = true;

            panelmavadshoyande.Left = 1150;
            panelmavadshoyande.Top=200;
            panelmavadshoyande.Height = 150;
            panelmavadshoyande.Width = 65;

            panelsofre.Visible = true;
            panelsofre.Left = 1050;
            panelsofre.Top = 200;
            panelsofre.Height = 150;
            panelsofre.Width = 65;

            paneleskaj.Visible = true;
            paneleskaj.Left = 940;
            paneleskaj.Top = 200;
            paneleskaj.Height = 150;
            paneleskaj.Height = 65;


            paneldastkesh.Visible = true;
            paneldastkesh.Left = 830;
            paneldastkesh.Top = 200;
            paneldastkesh.Height = 150;
            paneldastkesh.Height = 65;

            paneldastmal.Visible = true;
            paneldastmal.Left = 720;
            paneldastmal.Top =200;
            paneldastmal.Height = 150;
            paneldastmal.Height = 65;

            panel_sharbat.Visible = false;
            panel_sharbat.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;

            panel20.Top = 340;
            panel15.Visible = false;
            panel15.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = true;
            panel20.Height = 450;
            panel20.Top = 137;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            //panel1.Visible = false;
          //  panel1.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panele_kashk.Visible = false;
            panele_kashk.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_noshabe.Visible = false;
            panel_noshabe.Height = 0;

            panel_behdashdandan.Height = 0;
            panel_moraghebatpoost.Visible = false;
            panel_moraghebatpoost.Height = 0;
            panel_dastmalkhaghaz.Visible = false;
            panel_dastmalkhaghaz.Height = 0;
            panel_saboon.Visible = false;
            panel_saboon.Height = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel_cheebs.Visible = false;
            panel_cheebs.Height = 0;
            panel_pofak.Visible = false;
            panel_pofak.Height = 0;
            panel_keyk.Visible = false;
            panel_keyk.Height = 0;
            panel_bastani.Visible = false;
            panel_bastani.Height = 0;
            panel_biiscoeet.Visible = false;
            panel_biiscoeet.Height = 0;


            panel_behdashdandan.Visible = true;
         panel_behdashdandan.Location = new Point(1150, 200);
            panel_behdashdandan.Height = 155;
            panel_behdashdandan.Width= 65;

            panel_moraghebatpoost.Visible = true;
            panel_moraghebatpoost.Location = new Point(1050,200);
            panel_moraghebatpoost.Height = 155;
            panel_moraghebatpoost.Width = 65;

            panel_dastmalkhaghaz.Visible = true;
            panel_dastmalkhaghaz.Location = new Point(940, 200);
            panel_dastmalkhaghaz.Height = 155;
            panel_dastmalkhaghaz.Width = 65;

            panel_saboon.Visible = true;
            panel_saboon.Location = new Point(840, 200);
            panel_saboon.Height = 155;
            panel_saboon.Width = 65;


            panel_sharbat.Visible = false;
            panel_sharbat.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel21.Top = 370;
            panel15.Visible = false;
            panel15.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = true;
            panel21.Height = 450;
            panel21.Top = 137;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
           // panel1.Visible = false;
           // panel1.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panele_kashk.Visible = false;
            panele_kashk.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_noshabe.Visible = false;
            panel_noshabe.Height = 0;
            panelmavadshoyande.Visible = false;
            panelmavadshoyande.Height = 0;
            paneldastmal.Visible = false;
            paneldastmal.Height = 0;
            paneldastkesh.Visible = false;
           paneldastkesh.Height = 0;
            paneleskaj.Visible = false;
            panelsofre.Height = 0;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel_cheebs.Visible = true;
            panel_cheebs.Location = new Point(1155, 200);
            panel_cheebs.Height = 155;

            panel_pofak.Visible = true;
            panel_pofak.Location = new Point(1055,200);
            panel_pofak.Height = 155;
            panel_keyk.Visible = true;
            panel_keyk.Location = new Point(940, 200);
            panel_keyk.Height = 155;
            panel_bastani.Visible = true;
            panel_bastani.Location = new Point(835,200);
            panel_bastani.Height = 155;
            panel_biiscoeet.Visible = true;
            panel_biiscoeet.Location = new Point(735,200);
            panel_biiscoeet.Height = 155;

            panel_sharbat.Visible = false;
            panel_sharbat.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel22.Top = 421;
            panel15.Visible = false;
            panel15.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = true;
            panel22.Height = 450;
            panel22.Top = 137;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
           // panel1.Visible = false;
          //  panel1.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panele_kashk.Visible = false;
            panele_kashk.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_noshabe.Visible = false;
            panel_noshabe.Height = 0;
            panel_behdashdandan.Height = 0;
            panel_moraghebatpoost.Visible = false;
            panel_moraghebatpoost.Height = 0;
            panel_dastmalkhaghaz.Visible = false;
            panel_dastmalkhaghaz.Height = 0;
            panel_saboon.Visible = false;
            panel_saboon.Height = 0;
            panelmavadshoyande.Visible = false;
            panelmavadshoyande.Height = 0;

            panelsofre.Visible = false;
            panelsofre.Height = 0;

            paneleskaj.Visible = false;
            paneleskaj.Height = 0;


            paneldastkesh.Visible = false;
            paneldastkesh.Height = 0;

            paneldastmal.Visible = false;
            paneldastmal.Height = 0;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel_cheebs.Visible = false;
            panel_cheebs.Height = 0;
            panel_pofak.Visible =false;
            panel_pofak.Height = 0;
            panel_keyk.Visible = false;
            panel_keyk.Height =0;
            panel_bastani.Visible = false;
            panel_bastani.Height = 0;
            panel_biiscoeet.Visible = false;
            panel_biiscoeet.Height = 0;

            panelmavadshoyande.Visible = false;
            panelmavadshoyande.Height =0;

            panelsofre.Visible =false;
            panelsofre.Height = 0;

            paneleskaj.Visible = false;
            paneleskaj.Height = 0;


            paneldastkesh.Visible = false;
            paneldastkesh.Height = 0;

            paneldastmal.Visible = false;
            paneldastmal.Height = 0;



            panel_sharbat.Visible = false;
            panel_sharbat.Height = 0;

            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;

            panel15.Top =137;
            panel15.Visible = true;
            panel15.Height = 90;
            panel16.Visible = true;
            panel16.Height = 90;
            panel16.Top = 208;
            panel18.Visible = true;
            panel18.Height = 90;
            panel18.Top =279;
            panel19.Visible = true;
            panel19.Height = 90;
            panel19.Top = 350;
            panel20.Visible = true;
            panel20.Height = 90;
            panel20.Top =421;
            panel21.Visible = true;
            panel21.Height = 90;
            panel21.Top =492;
            panel22.Visible = true;
            panel22.Height = 90;
            panel22.Top = 563;
            panel19.Visible = true;
            panelshir.Visible = false;
            panel_dogh.Visible = false;
            panel_panir.Visible = false;
            panel_mast.Visible = false;
            panel_gosht.Visible = false;
          //  panel1.Visible = false;
          //  panel1.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panele_kashk.Visible = false;
            panele_kashk.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_noshabe.Visible = false;
            panel_noshabe.Height = 0;
            panel_behdashdandan.Visible = false;
            panel_behdashdandan.Height = 0;
            panel_moraghebatpoost.Visible = false;
            panel_moraghebatpoost.Height = 0;
            panel_dastmalkhaghaz.Visible = false;
            panel_dastmalkhaghaz.Height = 0;
            panel_saboon.Visible = false;
            panel_saboon.Height = 0;


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("ایا برای حذف مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {


          this.prilistsailTableAdapter8.DeleteQuery(int.Parse(txt_codpro.Text));
                     txt_codpro.Text = "";
                     comboBox1.Text = "";
                     label10.Text = "";
                    MessageBox.Show("یک رکورد پاک شد");
                }
                    Form2_Load(sender, e);
               
            }
            catch
            {
                MessageBox.Show(" خطایی رخ داده لطفا دوباره  تلاش کنید ");
                txt_codpro.Text = "";
                comboBox1.Text = "";
                label10.Text = "";

            }
        }
       
        private void btn_update_Click(object sender, EventArgs e)
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
                string query1 = "select  top(1) code_product,perproduct from prilistsail order by  code_product desc ";
                SqlCommand com = new SqlCommand(query1, con);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    code = reader["code_product"].ToString();
                    perpay= reader["perproduct"].ToString();
                }
                string query = " update prilistsail set number_product=@n, total_pay=@n*@per where code_product=@code ";
                SqlConnection con1 = new SqlConnection(sql);
                con1.Open();
                SqlCommand com1 = new SqlCommand(query, con1);
                com1.Parameters.AddWithValue("@n", int.Parse(label10.Text));
                com1.Parameters.AddWithValue("@per", int.Parse(perpay));
                com1.Parameters.AddWithValue("@code", int.Parse(code));
                com1.ExecuteNonQuery();




                //this.prilistsailTableAdapter8.UpdateQuery(int.Parse(label10.Text), int.Parse(code));



                Form2_Load(sender, e);
                txt_codpro.Text = "";
                comboBox1.Text = "";
                label10.Text = "";
                label98.Text = "";
               // label74.Text = "";
         // }
          /* catch
            {
                MessageBox.Show(" خطایی رخ داده لطفا دوباره  تلاش کنید ");
                txt_codpro.Text = "";
                comboBox1.Text = "";
                label10.Text = "";

            }*/

        }

        private void label59_Click(object sender, EventArgs e)
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
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label59.Text);

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                    }
                    Form2_Load(sender, e);
                }
           else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
             catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
}

        private void label22_Click(object sender, EventArgs e)
        {
        panel_dogh.Visible = true;
            panel_dogh.Location = new Point(950, 200);
            panel_dogh.Height = 0;
            timer4.Enabled = true;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
           // panel1.Visible = false;
           // panel1.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panele_kashk.Visible = false;
            panele_kashk.Height = 0;
        }

        private void label15_Click_1(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label15.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                    }
                    Form2_Load(sender, e);
                }
              else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }

        private void label14_Click_1(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label14.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                    }
                    Form2_Load(sender, e);
                }
               else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
           panel_panir.Visible = true;
            panel_panir.Location = new Point(840, 200);
            panel_panir.Height = 0;
            timer4.Enabled = true;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
           // panel1.Visible = false;
           // panel1.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panele_kashk.Visible = false;
            panele_kashk.Height = 0;
        }

        private void label60_Click(object sender, EventArgs e)
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

                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label60.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                    Form2_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }
             
                
            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label62_Click(object sender, EventArgs e)
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
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label62.Text);


            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
        else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
             catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label16_Click_1(object sender, EventArgs e)
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
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label16.Text);


            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
         else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }
             catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label61_Click(object sender, EventArgs e)
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
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label61.Text);


            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
        else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
             catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
}

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";

            DialogResult = MessageBox.Show("برای خروج اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {

                SqlConnection condelete1 = new SqlConnection(sql);
                condelete1.Open();
                string querydelet = " delete from  prilistsail ";
                SqlCommand comde = new SqlCommand(querydelet, condelete1);
                comde.ExecuteNonQuery();
                Form2_Load(sender, e);
                Application.Exit();
            }

        }

        private void label25_Click(object sender, EventArgs e)
        {
         panel_mast.Visible = true;
            panel_mast.Location = new Point(730, 200);
            panel_mast.Height = 0;
            timer5.Enabled = false;
            panel16.Visible = false;
            panel16.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
           // panel1.Visible = false;
           // panel1.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panele_kashk.Visible = false;
            panele_kashk.Height = 0;

        }

        private void label65_Click(object sender, EventArgs e)
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
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label65.Text);

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                    }
                    Form2_Load(sender, e);
                }
          else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
             catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
}

        private void label63_Click(object sender, EventArgs e)
        {try
            {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label63.Text);

                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
               else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label64_Click(object sender, EventArgs e)
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
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label64.Text);

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
             else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
             catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
}

        private void label8_Click_1(object sender, EventArgs e)
        {
            try { 

            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label8.Text);

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
      else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
             catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
}

        private void label67_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label67.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }

                 else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label66_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label66.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
                  else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }
           

                 catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        

            }
       

        private void button11_Click(object sender, EventArgs e)
        {
         
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
      
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                // string query = @"select * from  product  where  name_product=@name ";
                string query = "select* from  product where  name_product like '%'+@name+'%' ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", textBox1.Text);
                SqlDataAdapter sd = new SqlDataAdapter(com);
                
                DataTable dt = new DataTable();
                sd.Fill(dt);
                com.ExecuteScalar();
                dataGridView2.DataSource = dt;

              /* SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    label68.Text = reader["name_product"].ToString() ;
                    //txt_codpro.Text = reader["code_product"].ToString();
                }*/
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                // string query = @"select * from  product  where  name_product=@name ";
                string query = "select* from  product where  name_product like '%'+@name+'%' ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", textBox1.Text);
                SqlDataAdapter sd = new SqlDataAdapter(com);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                com.ExecuteScalar();
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = "کد کالا";
                dataGridView2.Columns[1].HeaderText = "نام محصول";
                dataGridView2.Columns[2].HeaderText = "برند محصول";
                dataGridView2.Columns[3].HeaderText = "نوع محصول";
            dataGridView2.Columns[4].HeaderText = "وزن محصول";



        }

        private void textBox1_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
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
                string query = "select* from  product where  name_product like '%'+@name+'%' ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", textBox1.Text);
                SqlDataAdapter sd = new SqlDataAdapter(com);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                com.ExecuteScalar();
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].HeaderText = "کد کالا";
                dataGridView2.Columns[1].HeaderText = "نام محصول";
                dataGridView2.Columns[2].HeaderText = "برند محصول";
                dataGridView2.Columns[3].HeaderText = "نوع محصول";
              

            }
        }
        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        { e.CellStyle.BackColor = Color.Blue; }
        private void label13_Click(object sender, EventArgs e)
        {
            panel12.Visible = true;
            panel13.Visible = false;
            panel37.Visible = false;
            panel37.Height = 0;
            panel12.Left = 660;
            panel12.Top = 65;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            panel17.Visible = false;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label68.Visible = true;
        }

        private void Form2_MouseLeave(object sender, EventArgs e)
        {
            label68.Visible = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            label68.Visible = false;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label68.Visible = false;
        }

        private void label29_Click(object sender, EventArgs e)
        {
          panel_morgh.Visible = true;
            panel_morgh.Location = new Point(1050, 270);
           
            timer4.Enabled = true;

            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

        }

        private void label72_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label72.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
             else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }

        private void label70_Click(object sender, EventArgs e)
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
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label70.Text);


            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }

         else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
}

        private void label71_Click(object sender, EventArgs e)
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
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label71.Text);


            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }

             else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }


        }

        private void label69_Click(object sender, EventArgs e)
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
            string query = @"select * from stor  where  name_product=@name  ";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@name", label69.Text);


            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                code_product = reader["code_stro_product"].ToString();
                name_product = reader["name_product"].ToString();
                label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }

       else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
}

        private void label75_Click(object sender, EventArgs e)
        {
            pruceduredatesaled a = new pruceduredatesaled();
            a.MdiParent = this;
            a.Show();
        }

        private void label73_Click(object sender, EventArgs e)
        {
            customer a = new customer();
            a.MdiParent = this;
            a.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         txt_codpro.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
          
        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {


          // try
          // {

                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query1 = "update saled  set code_customer=@customer ,kindpay=@k where code_saled=@str ";
                SqlCommand com = new SqlCommand(query1, con);
                com.Parameters.AddWithValue("@customer",txt_cus.Text);
                com.Parameters.AddWithValue("@str",str);
            com.Parameters.AddWithValue("@k", comboBox1.Text);
            com.ExecuteNonQuery();

                for ( int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string query = "Insert INTO list_saled (code_lsaled_product,number_product_s,perproduct,total_pay,name_product,code_saled)Values('" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[1].Value + "',N'" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + int.Parse(str) + "')";
                SqlConnection connn = new SqlConnection(sql);
                SqlCommand comm = new SqlCommand(query, connn);
              
                connn.Open();
                        comm.ExecuteNonQuery();
                        connn.Close();

                    }

                SqlConnection condelete = new SqlConnection(sql);
                condelete.Open();
                string querydelet = " delete from  prilistsail ";
                SqlCommand comde = new SqlCommand(querydelet,condelete);
                comde.ExecuteNonQuery();
                Form2_Load(sender, e);


            //}
           /* catch
            {
                MessageBox.Show("خطایی  رخ داده");
            }  */         

           
            

            MessageBox.Show("ثبت موفق فاکتور");
                txt_cus.Text = "";
               
           
          
          //  }
            
           /* catch
            {
                txt_cus.Text = "";
                label83.Text = "";
                MessageBox.Show("خطایی رخ داده");
            }*/
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
                string query = "select * from  customer where  lname_customer like '%'+@name+'%' ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", textBox3.Text);
                SqlDataAdapter sd = new SqlDataAdapter(com);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                //com.ExecuteScalar();
                dataGridView3.DataSource = dt;
                dataGridView3.Columns[0].HeaderText = "نام ";
                   dataGridView3.Columns[1].HeaderText = "نام خانوادگی";
                   dataGridView3.Columns[2].HeaderText = "آدرس";
                   dataGridView3.Columns[3].HeaderText = "تلقن";
                   dataGridView3.Columns[4].HeaderText = "کد مشتری";

                Form2_Load(sender, e);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {/*
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query1 = "insert into saled(code_customer)  values( '" + txt_cus.Text + "')";
            SqlCommand com = new SqlCommand(query1, con);
            com.ExecuteNonQuery();
            string query2 = "select * from  saled where code_customer=@code";
            SqlCommand commm = new SqlCommand(query2, con);
            commm.Parameters.AddWithValue("@code", txt_cus.Text);
            SqlDataReader reader = commm.ExecuteReader();
            if (reader.Read())
            {

                textBox5.Text = reader["code_saled"].ToString();
            }
            con.Close();*/
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {



                button2.ForeColor = Color.FromArgb(139, 155, 179);
                button5.ForeColor = Color.FromArgb(139, 155, 179);
                button1.ForeColor = Color.FromArgb(139, 155, 179);
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = "insert into customer (fname_customer,lname_customer,tell_customer,adress_customer)  values(N'" + txtfname.Text + "',N'" + txtlname.Text + "','" + txttell.Text + "',N'" + txtadress.Text + "')";
                SqlCommand com = new SqlCommand(query, con);

                com.ExecuteNonQuery();
                MessageBox.Show("مشتری جدید ثبت شد");

                txtfname.Text = "";
                txtlname.Text = "";
                txttell.Text = "";
                txtadress.Text = "";
            }

          
      catch
            {
               
                txtfname.Text = "";
                txtlname.Text = "";
                txttell.Text = "";
                txtadress.Text = "";
               
                MessageBox.Show("ثبت انجام نشد اطلاعات را به درستی وارد کنید");


            }
        }

    private void button15_Click(object sender, EventArgs e)
        {
           /* try
            {


                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
                SqlConnection con = new SqlConnection(sql);

                string query = "delete customer   where  code_customer=@code ";

                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", maskedTextBox1);
               
                txtfname.Text = "";
                txtlname.Text = "";
                txttell.Text = "";
                txtadress.Text = "";
                
            }
            catch
            {

                maskedTextBox1.Text = "";
                txtfname.Text = "";
                txtlname.Text = "";
                txttell.Text = "";
                txtadress.Text = "";
                maskedTextBox1.Focus();
                MessageBox.Show("حذف انجام نشد اطلاعات را به درستی وارد کنید");

            }*/
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
                string query = "update  customer   set  fname_customer=@fname,lname_customer=@lnam,tell_customer=@tell,adress_customer=@adress  where   code_customer=@code ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@fname", txtnameedit.Text);
                com.Parameters.AddWithValue("@lnam", txtfamilyedit.Text);
                com.Parameters.AddWithValue("@tell", txttelledit.Text);
                com.Parameters.AddWithValue("@adress", txtadresedit.Text);
                com.Parameters.AddWithValue("@code", textBox2.Text);
                com.ExecuteNonQuery();
              

 
               

                MessageBox.Show("تغییر اطلاعات با موفقیت انجام شد");



               txtadresedit.Text = "";
              txtfamilyedit.Text = "";
                txttelledit.Text = "";
               txtnameedit.Text = "";
            }

   
            catch
            {

                txtadresedit.Text = "";
                txtfamilyedit.Text = "";
                txttelledit.Text = "";
                txtnameedit.Text = "";

                MessageBox.Show("تغییر انجام نشد اطلاعات را به درستی وارد کنید");


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codpro.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panelfactor.Visible = false;
        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          txt_cus.Text=textBox2.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {
          //  label83.Text = dataGridView4.CurrentRow.Cells[6].Value.ToString();

            Form2_Load(sender, e);
        }

        private void label82_Click(object sender, EventArgs e)
        {
           /* string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query1 = "insert into saled(code_customer)  values( '" + txt_cus.Text + "')";
            SqlCommand com = new SqlCommand(query1, con);
            com.ExecuteNonQuery();

           /* string query2 = "select * from  saled where code_customer=@code";
            SqlCommand commm = new SqlCommand(query2, con);
            commm.Parameters.AddWithValue("@code", txt_cus.Text);
            SqlDataReader reader = commm.ExecuteReader();
            if (reader.Read())
            {

                label83.Text = reader["code_saled"].ToString();
            }*/
          //  Form2_Load(sender, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {
            panel_mahi.Visible = true;
            panel_mahi.Location = new Point(950, 270);

            timer4.Enabled = true;

            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

        }

        private void label31_Click(object sender, EventArgs e)
        {
           panel_tokhmmorgh.Visible = true;
            panel_tokhmmorgh.Location = new Point(850, 270);

            timer4.Enabled = true;

            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
           
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;


        }

        private void label30_Click(object sender, EventArgs e)
        {
         panel_socic.Visible = true;
            panel_socic.Location = new Point(750, 270);

            timer4.Enabled = true;

            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_gosht.Visible = false;
            panel_gosht.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;

            panel_mahi.Visible = false;
            panel_mahi.Height = 0;

            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

        }

        private void label91_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label91.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                 else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label90_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label90.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
              else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label93_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label93.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
              else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label92_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label92.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label97_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label97.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }

                }

                  else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label96_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label96.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter3.InsertQuery1(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                 else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
            panelfactor.Visible = false;
            
        }

        private void label33_Click(object sender, EventArgs e)
        {
            panel_کنسرو.Visible = true;
            panel_کنسرو.Location = new Point(1150, 340);
            panel_کنسرو.Height = 0;
            timer4.Enabled = true;

          
            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
          panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            panel_mast.Height += 20;

            if (panel_mast.Height==127)
            {
                timer5.Enabled = false;
            }
        }

        private void label99_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label99.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter3.InsertQuery1(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }
            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label98_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label98.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();

                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter3.InsertQuery1(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

           

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label94_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label78.Visible = true;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label78.Visible = true;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            panel_coput.Visible = true;
            panel_coput.Location = new Point(1050, 340);
            panel_coput.Height = 0;
            timer2.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
           panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;

        }

        private void label100_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label100.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        
    }

        private void label101_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label101.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                 else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        
    }

        private void label102_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label102.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        
    }

        private void label103_Click(object sender, EventArgs e)
        {
            try
            {


                label76.Visible = true;
                label74.Visible = true;
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label103.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                    }
                    Form2_Load(sender, e);
                }
             else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }


        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label106_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label106.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
              else
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }

        }

        private void panel36_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_3(object sender, EventArgs e)
        {
            this.prilistsailTableAdapter8.UpdateQuery1(int.Parse(label10.Text), int.Parse(txt_codpro.Text));
            Form2_Load(sender, e);

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void txt_cus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void label104_Click_1(object sender, EventArgs e)
        {
            panel37.Location = new Point(800, 65);
            panel37.Height = 0;
            panel37.Visible = true;
            timer2.Enabled = true;

            panel2.Visible = false;
            panel2.Height = 0;
            panel3.Visible = false;
            panel3.Height = 0;
            panel4.Visible = false;
            panel4.Height = 0;
            panel12.Visible = false;
            panel13.Visible = false;
            panel13.Height = 0;
            panel17.Visible = false;
        }

        private void label104_MouseHover(object sender, EventArgs e)
        {
            panel37.Location = new Point(750, 65);
            panel37.Height = 0;
            panel37.Visible = true;
            timer2.Enabled = true;

            panel2.Visible = false;
            panel2.Height = 0;
            panel3.Visible = false;
            panel3.Height = 0;
            panel4.Visible = false;
            panel4.Height = 0;
            panel12.Visible = false;
            panel13.Visible = false;
            panel13.Height = 0;
            panel17.Visible = false;
            panel6.Visible = false;

        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            panel12.Visible = true;
            panel13.Visible = false;
            panel37.Visible = false;
            panel37.Height = 0;
            panel12.Left =610;
            panel12.Top = 65;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            panel17.Visible = false;
            panel6.Visible = false;

        }

        private void label105_Click(object sender, EventArgs e)
        {
            supplier a = new supplier();
            a.MdiParent = this;
            a.Show();
        }

        private void txtadresedit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelledit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfamilyedit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void txtnameedit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel7.Location = new Point(950, 340);
            panel7.Height = 0;
            timer2.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
           panel_coput.Visible = false;
            panel_coput.Height = 0;
           panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;

            // panel17.Location = new Point(227, 44);
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void label108_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label108.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label107_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label107.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label110_Click_1(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label110.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label109_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label109.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label38_Click(object sender, EventArgs e)
        {
            panel19.Top = 279;
            panel_ab.Visible = true;
            panel_ab.Location = new Point(1150, 330);
            panel_ab.Height = 0;
            timer3.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;

            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
        }

        private void label112_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label112.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label111_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label111.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label114_Click(object sender, EventArgs e)
        {
            try
            {


                label76.Visible = true;
                label74.Visible = true;
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label114.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                    }
                    Form2_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }


            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label113_Click(object sender, EventArgs e)
        {
            try
            {


                label76.Visible = true;
                label74.Visible = true;
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label113.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                    }
                    Form2_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }


            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label118_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label118.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label117_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label117.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label116_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label116.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label122_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label122.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label121_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label121.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label120_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label120.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label123_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label123.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label119_Click(object sender, EventArgs e)
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
                string query = @"select * from stor  where  name_product=@name  ";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@name", label119.Text);


                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    code_product = reader["code_stro_product"].ToString();
                    name_product = reader["name_product"].ToString();
                    label74.Text = reader["number_p_stor"].ToString();
                    if (int.Parse(label74.Text) <= 0)
                    {
                        MessageBox.Show(" موجودی انبار کافی نمی باشد ");
                    }
                    else
                    {
                        this.prilistsailTableAdapter8.InsertQuery(int.Parse(code_product), name_product);
                        Form2_Load(sender, e);
                    }
                }


                else
                {
                    MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
                }

            }
            catch
            {
                MessageBox.Show("کالای مورد نظر در انبار ثبت نشده");
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {
           panel_conserhobobat.Visible = true;
            panel_conserhobobat.Location = new Point(850, 340);
            panel_conserhobobat.Height = 0;
            timer2.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel19.Visible = false;
            panel19.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
        }

        private void label39_Click(object sender, EventArgs e)
        {
            panel19.Top = 279;
            panel_maoshaeer.Visible = true;
            panel_maoshaeer.Location = new Point(1050, 330);
            panel_maoshaeer.Height = 0;
            timer2.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;

            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {
            panel19.Top = 279;
            panel_noshabe.Visible = true;
            panel_noshabe.Location = new Point(820, 330);
            panel_noshabe.Height = 0;
            timer3.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;
            panel18.Visible = false;
            panel18.Height = 0;

            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
        }

        private void label40_Click(object sender, EventArgs e)
        {
            panel19.Top = 279;
            panel_sharbat.Visible = true;

            panel_sharbat.Location = new Point(720, 330);
            panel_sharbat.Height = 0;
            timer2.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel18.Visible = false;
            panel18.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_sharbat.Visible = true;
            panel_noshabe.Height = 0;
            panel_noshabe.Visible = false;
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            label10.Text += "8";
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            label10.Text += "9";
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            label10.Text += "4";
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            label10.Text += "5";
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            label10.Text += "6";
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            label10.Text += "1";
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            label10.Text += "2";
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            label10.Text += "3";
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            label10.Text += "0";
        }

        private void btnchar_Click_1(object sender, EventArgs e)
        {
            if (label10.Text.Length != 0)
                label10.Text = label10.Text.Remove(label10.Text.Length - 1);
        }

        private void btnc_Click_1(object sender, EventArgs e)
        {
            label10.Text = " ";
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label83_Click_1(object sender, EventArgs e)
        {
            try
            {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";

                SqlConnection con = new SqlConnection(sql);
                string query = "SELECT TOP(1)* FROM[shop].[dbo].[factor] order by  code_saled desc";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter db = new SqlDataAdapter(com);
                DataSet dt = new DataSet();
                db.Fill(dt, "[shop].[dbo].[factor]");
                CrystalReport1 crp = new CrystalReport1();
                crp.SetDataSource(dt);
                System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
                string tarikh = p.GetYear(DateTime.Now) + "\\";
                tarikh+=p.GetMonth(DateTime.Now) + "\\";
                tarikh += p.GetDayOfMonth(DateTime.Now) + "\\";
                crp.SetParameterValue(0, tarikh);
                Formprint frm = new Formprint();
                frm.crystalReportViewer1.ReportSource = crp;
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("خطایی رخ داده");
            }


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {
           
          panelmavadshoyande.Visible = true;

            panelmavadshoyande.Location = new Point(1150, 480);
            panelmavadshoyande.Height = 0;
            timer3.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_sharbat.Visible = true;
            panel_noshabe.Height = 0;
            panel_noshabe.Visible = false;
           panel_sharbat.Height = 0;
            panel_sharbat.Visible = false;
           paneleskaj.Height = 0;
            paneleskaj.Visible = false;
            panelsofre.Height = 0;
            panelsofre.Visible = false;
        }

        private void label44_Click(object sender, EventArgs e)
        {
           panelsofre.Visible = true;

            panelsofre.Location = new Point(1050, 480);
            panelsofre.Height = 0;
            timer3.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_sharbat.Visible = true;
            panel_noshabe.Height = 0;
            panel_noshabe.Visible = false;
            panel_sharbat.Height = 0;
            panel_sharbat.Visible = false;
           panelmavadshoyande.Height = 0;
            panelmavadshoyande.Visible = false;
            paneleskaj.Height = 0;
            paneleskaj.Visible = false;
        }

        private void label47_Click(object sender, EventArgs e)
        {
            paneleskaj.Visible = true;

            paneleskaj.Location = new Point(940, 480);
            paneleskaj.Height = 0;
            timer3.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_sharbat.Visible = true;
            panel_noshabe.Height = 0;
            panel_noshabe.Visible = false;
            panel_sharbat.Height = 0;
            panel_sharbat.Visible = false;
            panelmavadshoyande.Height = 0;
            panelmavadshoyande.Visible = false;
           panelsofre.Height = 0;
            panelsofre.Visible = false;
        }

        private void label46_Click(object sender, EventArgs e)
        {
           paneldastkesh.Visible = true;

            paneldastkesh.Location = new Point(830, 480);
            paneldastkesh.Height = 0;
            timer3.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_sharbat.Visible = true;
            panel_noshabe.Height = 0;
            panel_noshabe.Visible = false;
            panel_sharbat.Height = 0;
            panel_sharbat.Visible = false;
            panelmavadshoyande.Height = 0;
            panelmavadshoyande.Visible = false;
            panelsofre.Height = 0;
            panelsofre.Visible = false;
           paneleskaj.Height = 0;
            paneleskaj.Visible = false;

        }

        private void label45_Click(object sender, EventArgs e)
        {
           paneldastmal.Visible = true;

            paneldastmal.Location = new Point(720, 480);
            paneldastmal.Height = 0;
            timer3.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel18.Visible = false;
            panel18.Height = 0;
            panel19.Visible = false;
            panel19.Height = 0;
            panel21.Visible = false;
            panel21.Height = 0;
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_sharbat.Visible = true;
            panel_noshabe.Height = 0;
            panel_noshabe.Visible = false;
            panel_sharbat.Height = 0;
            panel_sharbat.Visible = false;
            panelmavadshoyande.Height = 0;
            panelmavadshoyande.Visible = false;
            panelsofre.Height = 0;
            panelsofre.Visible = false;
            paneleskaj.Height = 0;
            paneleskaj.Visible = false;
            paneldastkesh.Height = 0;
            paneldastkesh.Visible = false;
        }

        private void label48_Click(object sender, EventArgs e)
        {
            panel19.Visible = false;
          //  panel_behdashdandan.Visible = true;
          //  panel_behdashdandan.Location = new Point(1250, 480);
          //  panel_behdashdandan.Height = 0;
           // timer6.Enabled = true;
            panel_کنسرو.Visible = false;
            panel_کنسرو.Height = 0;

            panel18.Visible = false;
            panel18.Height = 0;
            panel20.Visible = false;
            panel20.Height = 0;
          
            panel22.Visible = false;
            panel22.Height = 0;
            panelshir.Visible = false;
            panelshir.Height = 0;
            panel_dogh.Visible = false;
            panel_dogh.Height = 0;
            panel_panir.Visible = false;
            panel_panir.Height = 0;
            panel_mast.Visible = false;
            panel_mast.Height = 0;
            panel15.Visible = false;
            panel15.Height = 0;
            panel_morgh.Visible = false;
            panel_morgh.Height = 0;
            panel_mahi.Visible = false;
            panel_mahi.Height = 0;
            panel_tokhmmorgh.Visible = false;
            panel_tokhmmorgh.Height = 0;
            panel_socic.Visible = false;
            panel_socic.Height = 0;
            panel16.Visible = false;
            panel16.Height = 0;
            panel13.Visible = false;
            panel13.Height = 0;
            panel_coput.Visible = false;
            panel_coput.Height = 0;
            panel7.Visible = false;
            panel7.Height = 0;
            panel_conserhobobat.Visible = false;
            panel_conserhobobat.Height = 0;
            panel_ab.Visible = false;
            panel_ab.Height = 0;
            panel_maoshaeer.Visible = false;
            panel_maoshaeer.Height = 0;
            panel_sharbat.Visible = true;
            panel_noshabe.Height = 0;
            panel_noshabe.Visible = false;
           panel_sharbat.Height = 0;
           panel_sharbat.Visible = false;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            panel_behdashdandan.Height += 20;

            if (panel_behdashdandan.Height == 127)
            {
                timer6.Enabled = false;
            }

          

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label180_Click(object sender, EventArgs e)
           
        {
            panel6.Visible = true;
           
        }

        private void label181_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = colorDialog1.Color;

                    break;
                }
            }
        }

        private void label182_Click(object sender, EventArgs e)
        {
        
            openFileDialog1.Title = "اضافه کردن عکس"; 
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            { MessageBox.Show("cancel"); }
            else
            {

                openFileDialog1.ShowDialog();
                foreach (Control control in this.Controls)
                {
                    MdiClient client = control as MdiClient;
                    if (!(client == null))
                    {
                        client.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                        break;
                    }


                }
            }
        }

        private void label180_MouseHover(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel12.Visible = false;
            panel13.Visible = false;
            panel37.Visible = false;
            panel37.Height = 0;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            panel17.Visible = false;
        }



        /*  private void btn7_Click(object sender, EventArgs e)
          {

          }*/
    }
}








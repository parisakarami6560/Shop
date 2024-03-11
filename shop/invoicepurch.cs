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
    public partial class invoicepurch : Form
    {
        public invoicepurch()
        {
            InitializeComponent();
        }
        string sql;
        private void button3_Click(object sender, EventArgs e)
        {

            // try
            //  {

            if (txt_code.Text != string.Empty)
            {
                string query1 = "select *  from purchase_list  where code_invoic = @CODE";
                SqlConnection connn1 = new SqlConnection(sql);
                SqlCommand comm1 = new SqlCommand(query1, connn1);
                comm1.Parameters.AddWithValue("@CODE", txt_code.Text);
                SqlDataAdapter db = new SqlDataAdapter(comm1);
                DataTable dt = new DataTable();
                db.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("این فاکتور قبلا ثبت شده است");
                }
                else
                {
                    if (int.Parse(textBox1.Text) == int.Parse(textBox4.Text))
                    {


                        for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                        {
                            string query4 = "Insert INTO purchase_list(code_invoice_product,number_product,pay_product,tatal_pay,code_invoic,pay_saled,stor) Values('" + dataGridView3.Rows[i].Cells[0].Value + "', '" + dataGridView3.Rows[i].Cells[1].Value + "',N'" + dataGridView3.Rows[i].Cells[2].Value + "','" + dataGridView3.Rows[i].Cells[3].Value + "','" + dataGridView3.Rows[i].Cells[5].Value + "','" + dataGridView3.Rows[i].Cells[4].Value + "','" + 0 + "')";
                            SqlConnection connn = new SqlConnection(sql);
                            SqlCommand comm = new SqlCommand(query4, connn);

                            connn.Open();
                            comm.ExecuteNonQuery();
                            connn.Close();

                        }

                        SqlConnection condelete = new SqlConnection(sql);
                        condelete.Open();
                        string querydelet = " delete from pripurchase_invoice ";
                        SqlCommand comde = new SqlCommand(querydelet, condelete);
                        comde.ExecuteNonQuery();

                        MessageBox.Show("ذخیره اطلاعات با موفقیت انجام شد");

                        txtcodeproduct.Text = "";

                        txtpaysaled.Text = "";
                        textBox3.Text = "";
                        txtnumber.Text = "";
                        txtpay.Text = "";
                        txttime.Text = "";
                        txt_code.Text = "";
                        txt_supplier.Text = "";
                        txt_date.Text = "";
                        txt_namemarketer.Text = "";
                        txt_tellmarketer.Text = "";
                        txt_namesupplier.Text = "";
                        txtdiscust.Text = "";
                        textBox2.Text = "";

                        txt_code.Focus();
                        grideshow();



                    }
                    else
                    {
                        MessageBox.Show("جمع کل پیش فاکتور با فاکتور برابر نمی باشد");
                    }
                    // }

                    /* catch
                       {
                           txtcodeproduct.Text = "";
                           txtpaysaled.Text = "";
                           textBox3.Text = "";
                           txtnumber.Text = "";
                           txtpay.Text = "";
                           txttime.Text = "";
                           txt_code.Text = "";
                           txt_supplier.Text = "";
                           txt_date.Text = "";
                           txt_namemarketer.Text = "";
                           txt_tellmarketer.Text = "";
                           txt_namesupplier.Text = "";
                           txtdiscust.Text = "";
                           textBox2.Text = "";
                           txt_code.Focus();
                           MessageBox.Show("  ذخیره اطلاعات  انجام نشد ");



                       }*/
                }
            }
            else
            {
                MessageBox.Show("اطلاعات را به درستی وارد کنید");
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void invoicepurch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet52.pripurchase_invoice' table. You can move, or remove it, as needed.
            this.pripurchase_invoiceTableAdapter2.Fill(this.shopDataSet52.pripurchase_invoice);
            // TODO: This line of code loads data into the 'shopDataSet51.pripurchase_invoice' table. You can move, or remove it, as needed.
            this.pripurchase_invoiceTableAdapter1.Fill(this.shopDataSet51.pripurchase_invoice);
            // TODO: This line of code loads data into the 'shopDataSet50.pripurchase_invoice' table. You can move, or remove it, as needed.
            //this.pripurchase_invoiceTableAdapter.Fill(this.shopDataSet50.pripurchase_invoice);
            // TODO: This line of code loads data into the 'shopDataSet46.purchase_list' table. You can move, or remove it, as needed.
            this.purchase_listTableAdapter.Fill(this.shopDataSet46.purchase_list);
            // TODO: This line of code loads data into the 'shopDataSet40.purchase_list' table. You can move, or remove it, as needed.
            // this.purchase_listTableAdapter.Fill(this.shopDataSet40.purchase_list);
            // TODO: This line of code loads data into the 'shopDataSet39.purchase_Invoice' table. You can move, or remove it, as needed.
            //this.purchase_InvoiceTableAdapter.Fill(this.shopDataSet39.purchase_Invoice);
            string sql = "";
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con2 = new SqlConnection(sql);
            con2.Open();
            string query = "select * from  purchase_Invoice  where code_INVOICE=@code";
            SqlCommand com = new SqlCommand(query, con2);
            com.Parameters.AddWithValue("@code", txt_code.Text);

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                txt_date.Text = reader["date_invoice"].ToString();
                txttime.Text = reader["time_invoice"].ToString();
                textBox3.Text = reader["number"].ToString();
            }
            con2.Close();

         

            // TODO: This line of code loads data into the 'shopDataSet30.chooseproduct' table. You can move, or remove it, as needed.
            this.chooseproductTableAdapter5.Fill(this.shopDataSet30.chooseproduct);
            // TODO: This line of code loads data into the 'shopDataSet29.chooseproduct' table. You can move, or remove it, as needed.
            this.chooseproductTableAdapter4.Fill(this.shopDataSet29.chooseproduct);
            // TODO: This line of code loads data into the 'shopDataSet28.chooseproduct' table. You can move, or remove it, as needed.
            this.chooseproductTableAdapter3.Fill(this.shopDataSet28.chooseproduct);
            // TODO: This line of code loads data into the 'shopDataSet27.chooseproduct' table. You can move, or remove it, as needed.
            this.chooseproductTableAdapter2.Fill(this.shopDataSet27.chooseproduct);
            // TODO: This line of code loads data into the 'shopDataSet26.chooseproduct' table. You can move, or remove it, as needed.
            // this.chooseproductTableAdapter1.Fill(this.shopDataSet26.chooseproduct);
            // TODO: This line of code loads data into the 'shopDataSet25.chooseproduct' table. You can move, or remove it, as needed.
            // this.chooseproductTableAdapter.Fill(this.shopDataSet25.chooseproduct);
            // TODO: This line of code loads data into the 'shopDataSet24.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.shopDataSet24.product);
            // TODO: This line of code loads data into the 'shopDataSet19.purchase_list' table. You can move, or remove it, as needed.
            //this.purchase_listTableAdapter4.Fill(this.shopDataSet19.purchase_list);
            // TODO: This line of code loads data into the 'shopDataSet18.purchase_list' table. You can move, or remove it, as needed.
            this.purchase_listTableAdapter3.Fill(this.shopDataSet18.purchase_list);
            // TODO: This line of code loads data into the 'shopDataSet17.purchase_list' table. You can move, or remove it, as needed.
            // this.purchase_listTableAdapter2.Fill(this.shopDataSet17.purchase_list);
            // TODO: This line of code loads data into the 'shopDataSet16.purchase_list' table. You can move, or remove it, as needed.
            //this.purchase_listTableAdapter1.Fill(this.shopDataSet16.purchase_list);
            // TODO: This line of code loads data into the 'shopDataSet9.purchase_list' table. You can move, or remove it, as needed.
            //  this.purchase_listTableAdapter.Fill(this.shopDataSet9.purchase_list);
           



            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con4 = new SqlConnection(sql);
            con4.Open();
            string query4 = "select * from supplier  where code_SUPPLIER=@code";
            SqlCommand co4m = new SqlCommand(query4, con4);
            co4m.Parameters.AddWithValue("@code", txt_supplier.Text);

            SqlDataReader reader4 = co4m.ExecuteReader();
            if (reader4.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                txt_namesupplier.Text = reader4["name_supplier"].ToString();
                txt_nmarketer.Text = reader4["name_marketer"].ToString();
                txt_tellmarketer.Text = reader4["tell_marketere"].ToString();
            }

            con4.Close();

            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con5 = new SqlConnection(sql);
            con5.Open();
            string query5 = "select sum(number_product) as totalnumber from  purchase_list  where code_invoic=@code   group by  code_invoic  ";
            SqlCommand com5 = new SqlCommand(query5, con5);
            com5.Parameters.AddWithValue("@code", txt_code.Text);

            SqlDataReader reader5 = com5.ExecuteReader();
            if (reader5.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                textBox2.Text = reader5["totalnumber"].ToString();

            }
            con5.Close();
            SqlConnection con9 = new SqlConnection(sql);
            con9.Open();
            string query9 = "select sum(tatal_pay) as total from  purchase_list  where code_invoic=@code1";
            SqlCommand com9 = new SqlCommand(query9, con9);
            com9.Parameters.AddWithValue("@code1", txt_code.Text);

            SqlDataReader reader9 = com9.ExecuteReader();
            if (reader9.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                lblsum.Text = reader9["total"].ToString();
            }
           
            con9.Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("برای حذف اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    string n_server = Form1.servername;
                    string n_database = Form1.database;
                    string user = Form1.user;
                    string password = Form1.pass;
                    sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                    //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";
                    SqlConnection con1 = new SqlConnection(sql);
                    con1.Open();
                    string query1 = "delete  from  pripurchase_invoice   where code_invoice_product=@code";
                    SqlCommand com1 = new SqlCommand(query1, con1);
                    com1.Parameters.AddWithValue("@code", txtcodeproduct.Text);
                    com1.ExecuteNonQuery();
                    con1.Close();

                    MessageBox.Show("  حذف محصول با موفقیت انجام شد ");
                    txtcodeproduct.Text = "";


                    txtnumber.Text = "";
                    txtpay.Text = "";
                    txttime.Text = "";
                    txt_code.Text = "";
                    txt_supplier.Text = "";
                    txt_date.Text = "";
                    txt_code.Focus();

                }
            }
            catch
            {
                txtcodeproduct.Text = "";


                txtnumber.Text = "";
                txtpay.Text = "";
                txttime.Text = "";
                txt_code.Text = "";
                txt_supplier.Text = "";
                txt_date.Text = "";
                txt_code.Focus();
                MessageBox.Show("  تغییر اطلاعات  انجام نشد  خطایی رخ داده است");
            }
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("برای حذف اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                try
                {


                    string n_server = Form1.servername;
                    string n_database = Form1.database;
                    string user = Form1.user;
                    string password = Form1.pass;
                    sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                    //sql = "Data Source=DESKTOP-BN2NLRO ;Initial Catalog=shop;User Id=shop ;password=123";

                    SqlConnection con2 = new SqlConnection(sql);
                    con2.Open();
                    string query2 = "delete  from pripurchase_invoice where code_invoice=@code";
                    SqlCommand comm = new SqlCommand(query2, con2);
                    comm.Parameters.AddWithValue("@code", txt_code.Text);
                    comm.ExecuteNonQuery();

                    SqlConnection con1 = new SqlConnection(sql);
                    con1.Open();
                    string query1 = "delete  from  purchase_list   where code_invoic=@code";
                    SqlCommand com1 = new SqlCommand(query1, con1);
                    com1.Parameters.AddWithValue("@code", txt_code.Text);
                    com1.ExecuteNonQuery();
                    con1.Close();
                    SqlConnection con = new SqlConnection(sql);
                    con.Open();
                    string query = "delete  from purchase_Invoice where code_INVOICE=@code";
                    SqlCommand comm4 = new SqlCommand(query, con);
                    comm4.Parameters.AddWithValue("@code", txt_code.Text);
                    comm4.ExecuteNonQuery();



                    txtcodeproduct.Text = "";

                    textBox3.Text = "";
                    textBox4.Text = "";
                    txtnumber.Text = "";
                    txtpay.Text = "";
                    txttime.Text = "";
                    txt_code.Text = "";
                    txt_supplier.Text = "";
                    txt_date.Text = "";
                    txt_namemarketer.Text = "";
                    txt_tellmarketer.Text = "";
                    txt_namesupplier.Text = "";
                    txtdiscust.Text = "";
                    textBox2.Text = "";
                    txt_code.Focus();
                    MessageBox.Show("  حذف اطلاعات  با موفقیت انجام شد ");

                }

                catch
                {
                    txtcodeproduct.Text = "";

                    txtnumber.Text = "";
                    txtpay.Text = "";
                    txttime.Text = "";
                    txt_code.Text = "";
                    txt_supplier.Text = "";
                    txt_date.Text = "";
                    txt_namemarketer.Text = "";
                    txt_tellmarketer.Text = "";
                    txt_namesupplier.Text = "";
                    txtdiscust.Text = "";
                    textBox2.Text = "";
                    txt_code.Focus();
                    MessageBox.Show("  حذف اطلاعات  انجام نشد ");
                }
            }
            else
            {
                return;
            }



        }

        private void p_فاکتورخرید_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*   textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.chooseproductTableAdapter5.InsertQuery(int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
             
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                dataGridView3.Refresh();
            }
            catch
            {
                MessageBox.Show("ثبت کالا انجام نشد");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          //  this.productTableAdapter.FillBy(shopDataSet24.product, textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {

        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_supplier_KeyDown(object sender, KeyEventArgs e)
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
                string query = "select * from supplier  where code_SUPPLIER=@code";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", txt_supplier.Text);

                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    txt_namesupplier.Text = reader["name_supplier"].ToString();
                    txt_nmarketer.Text = reader["name_marketer"].ToString();
                    txt_tellmarketer.Text = reader["tell_marketere"].ToString();
                }
                else
                {
                    MessageBox.Show(" کد مورد نطر یافت نشد، لطفا اطلاعات تامین کننده   را در فرم مربوطه ذخیره نمایید   ");
                }
            }
        }

        private void txt_supplier_TextChanged(object sender, EventArgs e)
        {
            if (txt_supplier.Text != string.Empty)
            {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = "select * from supplier  where code_SUPPLIER=@code";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", txt_supplier.Text);

                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    txt_namesupplier.Text = reader["name_supplier"].ToString();
                    txt_nmarketer.Text = reader["name_marketer"].ToString();
                    txt_tellmarketer.Text = reader["tell_marketere"].ToString();
                }
                else
                {
                    MessageBox.Show(" کد مورد نطر یافت نشد، لطفا اطلاعات تامین کننده   را در فرم مربوطه ذخیره نمایید   ");
                }
            }
            else
            {
                txt_namesupplier.Text = "";
                txt_nmarketer.Text = "";
                txt_tellmarketer.Text = "";
            }
        }

        private void txtcodeproduct_TextChanged(object sender, EventArgs e)
        {
            /*
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string query = "select * from product  where code_product=@code";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@code", txtcodeproduct.Text);
            SqlDataAdapter sdr = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView3.DataSource = dt;
            dataGridView3.Columns[0].HeaderText = "کد محصول ";
            dataGridView3.Columns[1].HeaderText = "نام محصول ";
            dataGridView3.Columns[2].HeaderText = "برند محصول ";
            dataGridView3.Columns[3].HeaderText = "دسته بندی محصول ";
            dataGridView3.Columns[4].HeaderText = "وزن محصول ";


        }
        public string pay = "";
        private void txtcodeproduct_KeyDown(object sender, KeyEventArgs e)
        {/*
            if (e.KeyCode == Keys.Enter)
            {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = "select * from product  where code_product=@code";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", txtcodeproduct.Text);
                SqlDataAdapter sdr = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView3.DataSource = dt;

                SqlConnection con1 = new SqlConnection(sql);
                con1.Open();
                string query1 = "select * from stor  where code_stro_product=@code";
                SqlCommand com1 = new SqlCommand(query1, con1);
                com1.Parameters.AddWithValue("@code", txtcodeproduct.Text);
                SqlDataReader reader = com1.ExecuteReader();
                if(reader.Read())
                {
                    pay = reader["pay_pur"].ToString();
                }
                txtpay.Text = pay;

            }*/
        }

        private void txt_code_KeyDown(object sender, KeyEventArgs e)
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
                string query = "select * from  purchase_Invoice  where code_INVOICE=@code";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", txt_code.Text);

                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    txt_date.Text = reader["date_invoice"].ToString();
                    txttime.Text = reader["time_invoice"].ToString();
                    textBox3.Text = reader["number"].ToString();
                    txtdiscust.Text = reader["discount"].ToString();
                    SqlConnection con5 = new SqlConnection(sql);
                    con5.Open();
                    string query5 = "select sum(number_product) as totalnumber from  purchase_list  where code_invoic=@code   group by  code_invoic  ";
                    SqlCommand com5 = new SqlCommand(query5, con5);
                    com5.Parameters.AddWithValue("@code", txt_code.Text);

                    SqlDataReader reader5 = com5.ExecuteReader();
                    if (reader5.Read())
                    {
                        //txt_codpro.Text = reader["code_product"].ToString();
                        textBox2.Text = reader5["totalnumber"].ToString();

                    }
                    else
                    {
                        textBox2.Text = "0";
                    }

                    con5.Close();
                    SqlConnection con6 = new SqlConnection(sql);
                    con6.Open();
                    string query6 = "select * from  purchase_list  where code_invoic=@code    ";
                    SqlCommand com6 = new SqlCommand(query6, con6);
                    com6.Parameters.AddWithValue("@code", txt_code.Text);
                    SqlDataAdapter sdr = new SqlDataAdapter(com6);
                    DataTable dt = new DataTable();
                    sdr.Fill(dt);
                   dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "کد محصول ";
                    dataGridView1.Columns[1].HeaderText = "تعداد محصول";
                    dataGridView1.Columns[2].HeaderText = "قیمت خرید";
                    dataGridView1.Columns[3].HeaderText = "مبلغ کل";
                    dataGridView1.Columns[4].HeaderText = "کد فاکتور";
                    dataGridView1.Columns[5].HeaderText = "مبلغ فروش";
                    dataGridView1.Columns[6].HeaderText = "انبار";

                   

                    invoicepurch_Load(sender, e);
                    con6.Close();
                    SqlConnection con9 = new SqlConnection(sql);
                    con9.Open();
                    string query9 = "select sum(tatal_pay) as total from  purchase_list  where code_invoic=@code1";
                    SqlCommand com9 = new SqlCommand(query9, con9);
                    com9.Parameters.AddWithValue("@code1", txt_code.Text);

                    SqlDataReader reader9 = com9.ExecuteReader();
                    if (reader9.Read())
                    {
                        //txt_codpro.Text = reader["code_product"].ToString();
                        lblsum.Text = reader9["total"].ToString();
                    }
                    invoicepurch_Load(sender, e);
                    con9.Close();
             

                }
            }
        }
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con5 = new SqlConnection(sql);
            con5.Open();
            string query5 = "select sum(number_product) as totalnumber from  purchase_list  where code_invoic=@code   group by  code_invoic  ";
            SqlCommand com5 = new SqlCommand(query5, con5);
            com5.Parameters.AddWithValue("@code", txt_code.Text);

            SqlDataReader reader5 = com5.ExecuteReader();
            if (reader5.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                textBox2.Text =reader5["totalnumber"].ToString();

            }
            con5.Close();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con5 = new SqlConnection(sql);
            con5.Open();
            string query5 = "select sum(number_product) as totalnumber from  purchase_list  where code_invoic=@code   group by  code_invoic  ";
            SqlCommand com5 = new SqlCommand(query5, con5);
            com5.Parameters.AddWithValue("@code", txt_code.Text);

            SqlDataReader reader5 = com5.ExecuteReader();
            if (reader5.Read())
            {
                //txt_codpro.Text = reader["code_product"].ToString();
                textBox2.Text = reader5["totalnumber"].ToString();

            }
            else
            {
              textBox2.Text = "0";
            }
            con5.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
          //  txtcodeproduct.Text= dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtcodeproduct.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void txt_date_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txttime.Focus();
            }
        }

        private void txttime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcodeproduct.Focus();
            }
        }

        private void txtpay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtpaysaled.Focus();
            }
        }

        private void txtpaysaled_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtnumber.Focus();
            }
        }

        private void txtnumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdiscust.Focus();
            }
        }

        private void txtdiscust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void txt_supplier_Enter(object sender, EventArgs e)
        {
            supplier s = new supplier();
            s.ShowDialog();
            txt_supplier.Text = s.code;
            s.Hide();
        }
        public void selectpurchlist()
        {
            SqlConnection con7= new SqlConnection(sql);
            con7.Open();
            string query7 = "select  p.code_invoic,p.number_product,p.pay_product,p.pay_saled,p.stor,p.tatal_pay,name_product from purchase_list p  inner join product on p.code_invoice_product=product.code_product  where code_invoic=@code  ";
            SqlCommand com7= new SqlCommand(query7, con7);
            com7.Parameters.AddWithValue("@code", txt_code.Text);
            SqlDataAdapter sdr = new SqlDataAdapter(com7);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "کد فاکتور ";
            dataGridView1.Columns[1].HeaderText = "تعداد محصول";
            dataGridView1.Columns[2].HeaderText = "قیمت خرید";
            dataGridView1.Columns[3].HeaderText = "مبلغ فروش";
            dataGridView1.Columns[4].HeaderText = "ثبت در انبار";
            dataGridView1.Columns[5].HeaderText = "جمع کل";
            dataGridView1.Columns[6].HeaderText = "نام محصول";

            con7.Close();
        }
        private void txt_code_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_code.Text != string.Empty)
            {
                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query = "select * from  purchase_Invoice  where code_INVOICE=@code";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@code", txt_code.Text);

                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    //txt_codpro.Text = reader["code_product"].ToString();
                    txt_date.Text = reader["date_invoice"].ToString();
                    txttime.Text = reader["time_invoice"].ToString();
                    textBox3.Text = reader["number"].ToString();
                    txtdiscust.Text = reader["discount"].ToString();
                    textBox4.Text = reader["total_pay"].ToString();
                    button4.Enabled = false;
                    SqlConnection con5 = new SqlConnection(sql);
                    con5.Open();
                    string query5 = "select sum(number_product) as totalnumber ,sum(tatal_pay) as total   from  pripurchase_invoice  where code_invoice=@code   group by  code_invoice  ";
                    SqlCommand com5 = new SqlCommand(query5, con5);
                    com5.Parameters.AddWithValue("@code", txt_code.Text);

                    
                    SqlDataReader reader5 = com5.ExecuteReader();
                    if (reader5.Read())
                    {
                        //txt_codpro.Text = reader["code_product"].ToString();
                        textBox2.Text = reader5["totalnumber"].ToString();
                        textBox1.Text= reader5["total"].ToString();
                    }
                    else
                    {
                        textBox2.Text = "0";
                        textBox1.Text = "0";
                        lblsum.Text = "0";

                    }

                    con5.Close();
                    selectpurchlist();

               /*  SqlConnection con6 = new SqlConnection(sql);
                    con6.Open();
                    string query6 = "select * from  purchase_list  where code_invoic=@code    ";
                    SqlCommand com6 = new SqlCommand(query6, con6);
                    com6.Parameters.AddWithValue("@code", txt_code.Text);
                    SqlDataAdapter sdr = new SqlDataAdapter(com6);
                    DataTable dt = new DataTable();
                    sdr.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "کد محصول ";
                    dataGridView1.Columns[1].HeaderText = "تعداد محصول";
                    dataGridView1.Columns[2].HeaderText = "قیمت خرید";
                    dataGridView1.Columns[3].HeaderText = "مبلغ کل";
                    dataGridView1.Columns[4].HeaderText = "کد فاکتور";
                    dataGridView1.Columns[5].HeaderText = "مبلغ فروش";
                    dataGridView1.Columns[6].HeaderText = "انبار";

                    con6.Close();*/

                    SqlConnection con10 = new SqlConnection(sql);
                    con10.Open();
                    string query10 = "select * from pripurchase_invoice  where code_invoice=@code    ";
                    SqlCommand com10= new SqlCommand(query10, con10);
                    com10.Parameters.AddWithValue("@code", txt_code.Text);
                    SqlDataAdapter sdr1 = new SqlDataAdapter(com10);
                    DataTable dt1 = new DataTable();
                    sdr1.Fill(dt1);
                    dataGridView3.DataSource = dt1;
                    dataGridView3.Columns[0].HeaderText = "کد محصول";
                    dataGridView3.Columns[1].HeaderText = "تعداد محصول";
                    dataGridView3.Columns[2].HeaderText = "قیمت خرید";
                    dataGridView3.Columns[3].HeaderText = "قیمت کل";
                    dataGridView3.Columns[4].HeaderText = "قیمت فروش";
                    dataGridView3.Columns[5].HeaderText = "کد فاکتور";
                    con10.Close();



                   // invoicepurch_Load(sender, e);
                    
                    SqlConnection con9 = new SqlConnection(sql);
                    con9.Open();
                    string query9 = "select sum(tatal_pay) as total from  purchase_list  where code_invoic=@code1";
                    SqlCommand com9 = new SqlCommand(query9, con9);
                    com9.Parameters.AddWithValue("@code1", txt_code.Text);

                    SqlDataReader reader9 = com9.ExecuteReader();
                    if (reader9.Read())
                    {
                        //txt_codpro.Text = reader["code_product"].ToString();
                        lblsum.Text = reader9["total"].ToString();
                    }
                    invoicepurch_Load(sender, e);
                    con9.Close();


                }
                else
                {
                    txt_date.Text = "";

                    txttime.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    txtdiscust.Text = "";
                    textBox1.Text = "";
                    textBox4.Text = "";
                    button4.Enabled = true;
                    lblsum.Text = "0";
                    //  selectpurchlist();
                    SqlConnection con7 = new SqlConnection(sql);
                    con7.Open();
                    string query7 = "select  p.code_invoic,p.number_product,p.pay_product,p.pay_saled,p.stor,p.tatal_pay,name_product from purchase_list p  inner join product on p.code_invoice_product=product.code_product  where code_invoic=@code  ";
                    SqlCommand com7 = new SqlCommand(query7, con7);
                    com7.Parameters.AddWithValue("@code", txt_code.Text);
                    SqlDataAdapter sdr = new SqlDataAdapter(com7);
                    DataTable dt = new DataTable();
                    sdr.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "کد فاکتور ";
                    dataGridView1.Columns[1].HeaderText = "تعداد محصول";
                    dataGridView1.Columns[2].HeaderText = "قیمت خرید";
                    dataGridView1.Columns[3].HeaderText = "مبلغ فروش";
                    dataGridView1.Columns[4].HeaderText = "ثبت در انبار";
                    dataGridView1.Columns[5].HeaderText = "جمع کل";
                    dataGridView1.Columns[6].HeaderText = "نام محصول";

                    con7.Close();



                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcodeproduct_Enter(object sender, EventArgs e)
        {
           report    s = new report();
            s.ShowDialog();
          txtcodeproduct.Text = s.code;
            s.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            string query2 = " select * from   pripurchase_invoice";
            SqlCommand com2 = new SqlCommand(query2, con);
            SqlDataAdapter ad = new SqlDataAdapter(com2);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView3.DataSource = dt;
            dataGridView3.Columns[0].HeaderText = "کد محصول";
            dataGridView3.Columns[1].HeaderText = "تعداد محصول";
            dataGridView3.Columns[2].HeaderText = "قیمت خرید";
            dataGridView3.Columns[3].HeaderText = "جمع کل";
            dataGridView3.Columns[4].HeaderText = "قیمت فروش";
            dataGridView3.Columns[5].HeaderText = "کد فاکتور";

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox3.Text) - int.Parse(textBox2.Text) < int.Parse(txtnumber.Text))
                {
                    MessageBox.Show("تعداد اقلام بیشتر از اقلام ثبت شده ی فاکتور می باشد");
                    return;
                }

                string n_server = Form1.servername;
                string n_database = Form1.database;
                string user = Form1.user;
                string password = Form1.pass;
                string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";


                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string query2 = "insert into pripurchase_invoice (code_invoice_product,number_product,pay_product,pay_saled,code_invoice)  values('" + txtcodeproduct.Text + "','" + txtnumber.Text + "','" + txtpay.Text + "','" + txtpaysaled.Text + "','" + txt_code.Text + "')";
                SqlCommand com2 = new SqlCommand(query2, con);
                /* SqlDataAdapter ad = new SqlDataAdapter(com2);
                   DataTable dt = new DataTable();
                   ad.Fill(dt);
                   dataGridView3.DataSource = dt;
                   dataGridView3.Columns[0].HeaderText = "کد محصول";
                   dataGridView3.Columns[1].HeaderText = "تعداد محصول";
                   dataGridView3.Columns[2].HeaderText = "قیمت خرید";
                   dataGridView3.Columns[3].HeaderText = "قیمت کل";
                   dataGridView3.Columns[4].HeaderText = "قیمت فروش";
                   dataGridView3.Columns[5].HeaderText = "کد فاکتور";*/

                com2.ExecuteNonQuery();
                graid();
                invoicepurch_Load(sender, e);
                txtcodeproduct.Text = "";
                txtnumber.Text = "";
                txtpay.Text = "";
                txtpaysaled.Text = "";
                con.Close();

                SqlConnection con1 = new SqlConnection(sql);
                con1.Open();
                string query1 = "select sum( tatal_pay) as totalpay , sum(number_product) as totalnumber  from  pripurchase_invoice where code_invoice=@code    ";
                SqlCommand com1 = new SqlCommand(query1, con1);
                com1.Parameters.AddWithValue("code", txt_code.Text);
                SqlDataReader reader5 = com1.ExecuteReader();
                if (reader5.Read())
                {

                    textBox1.Text = reader5["totalpay"].ToString();
                    textBox2.Text = reader5["totalnumber"].ToString();

                }
            }
            catch
            {
                MessageBox.Show("اطلاعات خواسته شده را به درستی وارد کنید");

            }
           
        



        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con3 = new SqlConnection(sql);
            con3.Open();
            string query3 = "insert into purchase_Invoice(code_INVOICE,date_invoice,time_invoice,total_pay,discount,number,code_SUPPLIER)  values( '" + txt_code.Text + "','" + txt_date.Text + "','" + txttime.Text + "','" + textBox4.Text + "','" + txtdiscust.Text + "','" + textBox3.Text + "','" + txt_supplier.Text + "')";
            SqlCommand com3 = new SqlCommand(query3, con3);
            com3.ExecuteNonQuery();
            MessageBox.Show("اطلاعات کلی فاکتور ثبت شد");
            con3.Close();
        }
        public void grideshow()
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con3 = new SqlConnection(sql);
            con3.Open();
            string query = " select * from purchase_list";
            SqlCommand comm = new SqlCommand(query, con3);
            SqlDataAdapter ad = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "کد محصول ";
            dataGridView1.Columns[1].HeaderText = "تعداد محصول";
            dataGridView1.Columns[2].HeaderText = "قیمت خرید";
            dataGridView1.Columns[3].HeaderText = "مبلغ کل";
            dataGridView1.Columns[4].HeaderText = "کد فاکتور";
            dataGridView1.Columns[5].HeaderText = "مبلغ فروش";
            dataGridView1.Columns[6].HeaderText = "انبار";



        }
        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con3 = new SqlConnection(sql);
            con3.Open();
            string query = " update  pripurchase_invoice   set  number_product=@number,pay_product=@pay,pay_saled=@paysaled  where code_invoice_product=@code ";
            SqlConnection connn = new SqlConnection(sql);
            connn.Open();
            SqlCommand comm = new SqlCommand(query, connn);
            comm.Parameters.AddWithValue("@code", dataGridView3.CurrentRow.Cells[0].Value);
            comm.Parameters.AddWithValue("@number", dataGridView3.CurrentRow.Cells[1].Value.ToString());
            comm.Parameters.AddWithValue("@pay", dataGridView3.CurrentRow.Cells[2].Value.ToString());
            comm.Parameters.AddWithValue("@paysaled", dataGridView3.CurrentRow.Cells[4].Value.ToString());
           // comm.Parameters.AddWithValue("@code_invoice", dataGridView3.CurrentRow.Cells[5].Value.ToString());
            comm.ExecuteNonQuery();
          
            graid();
            MessageBox.Show("ویرایش اطلاعات با موفقیت انجام شد");
            SqlConnection con1 = new SqlConnection(sql);
            con1.Open();
            string query1 = "select sum( tatal_pay) as totalpay , sum(number_product) as totalnumber  from  pripurchase_invoice where code_invoice=@code    ";
            SqlCommand com1 = new SqlCommand(query1, con1);
            com1.Parameters.AddWithValue("code", txt_code.Text);
            SqlDataReader reader5 = com1.ExecuteReader();
            if (reader5.Read())
            {

                textBox1.Text = reader5["totalpay"].ToString();
                textBox2.Text = reader5["totalnumber"].ToString();

            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string n_server = Form1.servername;
            string n_database = Form1.database;
            string user = Form1.user;
            string password = Form1.pass;
            string sql = "Data Source=" + Form1.servername + " ;Initial Catalog=" + Form1.database + ";User Id=" + Form1.user + " ;password=" + Form1.pass + "";
            SqlConnection con3 = new SqlConnection(sql);
            con3.Open();
            string query = "delete from   pripurchase_invoice where code_invoice_product=@code";
            SqlCommand comm = new SqlCommand(query, con3);

            comm.Parameters.AddWithValue("@code", dataGridView3.CurrentRow.Cells[0].Value.ToString());
            comm.ExecuteNonQuery();

           graid();
            MessageBox.Show("حذف اطلاعات با موفقیت انجام شد");
            SqlConnection con1 = new SqlConnection(sql);
            con1.Open();
            string query1 = "select sum( tatal_pay) as totalpay , sum(number_product) as totalnumber  from  pripurchase_invoice where code_invoice=@code    ";
            SqlCommand com1 = new SqlCommand(query1, con1);
            com1.Parameters.AddWithValue("code", txt_code.Text);
            SqlDataReader reader5 = com1.ExecuteReader();
            if (reader5.Read())
            {

                textBox1.Text = reader5["totalpay"].ToString();
                textBox2.Text = reader5["totalnumber"].ToString();

            }

        }
    }
    }

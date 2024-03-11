namespace shop
{
    partial class report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wEIGHTPRODUCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet43 = new shop.shopDataSet43();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet1 = new shop.shopDataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new shop.shopDataSet();
            this.productTableAdapter = new shop.shopDataSetTableAdapters.productTableAdapter();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcategori = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.productTableAdapter1 = new shop.shopDataSet1TableAdapters.productTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.search = new System.Windows.Forms.TabPage();
            this.radioname = new System.Windows.Forms.RadioButton();
            this.radio_code = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_code = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcategoori = new System.Windows.Forms.TextBox();
            this.lblnamesupp = new System.Windows.Forms.Label();
            this.txtw = new System.Windows.Forms.TextBox();
            this.namemarketer = new System.Windows.Forms.Label();
            this.txtbranddit = new System.Windows.Forms.TextBox();
            this.txtnameedit = new System.Windows.Forms.TextBox();
            this.tellsupp = new System.Windows.Forms.Label();
            this.txtcodesupp = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.productTableAdapter2 = new shop.shopDataSet43TableAdapters.productTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.search.SuspendLayout();
            this.delete.SuspendLayout();
            this.update.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeproductDataGridViewTextBoxColumn,
            this.nameproductDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.kindDataGridViewTextBoxColumn,
            this.wEIGHTPRODUCTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(69, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(546, 95);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // codeproductDataGridViewTextBoxColumn
            // 
            this.codeproductDataGridViewTextBoxColumn.DataPropertyName = "code_product";
            this.codeproductDataGridViewTextBoxColumn.HeaderText = "کد محصول";
            this.codeproductDataGridViewTextBoxColumn.Name = "codeproductDataGridViewTextBoxColumn";
            // 
            // nameproductDataGridViewTextBoxColumn
            // 
            this.nameproductDataGridViewTextBoxColumn.DataPropertyName = "name_product";
            this.nameproductDataGridViewTextBoxColumn.HeaderText = "نام محصول";
            this.nameproductDataGridViewTextBoxColumn.Name = "nameproductDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "برند";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // kindDataGridViewTextBoxColumn
            // 
            this.kindDataGridViewTextBoxColumn.DataPropertyName = "kind";
            this.kindDataGridViewTextBoxColumn.HeaderText = "دسته بندی";
            this.kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            // 
            // wEIGHTPRODUCTDataGridViewTextBoxColumn
            // 
            this.wEIGHTPRODUCTDataGridViewTextBoxColumn.DataPropertyName = "WEIGHT_PRODUCT";
            this.wEIGHTPRODUCTDataGridViewTextBoxColumn.HeaderText = "وزن محصول";
            this.wEIGHTPRODUCTDataGridViewTextBoxColumn.Name = "wEIGHTPRODUCTDataGridViewTextBoxColumn";
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "product";
            this.productBindingSource2.DataSource = this.shopDataSet43;
            // 
            // shopDataSet43
            // 
            this.shopDataSet43.DataSetName = "shopDataSet43";
            this.shopDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.shopDataSet1;
            // 
            // shopDataSet1
            // 
            this.shopDataSet1.DataSetName = "shopDataSet1";
            this.shopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(12, 334);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 31);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 14;
            this.pictureBox13.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(11, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "خانه";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(523, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "نام کالا";
            this.label1.UseWaitCursor = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(400, 99);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 16;
            this.txt_name.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(6, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "نمایش";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(441, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "فرم تعریف کالای جدید";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 55);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(568, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(523, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "کد کالا";
            this.label3.UseWaitCursor = true;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(400, 62);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(100, 20);
            this.txtcode.TabIndex = 21;
            this.txtcode.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(523, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "برند";
            this.label4.UseWaitCursor = true;
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(400, 127);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(100, 20);
            this.txtbrand.TabIndex = 23;
            this.txtbrand.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(523, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "دسته بندی محصول";
            this.label5.UseWaitCursor = true;
            // 
            // txtcategori
            // 
            this.txtcategori.Location = new System.Drawing.Point(400, 161);
            this.txtcategori.Name = "txtcategori";
            this.txtcategori.Size = new System.Drawing.Size(100, 20);
            this.txtcategori.TabIndex = 25;
            this.txtcategori.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(210, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "ثبت";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(523, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "وزن  محصول";
            this.label7.UseWaitCursor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 30;
            this.textBox2.UseWaitCursor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.search);
            this.tabControl1.Controls.Add(this.delete);
            this.tabControl1.Controls.Add(this.update);
            this.tabControl1.Location = new System.Drawing.Point(162, 350);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 142);
            this.tabControl1.TabIndex = 45;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Gainsboro;
            this.search.Controls.Add(this.radioname);
            this.search.Controls.Add(this.radio_code);
            this.search.Controls.Add(this.label8);
            this.search.Controls.Add(this.TXT_code);
            this.search.Controls.Add(this.button1);
            this.search.Location = new System.Drawing.Point(4, 22);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(3);
            this.search.Size = new System.Drawing.Size(437, 116);
            this.search.TabIndex = 0;
            this.search.Text = "جستجو";
            // 
            // radioname
            // 
            this.radioname.AutoSize = true;
            this.radioname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioname.Location = new System.Drawing.Point(302, 29);
            this.radioname.Name = "radioname";
            this.radioname.Size = new System.Drawing.Size(105, 17);
            this.radioname.TabIndex = 29;
            this.radioname.TabStop = true;
            this.radioname.Text = "جستجو با نام کالا";
            this.radioname.UseVisualStyleBackColor = true;
            // 
            // radio_code
            // 
            this.radio_code.AutoSize = true;
            this.radio_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radio_code.Location = new System.Drawing.Point(161, 29);
            this.radio_code.Name = "radio_code";
            this.radio_code.Size = new System.Drawing.Size(104, 17);
            this.radio_code.TabIndex = 28;
            this.radio_code.TabStop = true;
            this.radio_code.Text = "جستحو با کد کالا";
            this.radio_code.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(207, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "برای جستجو اطلاعات درخواستی را وارد کنید";
            this.label8.UseWaitCursor = true;
            // 
            // TXT_code
            // 
            this.TXT_code.Location = new System.Drawing.Point(98, 65);
            this.TXT_code.Name = "TXT_code";
            this.TXT_code.Size = new System.Drawing.Size(100, 20);
            this.TXT_code.TabIndex = 25;
            this.TXT_code.UseWaitCursor = true;
            this.TXT_code.TextChanged += new System.EventHandler(this.TXT_code_TextChanged);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Gainsboro;
            this.delete.Controls.Add(this.button5);
            this.delete.Controls.Add(this.label9);
            this.delete.Controls.Add(this.textBox3);
            this.delete.Location = new System.Drawing.Point(4, 22);
            this.delete.Name = "delete";
            this.delete.Padding = new System.Windows.Forms.Padding(3);
            this.delete.Size = new System.Drawing.Size(437, 116);
            this.delete.TabIndex = 1;
            this.delete.Text = "حذف";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(28, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "حذف";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(248, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "برای حذف کد مشتری را وارد کنید";
            this.label9.UseWaitCursor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 28;
            this.textBox3.UseWaitCursor = true;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Silver;
            this.update.Controls.Add(this.label10);
            this.update.Controls.Add(this.txtcategoori);
            this.update.Controls.Add(this.lblnamesupp);
            this.update.Controls.Add(this.txtw);
            this.update.Controls.Add(this.namemarketer);
            this.update.Controls.Add(this.txtbranddit);
            this.update.Controls.Add(this.txtnameedit);
            this.update.Controls.Add(this.tellsupp);
            this.update.Controls.Add(this.txtcodesupp);
            this.update.Controls.Add(this.label79);
            this.update.Controls.Add(this.button12);
            this.update.Location = new System.Drawing.Point(4, 22);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(437, 116);
            this.update.TabIndex = 2;
            this.update.Text = "تغییرات";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(231, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 115;
            this.label10.Text = "دسته بندی محصول";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcategoori
            // 
            this.txtcategoori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtcategoori.Location = new System.Drawing.Point(149, 52);
            this.txtcategoori.Name = "txtcategoori";
            this.txtcategoori.Size = new System.Drawing.Size(63, 20);
            this.txtcategoori.TabIndex = 114;
            // 
            // lblnamesupp
            // 
            this.lblnamesupp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblnamesupp.Location = new System.Drawing.Point(353, 52);
            this.lblnamesupp.Name = "lblnamesupp";
            this.lblnamesupp.Size = new System.Drawing.Size(78, 19);
            this.lblnamesupp.TabIndex = 112;
            this.lblnamesupp.Text = "نام کالا";
            this.lblnamesupp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtw
            // 
            this.txtw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtw.Location = new System.Drawing.Point(10, 28);
            this.txtw.Name = "txtw";
            this.txtw.Size = new System.Drawing.Size(65, 20);
            this.txtw.TabIndex = 111;
            // 
            // namemarketer
            // 
            this.namemarketer.AutoSize = true;
            this.namemarketer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.namemarketer.Location = new System.Drawing.Point(81, 30);
            this.namemarketer.Name = "namemarketer";
            this.namemarketer.Size = new System.Drawing.Size(62, 13);
            this.namemarketer.TabIndex = 109;
            this.namemarketer.Text = "وزن محصول";
            // 
            // txtbranddit
            // 
            this.txtbranddit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtbranddit.Location = new System.Drawing.Point(149, 26);
            this.txtbranddit.Name = "txtbranddit";
            this.txtbranddit.Size = new System.Drawing.Size(65, 20);
            this.txtbranddit.TabIndex = 108;
            // 
            // txtnameedit
            // 
            this.txtnameedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtnameedit.Location = new System.Drawing.Point(299, 56);
            this.txtnameedit.Name = "txtnameedit";
            this.txtnameedit.Size = new System.Drawing.Size(48, 20);
            this.txtnameedit.TabIndex = 107;
            // 
            // tellsupp
            // 
            this.tellsupp.AutoSize = true;
            this.tellsupp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tellsupp.Location = new System.Drawing.Point(231, 31);
            this.tellsupp.Name = "tellsupp";
            this.tellsupp.Size = new System.Drawing.Size(62, 13);
            this.tellsupp.TabIndex = 106;
            this.tellsupp.Text = "برند محصول";
            // 
            // txtcodesupp
            // 
            this.txtcodesupp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtcodesupp.Location = new System.Drawing.Point(299, 30);
            this.txtcodesupp.Name = "txtcodesupp";
            this.txtcodesupp.Size = new System.Drawing.Size(48, 20);
            this.txtcodesupp.TabIndex = 105;
            // 
            // label79
            // 
            this.label79.BackColor = System.Drawing.Color.Snow;
            this.label79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label79.Location = new System.Drawing.Point(353, 28);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(81, 23);
            this.label79.TabIndex = 104;
            this.label79.Text = "کد کالا";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button12.Location = new System.Drawing.Point(3, 86);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 27);
            this.button12.TabIndex = 103;
            this.button12.Text = "تغییرات";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "report";
            this.Load += new System.EventHandler(this.گزارشات_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.delete.ResumeLayout(false);
            this.delete.PerformLayout();
            this.update.ResumeLayout(false);
            this.update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private shopDataSetTableAdapters.productTableAdapter productTableAdapter;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button2;
        private shopDataSet1 shopDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private shopDataSet1TableAdapters.productTableAdapter productTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcategori;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage search;
        private System.Windows.Forms.RadioButton radioname;
        private System.Windows.Forms.RadioButton radio_code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_code;
        private System.Windows.Forms.TabPage delete;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage update;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcategoori;
        private System.Windows.Forms.Label lblnamesupp;
        private System.Windows.Forms.TextBox txtw;
        private System.Windows.Forms.Label namemarketer;
        private System.Windows.Forms.TextBox txtbranddit;
        private System.Windows.Forms.TextBox txtnameedit;
        private System.Windows.Forms.Label tellsupp;
        private System.Windows.Forms.TextBox txtcodesupp;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Button button12;
        private shopDataSet43 shopDataSet43;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private shopDataSet43TableAdapters.productTableAdapter productTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wEIGHTPRODUCTDataGridViewTextBoxColumn;
    }
}
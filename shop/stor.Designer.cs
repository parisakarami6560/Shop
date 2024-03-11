namespace shop
{
    partial class stor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stor));
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codestroproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberpstorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysaledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paypurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet42 = new shop.shopDataSet42();
            this.storBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet21 = new shop.shopDataSet21();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_code = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioname = new System.Windows.Forms.RadioButton();
            this.radio_code = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeinvoiceproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatalpayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeinvoicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysaledDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.purchaselistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet41 = new shop.shopDataSet41();
            this.storTableAdapter = new shop.shopDataSet21TableAdapters.storTableAdapter();
            this.purchase_listTableAdapter = new shop.shopDataSet41TableAdapters.purchase_listTableAdapter();
            this.storBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storTableAdapter1 = new shop.shopDataSet42TableAdapters.storTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaselistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(12, 437);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 31);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 16;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(11, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "خانه";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codestroproductDataGridViewTextBoxColumn,
            this.numberpstorDataGridViewTextBoxColumn,
            this.paysaledDataGridViewTextBoxColumn,
            this.nameproductDataGridViewTextBoxColumn,
            this.paypurDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.storBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(105, 340);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(537, 150);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // codestroproductDataGridViewTextBoxColumn
            // 
            this.codestroproductDataGridViewTextBoxColumn.DataPropertyName = "code_stro_product";
            this.codestroproductDataGridViewTextBoxColumn.HeaderText = "کد محصول";
            this.codestroproductDataGridViewTextBoxColumn.Name = "codestroproductDataGridViewTextBoxColumn";
            // 
            // numberpstorDataGridViewTextBoxColumn
            // 
            this.numberpstorDataGridViewTextBoxColumn.DataPropertyName = "number_p_stor";
            this.numberpstorDataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.numberpstorDataGridViewTextBoxColumn.Name = "numberpstorDataGridViewTextBoxColumn";
            // 
            // paysaledDataGridViewTextBoxColumn
            // 
            this.paysaledDataGridViewTextBoxColumn.DataPropertyName = "pay_saled";
            this.paysaledDataGridViewTextBoxColumn.HeaderText = "قیمت فروش";
            this.paysaledDataGridViewTextBoxColumn.Name = "paysaledDataGridViewTextBoxColumn";
            // 
            // nameproductDataGridViewTextBoxColumn
            // 
            this.nameproductDataGridViewTextBoxColumn.DataPropertyName = "name_product";
            this.nameproductDataGridViewTextBoxColumn.HeaderText = "نام محصول";
            this.nameproductDataGridViewTextBoxColumn.Name = "nameproductDataGridViewTextBoxColumn";
            // 
            // paypurDataGridViewTextBoxColumn
            // 
            this.paypurDataGridViewTextBoxColumn.DataPropertyName = "pay_pur";
            this.paypurDataGridViewTextBoxColumn.HeaderText = "قیمت خرید";
            this.paypurDataGridViewTextBoxColumn.Name = "paypurDataGridViewTextBoxColumn";
            // 
            // storBindingSource2
            // 
            this.storBindingSource2.DataMember = "stor";
            this.storBindingSource2.DataSource = this.shopDataSet42;
            // 
            // shopDataSet42
            // 
            this.shopDataSet42.DataSetName = "shopDataSet42";
            this.shopDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storBindingSource
            // 
            this.storBindingSource.DataMember = "stor";
            this.storBindingSource.DataSource = this.shopDataSet21;
            // 
            // shopDataSet21
            // 
            this.shopDataSet21.DataSetName = "shopDataSet21";
            this.shopDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "جستجو";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT_code
            // 
            this.TXT_code.Location = new System.Drawing.Point(95, 39);
            this.TXT_code.Name = "TXT_code";
            this.TXT_code.Size = new System.Drawing.Size(100, 20);
            this.TXT_code.TabIndex = 19;
            this.TXT_code.UseWaitCursor = true;
            this.TXT_code.TextChanged += new System.EventHandler(this.TXT_code_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(328, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 22;
            this.button3.Text = "ورود محصول به انبار";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(247, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 23;
            this.button4.Text = "حذف";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(154, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 38);
            this.button5.TabIndex = 24;
            this.button5.Text = "بروزرسانی";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(232, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "بعد از نمایش در جدول برای عملیات بر روی کد محصول کلیلک نمایید";
            this.label3.UseWaitCursor = true;
            // 
            // radioname
            // 
            this.radioname.AutoSize = true;
            this.radioname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioname.Location = new System.Drawing.Point(328, 3);
            this.radioname.Name = "radioname";
            this.radioname.Size = new System.Drawing.Size(85, 17);
            this.radioname.TabIndex = 35;
            this.radioname.TabStop = true;
            this.radioname.Text = "جستجو با نام";
            this.radioname.UseVisualStyleBackColor = true;
            // 
            // radio_code
            // 
            this.radio_code.AutoSize = true;
            this.radio_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radio_code.Location = new System.Drawing.Point(188, 3);
            this.radio_code.Name = "radio_code";
            this.radio_code.Size = new System.Drawing.Size(124, 17);
            this.radio_code.TabIndex = 34;
            this.radio_code.TabStop = true;
            this.radio_code.Text = "جستحو با کد محصول ";
            this.radio_code.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(208, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 34);
            this.label4.TabIndex = 37;
            this.label4.Text = "برای جستجو اطلاعات درخواستی را وارد کنید";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 43);
            this.label2.TabIndex = 38;
            this.label2.Text = "نمایش کلی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.radio_code);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioname);
            this.panel1.Controls.Add(this.TXT_code);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(176, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 100);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(176, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 70);
            this.panel2.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeinvoiceproductDataGridViewTextBoxColumn,
            this.numberproductDataGridViewTextBoxColumn,
            this.payproductDataGridViewTextBoxColumn,
            this.tatalpayDataGridViewTextBoxColumn,
            this.codeinvoicDataGridViewTextBoxColumn,
            this.paysaledDataGridViewTextBoxColumn1,
            this.storDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.purchaselistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(745, 96);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // codeinvoiceproductDataGridViewTextBoxColumn
            // 
            this.codeinvoiceproductDataGridViewTextBoxColumn.DataPropertyName = "code_invoice_product";
            this.codeinvoiceproductDataGridViewTextBoxColumn.HeaderText = "کد محصول";
            this.codeinvoiceproductDataGridViewTextBoxColumn.Name = "codeinvoiceproductDataGridViewTextBoxColumn";
            // 
            // numberproductDataGridViewTextBoxColumn
            // 
            this.numberproductDataGridViewTextBoxColumn.DataPropertyName = "number_product";
            this.numberproductDataGridViewTextBoxColumn.HeaderText = "تعداد محصول";
            this.numberproductDataGridViewTextBoxColumn.Name = "numberproductDataGridViewTextBoxColumn";
            // 
            // payproductDataGridViewTextBoxColumn
            // 
            this.payproductDataGridViewTextBoxColumn.DataPropertyName = "pay_product";
            this.payproductDataGridViewTextBoxColumn.HeaderText = "قیمت خرید";
            this.payproductDataGridViewTextBoxColumn.Name = "payproductDataGridViewTextBoxColumn";
            // 
            // tatalpayDataGridViewTextBoxColumn
            // 
            this.tatalpayDataGridViewTextBoxColumn.DataPropertyName = "tatal_pay";
            this.tatalpayDataGridViewTextBoxColumn.HeaderText = "قیمت کل";
            this.tatalpayDataGridViewTextBoxColumn.Name = "tatalpayDataGridViewTextBoxColumn";
            // 
            // codeinvoicDataGridViewTextBoxColumn
            // 
            this.codeinvoicDataGridViewTextBoxColumn.DataPropertyName = "code_invoic";
            this.codeinvoicDataGridViewTextBoxColumn.HeaderText = "کد فاکتور";
            this.codeinvoicDataGridViewTextBoxColumn.Name = "codeinvoicDataGridViewTextBoxColumn";
            // 
            // paysaledDataGridViewTextBoxColumn1
            // 
            this.paysaledDataGridViewTextBoxColumn1.DataPropertyName = "pay_saled";
            this.paysaledDataGridViewTextBoxColumn1.HeaderText = "قیمت فروش";
            this.paysaledDataGridViewTextBoxColumn1.Name = "paysaledDataGridViewTextBoxColumn1";
            // 
            // storDataGridViewCheckBoxColumn
            // 
            this.storDataGridViewCheckBoxColumn.DataPropertyName = "stor";
            this.storDataGridViewCheckBoxColumn.HeaderText = "ثبت در انبار";
            this.storDataGridViewCheckBoxColumn.Name = "storDataGridViewCheckBoxColumn";
            // 
            // purchaselistBindingSource
            // 
            this.purchaselistBindingSource.DataMember = "purchase_list";
            this.purchaselistBindingSource.DataSource = this.shopDataSet41;
            // 
            // shopDataSet41
            // 
            this.shopDataSet41.DataSetName = "shopDataSet41";
            this.shopDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storTableAdapter
            // 
            this.storTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_listTableAdapter
            // 
            this.purchase_listTableAdapter.ClearBeforeFill = true;
            // 
            // storBindingSource1
            // 
            this.storBindingSource1.DataMember = "stor";
            this.storBindingSource1.DataSource = this.shopDataSet42;
            // 
            // storTableAdapter1
            // 
            this.storTableAdapter1.ClearBeforeFill = true;
            // 
            // stor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.button2);
            this.Name = "stor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stor";
            this.Load += new System.EventHandler(this.stor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaselistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private shopDataSet21 shopDataSet21;
        private System.Windows.Forms.BindingSource storBindingSource;
        private shopDataSet21TableAdapters.storTableAdapter storTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_code;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioname;
        private System.Windows.Forms.RadioButton radio_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet41 shopDataSet41;
        private System.Windows.Forms.BindingSource purchaselistBindingSource;
        private shopDataSet41TableAdapters.purchase_listTableAdapter purchase_listTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeinvoiceproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatalpayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeinvoicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysaledDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn storDataGridViewCheckBoxColumn;
        private shopDataSet42 shopDataSet42;
        private System.Windows.Forms.BindingSource storBindingSource1;
        private shopDataSet42TableAdapters.storTableAdapter storTableAdapter1;
        private System.Windows.Forms.BindingSource storBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codestroproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberpstorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysaledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paypurDataGridViewTextBoxColumn;
    }
}
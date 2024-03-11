namespace shop
{
    partial class listpurch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listpurch));
            this.shopDataSet10 = new shop.shopDataSet10();
            this.purchaseInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_InvoiceTableAdapter = new shop.shopDataSet10TableAdapters.purchase_InvoiceTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeINVOICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateinvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeinvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseInvoiceBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet49 = new shop.shopDataSet49();
            this.purchaseInvoiceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet22 = new shop.shopDataSet22();
            this.purchaseInvoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet11 = new shop.shopDataSet11();
            this.purchase_InvoiceTableAdapter1 = new shop.shopDataSet11TableAdapters.purchase_InvoiceTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_code = new System.Windows.Forms.TextBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.purchase_InvoiceTableAdapter2 = new shop.shopDataSet22TableAdapters.purchase_InvoiceTableAdapter();
            this.purchase_InvoiceTableAdapter3 = new shop.shopDataSet49TableAdapters.purchase_InvoiceTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // shopDataSet10
            // 
            this.shopDataSet10.DataSetName = "shopDataSet10";
            this.shopDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseInvoiceBindingSource
            // 
            this.purchaseInvoiceBindingSource.DataMember = "purchase_Invoice";
            this.purchaseInvoiceBindingSource.DataSource = this.shopDataSet10;
            // 
            // purchase_InvoiceTableAdapter
            // 
            this.purchase_InvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeINVOICEDataGridViewTextBoxColumn,
            this.dateinvoiceDataGridViewTextBoxColumn,
            this.timeinvoiceDataGridViewTextBoxColumn,
            this.totalpayDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.shippingcostDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchaseInvoiceBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(163, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(744, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // codeINVOICEDataGridViewTextBoxColumn
            // 
            this.codeINVOICEDataGridViewTextBoxColumn.DataPropertyName = "code_INVOICE";
            this.codeINVOICEDataGridViewTextBoxColumn.HeaderText = "کد فاکتور";
            this.codeINVOICEDataGridViewTextBoxColumn.Name = "codeINVOICEDataGridViewTextBoxColumn";
            // 
            // dateinvoiceDataGridViewTextBoxColumn
            // 
            this.dateinvoiceDataGridViewTextBoxColumn.DataPropertyName = "date_invoice";
            this.dateinvoiceDataGridViewTextBoxColumn.HeaderText = "تاریخ صدور فاکتور";
            this.dateinvoiceDataGridViewTextBoxColumn.Name = "dateinvoiceDataGridViewTextBoxColumn";
            // 
            // timeinvoiceDataGridViewTextBoxColumn
            // 
            this.timeinvoiceDataGridViewTextBoxColumn.DataPropertyName = "time_invoice";
            this.timeinvoiceDataGridViewTextBoxColumn.HeaderText = "زمان";
            this.timeinvoiceDataGridViewTextBoxColumn.Name = "timeinvoiceDataGridViewTextBoxColumn";
            // 
            // totalpayDataGridViewTextBoxColumn
            // 
            this.totalpayDataGridViewTextBoxColumn.DataPropertyName = "total_pay";
            this.totalpayDataGridViewTextBoxColumn.HeaderText = "قیمت کل";
            this.totalpayDataGridViewTextBoxColumn.Name = "totalpayDataGridViewTextBoxColumn";
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "مالیات";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            // 
            // shippingcostDataGridViewTextBoxColumn
            // 
            this.shippingcostDataGridViewTextBoxColumn.DataPropertyName = "shipping_cost";
            this.shippingcostDataGridViewTextBoxColumn.HeaderText = "کرایه حمل";
            this.shippingcostDataGridViewTextBoxColumn.Name = "shippingcostDataGridViewTextBoxColumn";
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "قیمت نهایی";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            // 
            // purchaseInvoiceBindingSource3
            // 
            this.purchaseInvoiceBindingSource3.DataMember = "purchase_Invoice";
            this.purchaseInvoiceBindingSource3.DataSource = this.shopDataSet49;
            // 
            // shopDataSet49
            // 
            this.shopDataSet49.DataSetName = "shopDataSet49";
            this.shopDataSet49.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseInvoiceBindingSource2
            // 
            this.purchaseInvoiceBindingSource2.DataMember = "purchase_Invoice";
            this.purchaseInvoiceBindingSource2.DataSource = this.shopDataSet22;
            // 
            // shopDataSet22
            // 
            this.shopDataSet22.DataSetName = "shopDataSet22";
            this.shopDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseInvoiceBindingSource1
            // 
            this.purchaseInvoiceBindingSource1.DataMember = "purchase_Invoice";
            this.purchaseInvoiceBindingSource1.DataSource = this.shopDataSet11;
            // 
            // shopDataSet11
            // 
            this.shopDataSet11.DataSetName = "shopDataSet11";
            this.shopDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchase_InvoiceTableAdapter1
            // 
            this.purchase_InvoiceTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(487, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "نمایش";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(726, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "برای جستجو کد فاکتور را وارد کنید";
            this.label1.UseWaitCursor = true;
            // 
            // TXT_code
            // 
            this.TXT_code.Location = new System.Drawing.Point(595, 21);
            this.TXT_code.Name = "TXT_code";
            this.TXT_code.Size = new System.Drawing.Size(100, 20);
            this.TXT_code.TabIndex = 19;
            this.TXT_code.UseWaitCursor = true;
            this.TXT_code.TextChanged += new System.EventHandler(this.TXT_code_TextChanged);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(12, 368);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 31);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 23;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(14, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "خانه";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // purchase_InvoiceTableAdapter2
            // 
            this.purchase_InvoiceTableAdapter2.ClearBeforeFill = true;
            // 
            // purchase_InvoiceTableAdapter3
            // 
            this.purchase_InvoiceTableAdapter3.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(163, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 143);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(51, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(683, 80);
            this.dataGridView2.TabIndex = 0;
            // 
            // listpurch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_code);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "listpurch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listpurch";
            this.Load += new System.EventHandler(this.listpurchcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseInvoiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private shopDataSet10 shopDataSet10;
        private System.Windows.Forms.BindingSource purchaseInvoiceBindingSource;
        private shopDataSet10TableAdapters.purchase_InvoiceTableAdapter purchase_InvoiceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet11 shopDataSet11;
        private System.Windows.Forms.BindingSource purchaseInvoiceBindingSource1;
        private shopDataSet11TableAdapters.purchase_InvoiceTableAdapter purchase_InvoiceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeINVOICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateinvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeinvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_code;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button2;
        private shopDataSet22 shopDataSet22;
        private System.Windows.Forms.BindingSource purchaseInvoiceBindingSource2;
        private shopDataSet22TableAdapters.purchase_InvoiceTableAdapter purchase_InvoiceTableAdapter2;
        private shopDataSet49 shopDataSet49;
        private System.Windows.Forms.BindingSource purchaseInvoiceBindingSource3;
        private shopDataSet49TableAdapters.purchase_InvoiceTableAdapter purchase_InvoiceTableAdapter3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
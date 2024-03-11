namespace shop
{
    partial class liststaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(liststaff));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet5 = new shop.shopDataSet5();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_code_staff = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.staffTableAdapter = new shop.shopDataSet5TableAdapters.staffTableAdapter();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.shopDataSet55 = new shop.shopDataSet55();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter1 = new shop.shopDataSet55TableAdapters.staffTableAdapter();
            this.shopDataSet55BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.codestaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namestaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnamestaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet55BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codestaffDataGridViewTextBoxColumn,
            this.namestaffDataGridViewTextBoxColumn,
            this.lnamestaffDataGridViewTextBoxColumn,
            this.tellDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.shopDataSet5;
            // 
            // shopDataSet5
            // 
            this.shopDataSet5.DataSetName = "shopDataSet5";
            this.shopDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "نمایش";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(240, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "برای جستجو کد کارمند را وارد کنید";
            this.label1.UseWaitCursor = true;
            // 
            // TXT_code_staff
            // 
            this.TXT_code_staff.Location = new System.Drawing.Point(117, 0);
            this.TXT_code_staff.Name = "TXT_code_staff";
            this.TXT_code_staff.Size = new System.Drawing.Size(100, 20);
            this.TXT_code_staff.TabIndex = 19;
            this.TXT_code_staff.UseWaitCursor = true;
            this.TXT_code_staff.TextChanged += new System.EventHandler(this.TXT_code_staff_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(1, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "خانه";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(2, 207);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 31);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 23;
            this.pictureBox13.TabStop = false;
            // 
            // shopDataSet55
            // 
            this.shopDataSet55.DataSetName = "shopDataSet55";
            this.shopDataSet55.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "staff";
            this.staffBindingSource1.DataSource = this.shopDataSet55;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // shopDataSet55BindingSource
            // 
            this.shopDataSet55BindingSource.DataSource = this.shopDataSet55;
            this.shopDataSet55BindingSource.Position = 0;
            // 
            // staffBindingSource2
            // 
            this.staffBindingSource2.DataMember = "staff";
            this.staffBindingSource2.DataSource = this.shopDataSet55BindingSource;
            // 
            // codestaffDataGridViewTextBoxColumn
            // 
            this.codestaffDataGridViewTextBoxColumn.DataPropertyName = "code_staff";
            this.codestaffDataGridViewTextBoxColumn.HeaderText = "code_staff";
            this.codestaffDataGridViewTextBoxColumn.Name = "codestaffDataGridViewTextBoxColumn";
            this.codestaffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namestaffDataGridViewTextBoxColumn
            // 
            this.namestaffDataGridViewTextBoxColumn.DataPropertyName = "name_staff";
            this.namestaffDataGridViewTextBoxColumn.HeaderText = "name_staff";
            this.namestaffDataGridViewTextBoxColumn.Name = "namestaffDataGridViewTextBoxColumn";
            // 
            // lnamestaffDataGridViewTextBoxColumn
            // 
            this.lnamestaffDataGridViewTextBoxColumn.DataPropertyName = "lname_staff";
            this.lnamestaffDataGridViewTextBoxColumn.HeaderText = "lname_staff";
            this.lnamestaffDataGridViewTextBoxColumn.Name = "lnamestaffDataGridViewTextBoxColumn";
            // 
            // tellDataGridViewTextBoxColumn
            // 
            this.tellDataGridViewTextBoxColumn.DataPropertyName = "tell";
            this.tellDataGridViewTextBoxColumn.HeaderText = "tell";
            this.tellDataGridViewTextBoxColumn.Name = "tellDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "typ";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            // 
            // liststaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_code_staff);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "liststaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "liststaff";
            this.Load += new System.EventHandler(this.liststaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet55BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet5 shopDataSet5;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private shopDataSet5TableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_code_staff;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button2;
        private shopDataSet55 shopDataSet55;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private shopDataSet55TableAdapters.staffTableAdapter staffTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codestaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnamestaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffBindingSource2;
        private System.Windows.Forms.BindingSource shopDataSet55BindingSource;
    }
}
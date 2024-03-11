namespace shop
{
    partial class list_employment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_employment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeemployDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet6 = new shop.shopDataSet6();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_code_emplo = new System.Windows.Forms.TextBox();
            this.employmentTableAdapter = new shop.shopDataSet6TableAdapters.employmentTableAdapter();
            this.shopDataSet8 = new shop.shopDataSet8();
            this.managmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managmentTableAdapter = new shop.shopDataSet8TableAdapters.managmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typDataGridViewTextBoxColumn,
            this.codeemployDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "نوع استخدام";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            // 
            // codeemployDataGridViewTextBoxColumn
            // 
            this.codeemployDataGridViewTextBoxColumn.DataPropertyName = "code_employ";
            this.codeemployDataGridViewTextBoxColumn.HeaderText = "کد کارمند";
            this.codeemployDataGridViewTextBoxColumn.Name = "codeemployDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "نام کاربری";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "پسورد";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // employmentBindingSource
            // 
            this.employmentBindingSource.DataMember = "employment";
            this.employmentBindingSource.DataSource = this.shopDataSet6;
            // 
            // shopDataSet6
            // 
            this.shopDataSet6.DataSetName = "shopDataSet6";
            this.shopDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1, 211);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 31);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 14;
            this.pictureBox13.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(1, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "خانه";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(31, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "نمایش";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(269, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "برای جستجو کد کارمند را وارد کنید";
            this.label1.UseWaitCursor = true;
            // 
            // TXT_code_emplo
            // 
            this.TXT_code_emplo.Location = new System.Drawing.Point(146, 13);
            this.TXT_code_emplo.Name = "TXT_code_emplo";
            this.TXT_code_emplo.Size = new System.Drawing.Size(100, 20);
            this.TXT_code_emplo.TabIndex = 19;
            this.TXT_code_emplo.UseWaitCursor = true;
            this.TXT_code_emplo.TextChanged += new System.EventHandler(this.TXT_code_emplo_TextChanged);
            // 
            // employmentTableAdapter
            // 
            this.employmentTableAdapter.ClearBeforeFill = true;
            // 
            // shopDataSet8
            // 
            this.shopDataSet8.DataSetName = "shopDataSet8";
            this.shopDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managmentBindingSource
            // 
            this.managmentBindingSource.DataMember = "managment";
            this.managmentBindingSource.DataSource = this.shopDataSet8;
            // 
            // managmentTableAdapter
            // 
            this.managmentTableAdapter.ClearBeforeFill = true;
            // 
            // list_employment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 270);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_code_emplo);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "list_employment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست کارکنان";
            this.Load += new System.EventHandler(this.list_employment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet6 shopDataSet6;
        private System.Windows.Forms.BindingSource employmentBindingSource;
        private shopDataSet6TableAdapters.employmentTableAdapter employmentTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_code_emplo;
        private shopDataSet8 shopDataSet8;
        private System.Windows.Forms.BindingSource managmentBindingSource;
        private shopDataSet8TableAdapters.managmentTableAdapter managmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeemployDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
    }
}
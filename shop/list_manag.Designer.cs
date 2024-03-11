namespace shop
{
    partial class list_manag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_manag));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codemangmantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemanagmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnamemanagmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet7 = new shop.shopDataSet7();
            this.managmentTableAdapter = new shop.shopDataSet7TableAdapters.managmentTableAdapter();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codemangmantDataGridViewTextBoxColumn,
            this.namemanagmentDataGridViewTextBoxColumn,
            this.lnamemanagmentDataGridViewTextBoxColumn,
            this.tellDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.managmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 131);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codemangmantDataGridViewTextBoxColumn
            // 
            this.codemangmantDataGridViewTextBoxColumn.DataPropertyName = "code_mangmant";
            this.codemangmantDataGridViewTextBoxColumn.HeaderText = "کد مدیریت";
            this.codemangmantDataGridViewTextBoxColumn.Name = "codemangmantDataGridViewTextBoxColumn";
            this.codemangmantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namemanagmentDataGridViewTextBoxColumn
            // 
            this.namemanagmentDataGridViewTextBoxColumn.DataPropertyName = "name_managment";
            this.namemanagmentDataGridViewTextBoxColumn.HeaderText = "نام";
            this.namemanagmentDataGridViewTextBoxColumn.Name = "namemanagmentDataGridViewTextBoxColumn";
            // 
            // lnamemanagmentDataGridViewTextBoxColumn
            // 
            this.lnamemanagmentDataGridViewTextBoxColumn.DataPropertyName = "lname_managment";
            this.lnamemanagmentDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.lnamemanagmentDataGridViewTextBoxColumn.Name = "lnamemanagmentDataGridViewTextBoxColumn";
            // 
            // tellDataGridViewTextBoxColumn
            // 
            this.tellDataGridViewTextBoxColumn.DataPropertyName = "tell";
            this.tellDataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.tellDataGridViewTextBoxColumn.Name = "tellDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "نوع استخدام";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            // 
            // managmentBindingSource
            // 
            this.managmentBindingSource.DataMember = "managment";
            this.managmentBindingSource.DataSource = this.shopDataSet7;
            // 
            // shopDataSet7
            // 
            this.shopDataSet7.DataSetName = "shopDataSet7";
            this.shopDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managmentTableAdapter
            // 
            this.managmentTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(12, 176);
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
            this.button2.Location = new System.Drawing.Point(11, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "خانه";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // list_manag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 274);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "list_manag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "list_manag";
            this.Load += new System.EventHandler(this.list_manag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet7 shopDataSet7;
        private System.Windows.Forms.BindingSource managmentBindingSource;
        private shopDataSet7TableAdapters.managmentTableAdapter managmentTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codemangmantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemanagmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnamemanagmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
    }
}
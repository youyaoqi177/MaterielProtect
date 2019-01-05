namespace UI
{
    partial class FormMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddOpen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MName,
            this.PID,
            this.PuPrice,
            this.SaPrice,
            this.Specifications,
            this.UID,
            this.Number,
            this.FirstDate,
            this.LastDate});
            this.dataGridView1.Location = new System.Drawing.Point(212, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // MName
            // 
            this.MName.DataPropertyName = "MName";
            this.MName.HeaderText = "名称";
            this.MName.Name = "MName";
            this.MName.ReadOnly = true;
            // 
            // PID
            // 
            this.PID.DataPropertyName = "pName";
            this.PID.HeaderText = "分类";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // PuPrice
            // 
            this.PuPrice.DataPropertyName = "PuPrice";
            this.PuPrice.HeaderText = "采购价";
            this.PuPrice.Name = "PuPrice";
            this.PuPrice.ReadOnly = true;
            // 
            // SaPrice
            // 
            this.SaPrice.DataPropertyName = "SaPrice";
            this.SaPrice.HeaderText = "销售价";
            this.SaPrice.Name = "SaPrice";
            this.SaPrice.ReadOnly = true;
            // 
            // Specifications
            // 
            this.Specifications.DataPropertyName = "Specifications";
            this.Specifications.HeaderText = "规格";
            this.Specifications.Name = "Specifications";
            this.Specifications.ReadOnly = true;
            // 
            // UID
            // 
            this.UID.DataPropertyName = "uName";
            this.UID.HeaderText = "单位";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "数量";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // FirstDate
            // 
            this.FirstDate.DataPropertyName = "FirstDate";
            this.FirstDate.HeaderText = "添加日期";
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.ReadOnly = true;
            // 
            // LastDate
            // 
            this.LastDate.DataPropertyName = "LastDate";
            this.LastDate.HeaderText = "修改日期";
            this.LastDate.Name = "LastDate";
            this.LastDate.ReadOnly = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(13, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 424);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // btnAddOpen
            // 
            this.btnAddOpen.Location = new System.Drawing.Point(12, 12);
            this.btnAddOpen.Name = "btnAddOpen";
            this.btnAddOpen.Size = new System.Drawing.Size(75, 23);
            this.btnAddOpen.TabIndex = 2;
            this.btnAddOpen.Text = "添加";
            this.btnAddOpen.UseVisualStyleBackColor = true;
            this.btnAddOpen.Click += new System.EventHandler(this.btnAddOpen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddOpen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "首页";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddOpen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDate;
    }
}
namespace WindowsFormsApplication1
{
    partial class MainForm
    {

        private System.Windows.Forms.Button button1;


        private void InitializeComponent()
        {
            this.btnReadXml = new System.Windows.Forms.Button();
            this.btnWriteXml = new System.Windows.Forms.Button();
            this.btnConfigXml = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            total = new System.Windows.Forms.Label();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadXml
            // 
            this.btnReadXml.Location = new System.Drawing.Point(8, 12);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(75, 23);
            this.btnReadXml.TabIndex = 0;
            this.btnReadXml.Text = "Read XML";
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // btnWriteXml
            // 
            this.btnWriteXml.Location = new System.Drawing.Point(8, 48);
            this.btnWriteXml.Name = "btnWriteXml";
            this.btnWriteXml.Size = new System.Drawing.Size(75, 23);
            this.btnWriteXml.TabIndex = 1;
            this.btnWriteXml.Text = "Write XML";
            this.btnWriteXml.Click += new System.EventHandler(this.btnWriteXml_Click);
            // 
            // btnConfigXml
            // 
            this.btnConfigXml.Location = new System.Drawing.Point(8, 88);
            this.btnConfigXml.Name = "btnConfigXml";
            this.btnConfigXml.Size = new System.Drawing.Size(75, 23);
            this.btnConfigXml.TabIndex = 2;
            this.btnConfigXml.Text = "Config";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 78);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total:";
            // 
            // label3
            // 
            total.AutoSize = true;
            total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total.Location = new System.Drawing.Point(541, 491);
            total.Name = "label3";
            total.Size = new System.Drawing.Size(54, 25);
            total.TabIndex = 6;
            total.Text = "0.00";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Edit});
            dataGridView2.Location = new System.Drawing.Point(23, 164);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new System.Drawing.Size(589, 309);
            dataGridView2.TabIndex = 7;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Width = 34;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(631, 544);
            this.Controls.Add(dataGridView2);
            this.Controls.Add(total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfigXml);
            this.Controls.Add(this.btnWriteXml);
            this.Controls.Add(this.btnReadXml);
            this.Name = "MainForm";
            this.Text = "Expense Manager PRO";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        public static  System.Windows.Forms.Label total;
        public static System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}


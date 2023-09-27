namespace w_form_project
{
    partial class FormAnaL
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
            this.butAnanew = new System.Windows.Forms.Button();
            this.butAnaADD = new System.Windows.Forms.Button();
            this.dataGridViewANA = new System.Windows.Forms.DataGridView();
            this.textBox1ANA = new System.Windows.Forms.TextBox();
            this.butDeleted = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teanid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewANA)).BeginInit();
            this.SuspendLayout();
            // 
            // butAnanew
            // 
            this.butAnanew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butAnanew.Location = new System.Drawing.Point(257, 12);
            this.butAnanew.Name = "butAnanew";
            this.butAnanew.Size = new System.Drawing.Size(75, 23);
            this.butAnanew.TabIndex = 0;
            this.butAnanew.Text = "جديد";
            this.butAnanew.UseVisualStyleBackColor = true;
            this.butAnanew.Click += new System.EventHandler(this.butAnanew_Click);
            // 
            // butAnaADD
            // 
            this.butAnaADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butAnaADD.Location = new System.Drawing.Point(176, 12);
            this.butAnaADD.Name = "butAnaADD";
            this.butAnaADD.Size = new System.Drawing.Size(75, 23);
            this.butAnaADD.TabIndex = 1;
            this.butAnaADD.Text = "اضافة";
            this.butAnaADD.UseVisualStyleBackColor = true;
            this.butAnaADD.Click += new System.EventHandler(this.butAnaADD_Click);
            // 
            // dataGridViewANA
            // 
            this.dataGridViewANA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewANA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewANA.Location = new System.Drawing.Point(6, 109);
            this.dataGridViewANA.Name = "dataGridViewANA";
            this.dataGridViewANA.Size = new System.Drawing.Size(326, 150);
            this.dataGridViewANA.TabIndex = 2;
            this.dataGridViewANA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewANA_CellContentClick);
            this.dataGridViewANA.SelectionChanged += new System.EventHandler(this.dataGridViewANA_SelectionChanged);
            // 
            // textBox1ANA
            // 
            this.textBox1ANA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1ANA.Location = new System.Drawing.Point(95, 70);
            this.textBox1ANA.Name = "textBox1ANA";
            this.textBox1ANA.Size = new System.Drawing.Size(156, 20);
            this.textBox1ANA.TabIndex = 3;
            // 
            // butDeleted
            // 
            this.butDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butDeleted.Location = new System.Drawing.Point(14, 12);
            this.butDeleted.Name = "butDeleted";
            this.butDeleted.Size = new System.Drawing.Size(75, 23);
            this.butDeleted.TabIndex = 4;
            this.butDeleted.Text = "حذف";
            this.butDeleted.UseVisualStyleBackColor = true;
            this.butDeleted.Click += new System.EventHandler(this.butDeleted_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم التحليل";
            // 
            // teanid
            // 
            this.teanid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teanid.Location = new System.Drawing.Point(95, 44);
            this.teanid.Name = "teanid";
            this.teanid.Size = new System.Drawing.Size(156, 20);
            this.teanid.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(95, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "تعديل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAnaL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teanid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDeleted);
            this.Controls.Add(this.textBox1ANA);
            this.Controls.Add(this.dataGridViewANA);
            this.Controls.Add(this.butAnaADD);
            this.Controls.Add(this.butAnanew);
            this.Name = "FormAnaL";
            this.Text = "التحاليل";
            this.Load += new System.EventHandler(this.FormAnaL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewANA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAnanew;
        private System.Windows.Forms.Button butAnaADD;
        private System.Windows.Forms.DataGridView dataGridViewANA;
        private System.Windows.Forms.TextBox textBox1ANA;
        private System.Windows.Forms.Button butDeleted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teanid;
        private System.Windows.Forms.Button button1;
    }
}
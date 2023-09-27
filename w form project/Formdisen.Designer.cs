namespace w_form_project
{
    partial class Formdisen
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
            this.label1 = new System.Windows.Forms.Label();
            this.butDeleted = new System.Windows.Forms.Button();
            this.textBox1ANA = new System.Windows.Forms.TextBox();
            this.dataGridViewANA = new System.Windows.Forms.DataGridView();
            this.butAnaADD = new System.Windows.Forms.Button();
            this.butAnanew = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewANA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم المرض";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butDeleted
            // 
            this.butDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butDeleted.Location = new System.Drawing.Point(12, 7);
            this.butDeleted.Name = "butDeleted";
            this.butDeleted.Size = new System.Drawing.Size(75, 23);
            this.butDeleted.TabIndex = 10;
            this.butDeleted.Text = "حذف";
            this.butDeleted.UseVisualStyleBackColor = true;
            this.butDeleted.Click += new System.EventHandler(this.butDeleted_Click);
            // 
            // textBox1ANA
            // 
            this.textBox1ANA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1ANA.Location = new System.Drawing.Point(82, 73);
            this.textBox1ANA.Name = "textBox1ANA";
            this.textBox1ANA.Size = new System.Drawing.Size(156, 20);
            this.textBox1ANA.TabIndex = 9;
            // 
            // dataGridViewANA
            // 
            this.dataGridViewANA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewANA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewANA.Location = new System.Drawing.Point(21, 129);
            this.dataGridViewANA.Name = "dataGridViewANA";
            this.dataGridViewANA.Size = new System.Drawing.Size(310, 150);
            this.dataGridViewANA.TabIndex = 8;
            this.dataGridViewANA.SelectionChanged += new System.EventHandler(this.dataGridViewANA_SelectionChanged);
            // 
            // butAnaADD
            // 
            this.butAnaADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butAnaADD.Location = new System.Drawing.Point(94, 7);
            this.butAnaADD.Name = "butAnaADD";
            this.butAnaADD.Size = new System.Drawing.Size(75, 23);
            this.butAnaADD.TabIndex = 7;
            this.butAnaADD.Text = "تعديل";
            this.butAnaADD.UseVisualStyleBackColor = true;
            this.butAnaADD.Click += new System.EventHandler(this.butAnaADD_Click);
            // 
            // butAnanew
            // 
            this.butAnanew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butAnanew.Location = new System.Drawing.Point(264, 7);
            this.butAnanew.Name = "butAnanew";
            this.butAnanew.Size = new System.Drawing.Size(75, 23);
            this.butAnanew.TabIndex = 6;
            this.butAnanew.Text = "جديد";
            this.butAnanew.UseVisualStyleBackColor = true;
            this.butAnanew.Click += new System.EventHandler(this.butAnanew_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(215, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "هل المرض مزمن";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(183, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "اضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txid
            // 
            this.txid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txid.Location = new System.Drawing.Point(82, 47);
            this.txid.Name = "txid";
            this.txid.Size = new System.Drawing.Size(156, 20);
            this.txid.TabIndex = 14;
            // 
            // Formdisen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(343, 279);
            this.Controls.Add(this.txid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDeleted);
            this.Controls.Add(this.textBox1ANA);
            this.Controls.Add(this.dataGridViewANA);
            this.Controls.Add(this.butAnaADD);
            this.Controls.Add(this.butAnanew);
            this.Name = "Formdisen";
            this.Text = "الامراض";
            this.Load += new System.EventHandler(this.Formdisen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewANA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDeleted;
        private System.Windows.Forms.TextBox textBox1ANA;
        private System.Windows.Forms.DataGridView dataGridViewANA;
        private System.Windows.Forms.Button butAnaADD;
        private System.Windows.Forms.Button butAnanew;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txid;
    }
}
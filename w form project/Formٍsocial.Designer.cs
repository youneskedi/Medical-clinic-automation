namespace w_form_project
{
    partial class Formٍsocial
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
            this.button1 = new System.Windows.Forms.Button();
            this.txid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewANA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "اسم االحالة ";
            // 
            // butDeleted
            // 
            this.butDeleted.Location = new System.Drawing.Point(12, 7);
            this.butDeleted.Name = "butDeleted";
            this.butDeleted.Size = new System.Drawing.Size(75, 23);
            this.butDeleted.TabIndex = 22;
            this.butDeleted.Text = "حذف";
            this.butDeleted.UseVisualStyleBackColor = true;
            this.butDeleted.Click += new System.EventHandler(this.butDeleted_Click);
            // 
            // textBox1ANA
            // 
            this.textBox1ANA.Location = new System.Drawing.Point(61, 68);
            this.textBox1ANA.Name = "textBox1ANA";
            this.textBox1ANA.Size = new System.Drawing.Size(156, 20);
            this.textBox1ANA.TabIndex = 21;
            // 
            // dataGridViewANA
            // 
            this.dataGridViewANA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewANA.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewANA.Name = "dataGridViewANA";
            this.dataGridViewANA.Size = new System.Drawing.Size(313, 150);
            this.dataGridViewANA.TabIndex = 20;
            this.dataGridViewANA.SelectionChanged += new System.EventHandler(this.dataGridViewANA_SelectionChanged);
            // 
            // butAnaADD
            // 
            this.butAnaADD.Location = new System.Drawing.Point(93, 7);
            this.butAnaADD.Name = "butAnaADD";
            this.butAnaADD.Size = new System.Drawing.Size(75, 23);
            this.butAnaADD.TabIndex = 19;
            this.butAnaADD.Text = "حفظ";
            this.butAnaADD.UseVisualStyleBackColor = true;
            this.butAnaADD.Click += new System.EventHandler(this.butAnaADD_Click);
            // 
            // butAnanew
            // 
            this.butAnanew.Location = new System.Drawing.Point(259, 7);
            this.butAnanew.Name = "butAnanew";
            this.butAnanew.Size = new System.Drawing.Size(75, 23);
            this.butAnanew.TabIndex = 18;
            this.butAnanew.Text = "جديد";
            this.butAnanew.UseVisualStyleBackColor = true;
            this.butAnanew.Click += new System.EventHandler(this.butAnanew_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "اضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txid
            // 
            this.txid.Location = new System.Drawing.Point(61, 42);
            this.txid.Name = "txid";
            this.txid.Size = new System.Drawing.Size(156, 20);
            this.txid.TabIndex = 25;
            // 
            // Formٍsocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.txid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDeleted);
            this.Controls.Add(this.textBox1ANA);
            this.Controls.Add(this.dataGridViewANA);
            this.Controls.Add(this.butAnaADD);
            this.Controls.Add(this.butAnanew);
            this.Name = "Formٍsocial";
            this.Text = "الحالة الاجتماعيه";
            this.Load += new System.EventHandler(this.Formٍsocial_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txid;
    }
}
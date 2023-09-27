namespace w_form_project
{
    partial class formBook
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
            this.butbook = new System.Windows.Forms.Button();
            this.butbookdel = new System.Windows.Forms.Button();
            this.rebookName = new System.Windows.Forms.ComboBox();
            this.respid = new System.Windows.Forms.ComboBox();
            this.review = new System.Windows.Forms.ComboBox();
            this.rebookDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butbook
            // 
            this.butbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butbook.Font = new System.Drawing.Font("Tahoma", 10F);
            this.butbook.ForeColor = System.Drawing.Color.DarkBlue;
            this.butbook.Location = new System.Drawing.Point(128, 255);
            this.butbook.Name = "butbook";
            this.butbook.Size = new System.Drawing.Size(103, 37);
            this.butbook.TabIndex = 0;
            this.butbook.Text = "اضافةحجز";
            this.butbook.UseVisualStyleBackColor = true;
            this.butbook.Click += new System.EventHandler(this.butbook_Click);
            // 
            // butbookdel
            // 
            this.butbookdel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butbookdel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.butbookdel.ForeColor = System.Drawing.Color.DarkBlue;
            this.butbookdel.Location = new System.Drawing.Point(263, 255);
            this.butbookdel.Name = "butbookdel";
            this.butbookdel.Size = new System.Drawing.Size(87, 37);
            this.butbookdel.TabIndex = 1;
            this.butbookdel.Text = "حجز جديد";
            this.butbookdel.UseVisualStyleBackColor = true;
            this.butbookdel.Click += new System.EventHandler(this.butbookdel_Click);
            // 
            // rebookName
            // 
            this.rebookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rebookName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rebookName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rebookName.FormattingEnabled = true;
            this.rebookName.Location = new System.Drawing.Point(173, 36);
            this.rebookName.Name = "rebookName";
            this.rebookName.Size = new System.Drawing.Size(121, 21);
            this.rebookName.TabIndex = 2;
            // 
            // respid
            // 
            this.respid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.respid.FormattingEnabled = true;
            this.respid.Location = new System.Drawing.Point(173, 108);
            this.respid.Name = "respid";
            this.respid.Size = new System.Drawing.Size(121, 21);
            this.respid.TabIndex = 3;
            // 
            // review
            // 
            this.review.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.review.FormattingEnabled = true;
            this.review.Location = new System.Drawing.Point(173, 144);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(121, 21);
            this.review.TabIndex = 4;
            // 
            // rebookDate
            // 
            this.rebookDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rebookDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.rebookDate.Location = new System.Drawing.Point(173, 72);
            this.rebookDate.Name = "rebookDate";
            this.rebookDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rebookDate.RightToLeftLayout = true;
            this.rebookDate.Size = new System.Drawing.Size(121, 20);
            this.rebookDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-71, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "وقت الحجز";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(359, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "ملاحظات";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(353, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "نوع الكشف";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(373, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "العيادة";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(355, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "وقت الحجز";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(368, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "المريض";
            // 
            // reNotes
            // 
            this.reNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reNotes.Location = new System.Drawing.Point(161, 189);
            this.reNotes.Multiline = true;
            this.reNotes.Name = "reNotes";
            this.reNotes.Size = new System.Drawing.Size(133, 41);
            this.reNotes.TabIndex = 12;
            // 
            // formBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(451, 330);
            this.Controls.Add(this.reNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rebookDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.review);
            this.Controls.Add(this.respid);
            this.Controls.Add(this.rebookName);
            this.Controls.Add(this.butbookdel);
            this.Controls.Add(this.butbook);
            this.Name = "formBook";
            this.Text = "حجز كشف";
            this.Load += new System.EventHandler(this.formBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butbook;
        private System.Windows.Forms.Button butbookdel;
        private System.Windows.Forms.ComboBox rebookName;
        private System.Windows.Forms.ComboBox respid;
        private System.Windows.Forms.ComboBox review;
        private System.Windows.Forms.DateTimePicker rebookDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reNotes;
    }
}
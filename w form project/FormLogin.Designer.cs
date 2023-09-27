namespace w_form_project
{
    partial class FormLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butLogin = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(375, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(393, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة المرور";
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(175, 88);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(172, 20);
            this.tbusername.TabIndex = 4;
            this.tbusername.TextChanged += new System.EventHandler(this.tbusername_TextChanged);
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(175, 131);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(172, 20);
            this.tbpassword.TabIndex = 5;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(175, 50);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(172, 20);
            this.tbid.TabIndex = 6;
            this.tbid.TextChanged += new System.EventHandler(this.tbid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(375, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "رقم المستخدم";
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butLogin.ForeColor = System.Drawing.Color.DarkBlue;
            this.butLogin.Image = global::w_form_project.Properties.Resources.input;
            this.butLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butLogin.Location = new System.Drawing.Point(296, 188);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(148, 37);
            this.butLogin.TabIndex = 0;
            this.butLogin.Text = "تسجيل الدخول";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butexit
            // 
            this.butexit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butexit.ForeColor = System.Drawing.Color.DarkBlue;
            this.butexit.Image = global::w_form_project.Properties.Resources._out;
            this.butexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butexit.Location = new System.Drawing.Point(114, 188);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(152, 37);
            this.butexit.TabIndex = 1;
            this.butexit.Text = "تسجيل الخروج";
            this.butexit.UseVisualStyleBackColor = false;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.butLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(497, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butLogin);
            this.Name = "FormLogin";
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label3;
    }
}
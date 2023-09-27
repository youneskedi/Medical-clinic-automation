using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace w_form_project
{
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");
       
        SqlCommand cmd;
    

       
        DataTable d1 = new DataTable();
    
        public FormLogin()
        {
            InitializeComponent();

          
           
        }

        private void butexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {


            cmd = new SqlCommand("select * from Tuser where ID="+tbid.Text, con);
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar)).Value = tbusername.Text;
            cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar)).Value = tbpassword.Text;
             cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.VarChar)).Value = tbid.Text;
            
           try
            {
                con.Open();
                SqlDataReader ra = cmd.ExecuteReader();
                ra.Read();
                string z = ra.GetValue(1).ToString();
                string b = ra.GetValue(2).ToString();
                string c = ra.GetValue(0).ToString();
                string o = ra.GetValue(3).ToString();
               
                if (tbusername.Text == z & tbpassword.Text == b )
                {
                    if (o == "1")
                    {

                        FormMain frm = new FormMain();
                        frm.ShowDialog();
                    }

                    else if ( o == "2")
                    {
                        Formpantintaadd_edite fpa = new Formpantintaadd_edite();
                        fpa.ShowDialog();
                    }
                    
                }
                else MessageBox.Show("اسم المستخدم او كلمة المرور خطأ أعد المحاولة");
                tbusername.Text = "";
                tbpassword.Text = "";
                tbusername.Focus();
            }

            catch (SqlException ex)
            { MessageBox.Show(ex.Message, "اسم المستخدم او كلمة المرور خطأ أعد المحاولة", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           
            finally
            {
                con.Close();
            }
           
        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
         
        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

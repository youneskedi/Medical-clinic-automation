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
    public partial class Formlorestart : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public Formlorestart()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
           
            try {
                string m = "UPDATE  Tuser SET ID ='" + tbid.Text + "',name='" + tbusername.Text + "',pass='" + tbpassword.Text +  "' where ID=" + tbid.Text + "";
           
          SqlCommand   cmd3 = new SqlCommand(m, con);
                

                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
            catch(SqlException ex) {  MessageBox.Show(ex.Message, "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            }
        }

       

        private void butexit_Click(object sender, EventArgs e)
        {int d=1,h=2;
            
           
            try
            {

                string sql = "insert into  Tuser values(@ID,@name,@pass,@ty)";
               SqlCommand cmd3 = new SqlCommand(sql, con);
                cmd3.Parameters.AddWithValue("@ID", tbid.Text);
                cmd3.Parameters.AddWithValue("@name", tbusername.Text);
               cmd3.Parameters.AddWithValue("@pass", tbpassword.Text);
               if (radioButton1.Checked)
               cmd3.Parameters.AddWithValue("@ty", d.ToString());
                else if(radioButton2.Checked)
                   cmd3.Parameters.AddWithValue("@ty", h.ToString());
           
                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbid.Text = "";
                tbusername.Text = "";
                tbpassword.Text="";
                tbid.Focus();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            } 
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "Delete From Tuser where ID='" + tbid.Text + "'";
             SqlCommand   cmd3 = new SqlCommand(sql1, con);
                con.Open();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

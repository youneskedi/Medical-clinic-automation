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
    public partial class FormPAYTAYPE : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");
        
        SqlDataAdapter da;
        SqlCommand cmd3;
        DataTable dt = new DataTable();
        public FormPAYTAYPE()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from PayType", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;
            textBox1ANA.DataBindings.Add("text", dt, "ptName");
          
       
        }

        private void butAnanew_Click(object sender, EventArgs e)
        {
            txid.Text = "";
            textBox1ANA.Text = "";
            textBox1ANA.Focus();
        }

        private void butAnaADD_Click(object sender, EventArgs e)
        {
            try
            {
                string m = "UPDATE  PayType SET ptName= '" + textBox1ANA.Text + "' where ptID=" + txid.Text + "";

                cmd3 = new SqlCommand(m, con);


                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();
            }
            
           
            dt = new DataTable(); 
            da = new SqlDataAdapter("select * from PayType", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;

        }

        private void butDeleted_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "Delete From PayType where ptID ='" + txid.Text + "'";
                cmd3 = new SqlCommand(sql1, con);
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
            dt = new DataTable();
            da = new SqlDataAdapter("select * from PayType", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "insert into  PayType values(@ptName)";
                cmd3 = new SqlCommand(sql, con);
                cmd3.Parameters.AddWithValue("ptName", textBox1ANA.Text);
               
                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            } dt = new DataTable();
            da = new SqlDataAdapter("select * from PayType", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;
        }

        private void dataGridViewANA_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewANA.CurrentRow != null)
            {
                txid.Text = dataGridViewANA.CurrentRow.Cells[0].Value.ToString();
                textBox1ANA.Text = dataGridViewANA.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void FormPAYTAYPE_Load(object sender, EventArgs e)
        {
            txid.Visible = false;
        }
    }
}

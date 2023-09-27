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
    public partial class FormAnaL : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");
  
        SqlDataAdapter da;
        SqlCommand cmd3;
          
        DataTable dt = new DataTable();
        public FormAnaL()
        {
            InitializeComponent();
         da = new SqlDataAdapter("select * from Analysis", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;
          
        }

        private void butAnanew_Click(object sender, EventArgs e)
        {
            teanid.Text = "";
            textBox1ANA.Text = "";
           
        }

        private void butAnaADD_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "insert into Analysis values(@anName)";
                cmd3 = new SqlCommand(sql, con);
                cmd3.Parameters.AddWithValue("anName", textBox1ANA.Text);
               
                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            } dt = new DataTable();
          
                da = new SqlDataAdapter("select * from Analysis", con);
                da.Fill(dt);
                dataGridViewANA.DataSource = dt;

        }

        private void butDeleted_Click(object sender, EventArgs e)
        {try{
            string sql1 = "Delete From Analysis where anID ='" + teanid.Text + "'";
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
                da = new SqlDataAdapter("select * from Analysis", con);
                da.Fill(dt);
                dataGridViewANA.DataSource = dt;
        }

        private void dataGridViewANA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewANA_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewANA.CurrentRow != null)
            {
                teanid.Text = dataGridViewANA.CurrentRow.Cells[0].Value.ToString();
                textBox1ANA.Text = dataGridViewANA.CurrentRow.Cells[1].Value.ToString();

            }
              
        }

        private void FormAnaL_Load(object sender, EventArgs e)
        {
            teanid.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
            string m = "UPDATE Analysis SET anName= '"+  textBox1ANA.Text+"' where anID="+  teanid.Text+"";
           
             cmd3 = new SqlCommand(m, con);
                

                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
            catch(SqlException ex) {  MessageBox.Show(ex.Message, "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();
            } dt = new DataTable();
            da = new SqlDataAdapter("select * from Analysis", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;

        }
    }
}

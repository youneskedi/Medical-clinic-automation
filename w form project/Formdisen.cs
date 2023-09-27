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
    public partial class Formdisen : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");
       
        SqlDataAdapter da;
        SqlCommand cmd3;
       
        DataTable dt = new DataTable();
        public Formdisen()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from Disease", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;
        
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
                string m = "UPDATE  Disease SET diName= '" + textBox1ANA.Text + "',diChronic='"+checkBox1.Checked+"' where diID=" + txid.Text + "";

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
            da = new SqlDataAdapter("select * from Disease", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;
        }

        private void butDeleted_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "Delete From Disease where diID ='" + txid.Text + "'";
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
            da = new SqlDataAdapter("select * from Disease", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string sql = "insert into Disease values(@diName,@diChronic)";
                cmd3 = new SqlCommand(sql, con);
                cmd3.Parameters.AddWithValue("@diName", textBox1ANA.Text);
                cmd3.Parameters.AddWithValue("@diChronic", checkBox1.Checked);
               
                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            }
            dt = new DataTable();
            da = new SqlDataAdapter("select * from Disease", con);
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

        private void Formdisen_Load(object sender, EventArgs e)
        {
            txid.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Formreviewtype : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");
        SqlCommand cmd3;
        SqlDataAdapter da;

       
        DataTable dt = new DataTable();
        public Formreviewtype()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from ReviewType", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;
           
        }

        private void butDeleted_Click(object sender, EventArgs e)
        {


            try
            {
                string sql1 = "Delete From ReviewType where rtID ='" + txid.Text + "'";
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
            da = new SqlDataAdapter("select * from ReviewType", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;
        }

        private void butAnaADD_Click(object sender, EventArgs e)
        {
            try
            {
                string m = "UPDATE ReviewType SET rtName= '" + textBox1ANA.Text +"' ,rtPrice='"+textBoxprice.Text+"' where rtID=" + txid.Text + "";

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
            da = new SqlDataAdapter("select * from ReviewType", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;

        }

        private void butAnanew_Click(object sender, EventArgs e)
        {
            textBoxprice.Text = "";
            textBox1ANA.Text = "";
            txid.Text = "";

        }

        private void Formreviewtype_Load(object sender, EventArgs e)
        {
            txid.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string sql = "insert into  PayType values(@rtName,@rtPrice)";
                cmd3 = new SqlCommand(sql, con);
                cmd3.Parameters.AddWithValue("rtName", textBox1ANA.Text);
                cmd3.Parameters.AddWithValue("rtPrice", textBoxprice.Text);

                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            } dt = new DataTable();
            da = new SqlDataAdapter("select * from ReviewType", con);
            da.Fill(dt);
            dataGridViewANA.DataSource = dt;

        }

        private void dataGridViewANA_SizeChanged(object sender, EventArgs e)
        {
            if (dataGridViewANA.CurrentRow != null)
            {
                txid.Text = dataGridViewANA.CurrentRow.Cells[0].Value.ToString();
                textBox1ANA.Text = dataGridViewANA.CurrentRow.Cells[1].Value.ToString();
                textBoxprice.Text = dataGridViewANA.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}

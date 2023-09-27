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
    public partial class Form1 : Form
    { SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");

    SqlCommand cmd3;
        SqlDataAdapter da;
  
       
        DataTable d1 = new DataTable();
    
        public Form1()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from Doctor ", con);
            da.Fill(d1);
            dataGridView1.DataSource = d1;

        }
      
       


        private void doadd_Click(object sender, EventArgs e)
        {
            try
            {
              
                string sql = "insert into Doctor values(@doFName,@doLName,@do_spID,@doPhone,@doHomePhone,@doMobile)";
              cmd3 = new SqlCommand(sql, con);
                cmd3.Parameters.AddWithValue("doID", doid.Text);
                cmd3.Parameters.AddWithValue("@doFName", dofname.Text);
                cmd3.Parameters.AddWithValue("doLName", dolname.Text);
                cmd3.Parameters.AddWithValue("@do_spID", dosp1.SelectedValue);
                cmd3.Parameters.AddWithValue("@doPhone", dophone.Text);
                cmd3.Parameters.AddWithValue("@doHomePhone", dohomephone.Text);
                cmd3.Parameters.AddWithValue("doMobile", domobile.Text);

                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
            catch(SqlException ex) {  MessageBox.Show(ex.Message, "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            } 
       
            d1 = new DataTable();
            da = new SqlDataAdapter("select * from Doctor ", con);
            da.Fill(d1);

            dataGridView1.DataSource = d1;

            
        
        }

        private void edite_Click(object sender, EventArgs e)
        {try {
            string m = "UPDATE Doctor SET doFName ='"+dofname.Text+"',doLName='"+dolname.Text+"',do_spID='"+dosp1.SelectedValue+"',doPhone='"+dophone.Text+"',doHomePhone='"+dohomephone.Text+"',doMobile='"+domobile.Text+"' where doID="+doid.Text+"";
           
             cmd3 = new SqlCommand(m, con);
                

                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
            catch(SqlException ex) {  MessageBox.Show(ex.Message, "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            } d1 = new DataTable();
        da = new SqlDataAdapter("select * from Doctor", con);
        da.Fill(d1);

        dataGridView1.DataSource = d1;
            
        }
     
          // 

        

        private void btndel_Click(object sender, EventArgs e)
        {  
            
            try
            {
                string sql1 = "Delete From Doctor where doid='" + doid.Text + "'";
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

            } d1 = new DataTable();
            da = new SqlDataAdapter("select * from Doctor", con);
            da.Fill(d1);
           
            dataGridView1.DataSource = d1;
        }
        private void butnew_Click(object sender, EventArgs e)
        {
            doid.Text = "";
            dofname.Text = "";
            dolname.Text = "";
            dosp1.Text = ""; ;
            dohomephone.Text = "";
            dophone.Text = "";
            domobile.Text = "";

            dofname.Focus();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            doid.Visible = false;
            d1 = new DataTable();
            SqlDataAdapter da_sp = new SqlDataAdapter(" select * from Specialization  ", con);
            da_sp.Fill(d1);
          
            dosp1.DataSource = d1;
         dosp1.ValueMember = "spID";
           dosp1.DisplayMember = "spName"; 


           dataGridView1.Columns["doID"].HeaderText = "رقم الطبيب";
           dataGridView1.Columns["doFName"].HeaderText = "الاسم";
           dataGridView1.Columns["dolName"].HeaderText = "الكنية";
           dataGridView1.Columns["do_spID"].HeaderText = "الاختصاص";
           dataGridView1.Columns["doPhone"].HeaderText = "الهاتف";
           dataGridView1.Columns["doHomePhone"].HeaderText = "هاتف المنزل";
           dataGridView1.Columns["doMobile"].HeaderText = "الموبايل";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            d1 = new DataTable();
            da = new SqlDataAdapter("select * from Doctor where doFName+doLName like'%"+textBox1.Text+"%'", con);
            da.Fill(d1);
            dataGridView1.DataSource = d1;
            if (dataGridView1.CurrentRow != null)
            {
                doid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
              
                dofname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dolname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dosp1.SelectedValue= dataGridView1.CurrentRow.Cells[3].Value.ToString();

                dophone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dohomephone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                domobile.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                doid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                dofname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dolname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dosp1.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                dophone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dohomephone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                domobile.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            }
        }

      
       

     

       
       
        }
    }


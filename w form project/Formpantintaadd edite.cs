using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace w_form_project
{
    public partial class Formpantintaadd_edite : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");
      
    SqlCommand cmd3;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public Formpantintaadd_edite()
        {
            InitializeComponent();


            da = new SqlDataAdapter("select * from Patient", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
          


            /////
            dataGridView1.Columns["paID"].HeaderText = "رقم المريض";
            dataGridView1.Columns["paFName"].HeaderText = "اسم المريض";
            dataGridView1.Columns["paLName"].HeaderText = "الكنية";
            dataGridView1.Columns["paAddress"].HeaderText = "العنوان";
            dataGridView1.Columns["paJob"].HeaderText = "العمل";
            dataGridView1.Columns["pa_soID"].Visible = false;
            dataGridView1.Columns["paSmoke"].HeaderText = "هل المريض مدخن";
            dataGridView1.Columns["paPhone"].HeaderText = "الهاتف";
            dataGridView1.Columns["paMobile"].HeaderText = "الموبايل";
            dataGridView1.Columns["paGender"].Visible = false;
            dataGridView1.Columns["paBirthDate"].HeaderText = "تاريخ الميلاد";
            dataGridView1.Columns["paNotes"].HeaderText = "ملاحظات";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

           
        }

        private void butaddnew_Click(object sender, EventArgs e)
        {
            patNum.Text = "";
            patFname.Text = "";
            patLname.Text = "";
            patsoid.Text = "";
            patphone.Text = "";
            patMobile.Text = "";
            patjob.Text = "";
            patgender.Text = "";
            patbirthdate.Text = "";
            panote.Text = "";
            pataddrees.Text = "";
            patFname.Focus();

        }

        private void butedite_Click(object sender, EventArgs e)
        {
            try
            {
                string m = "UPDATE patient SET paFName ='" + patFname.Text + "',paLName='" + patLname.Text + "',paAddress='" + pataddrees.Text + "',paJob='" + patjob.Text + "',pa_soID='" + patsoid.SelectedValue + "',paSmoke='" + patsmok.Checked + "',paPhone='" + patphone.Text + "',paMobile='" + patMobile.Text + "',paGender='" + patgender.SelectedValue + "',paBirthDate='" + patbirthdate.Text + "',paNotes='" + panote.Text + "' where paID=" + patNum.Text + "";

                cmd3 = new SqlCommand(m, con);


                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            } dt = new DataTable();
            da = new SqlDataAdapter("select * from Patient", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void butdelete_Click(object sender, EventArgs e)
        {
           
            try
            {
                string sql1 = "Delete From Patient where paID='" + patNum.Text + "'";
                cmd3 = new SqlCommand(sql1, con);
                con.Open();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
                dt = new DataTable();
                da = new SqlDataAdapter("select * from Patient", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            } 
        }

        private void butadd_Click(object sender, EventArgs e)
        { 
            try{
                
   string sql = "insert into Patient values(@paFName,@paLName,@paAddress,@paJob,@pa_soID,@paSmoke,@paPhone,@paMobile,@paGender,@paBirthDate,@paNotes)";
                SqlCommand cmd3 = new SqlCommand(sql, con);
               // cmd3.Parameters.AddWithValue("@paID", patNum.Text);
                cmd3.Parameters.AddWithValue("@paFName", patFname.Text);
                cmd3.Parameters.AddWithValue("@paLName", patLname.Text);

                cmd3.Parameters.AddWithValue("@paAddress", pataddrees.Text);
                cmd3.Parameters.AddWithValue("@paJob", patjob.Text);
                cmd3.Parameters.AddWithValue("@pa_soID", patsoid.SelectedValue);
                cmd3.Parameters.AddWithValue("@paSmoke", patsmok.Checked);
                cmd3.Parameters.AddWithValue("@paPhone", patphone.Text);
                cmd3.Parameters.AddWithValue("@paMobile", patMobile.Text);
                cmd3.Parameters.AddWithValue("@paGender", patgender.SelectedValue);
                cmd3.Parameters.AddWithValue("@paBirthDate", patbirthdate.Text);
                cmd3.Parameters.AddWithValue("@paNotes", panote.Text);
          
            
            con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "add", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();
            } dt = new DataTable();
            da = new SqlDataAdapter("select * from Patient", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void Formpantintaadd_edite_Load(object sender, EventArgs e)
        {
            patNum.Visible = false;
            label1.Visible = false;
            dt = new DataTable();
            SqlDataAdapter da_sp = new SqlDataAdapter(" SELECT * FROm gender ", con);
            da_sp.Fill(dt);

            patgender.DataSource = dt;
            patgender.ValueMember = "geID";
            patgender.DisplayMember = "geName";
                  dt = new DataTable();
                  SqlDataAdapter da_so = new SqlDataAdapter(" SELECT * FROM Social order by soName", con);
                da_so.Fill(dt);

                patsoid.DataSource = dt;
                patsoid.ValueMember = "soID";
                patsoid.DisplayMember = "soName";
        
        }

        private void patFname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            da = new SqlDataAdapter("select * from Patient where PaFName+PaLName like'%" + textBox1.Text + "%'", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dataGridView1.CurrentRow != null)
            {
                patNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                patFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                patLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                pataddrees.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                patjob.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                patsoid.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                patsmok.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                patphone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
           
                patMobile.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
               patgender.SelectedValue = dataGridView1.CurrentRow.Cells[9].Value.ToString();
               
               
               patbirthdate.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
               panote.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
               
            }
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                patNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                patFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                patLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                pataddrees.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                patjob.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                patsoid.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                patsmok.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                patphone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                patMobile.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                patgender.SelectedValue = dataGridView1.CurrentRow.Cells[9].Value.ToString();
              
                patbirthdate.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                panote.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formBook fb = new formBook();
            fb.ShowDialog();
        }

      


    }
}
    


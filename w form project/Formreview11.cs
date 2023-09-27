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
    public partial class Formreview11 : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");
     
      
        SqlDataAdapter da;


        DataTable dt = new DataTable();

        public Formreview11()
        {
            InitializeComponent();



            da = new SqlDataAdapter("select * from viewReview ", con);
            da.Fill(dt);
            
           
            dgv.DataSource = dt;
            dgv.Columns["reID"].Visible = false;
            dgv.Columns["spID"].Visible = false;
            dgv.Columns["doID"].Visible = false;
            dgv.Columns["reDate"].HeaderText = "التاريخ";
            dgv.Columns["reValue"].HeaderText = "قيمة المعاينة";
            dgv.Columns["reCutof"].HeaderText = "الحسم";
            dgv.Columns["ptName"].HeaderText = "طريقة الدفع";
            dgv.Columns["paName"].HeaderText = "المريض";
            dgv.Columns["spName"].HeaderText = "العيادة";
            dgv.Columns["doName"].HeaderText = "الطبيب";


        }
      

     
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0)
            {
                MessageBox.Show("يجب تحديد معاينة للانتقال إلى تفاصيلها", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int r_index = dgv.SelectedCells[0].RowIndex;

            string str_ID = dgv["reID", r_index].Value.ToString();
            FormREVIEW frm = new FormREVIEW(int.Parse(str_ID));
     

            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
              if (dgv.SelectedCells.Count == 0)
            {
                MessageBox.Show("يجب تحديد معاينة لحذفها", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int r_index = dgv.SelectedCells[0].RowIndex;


            string cmd_txt = "DELETE FROM review WHERE reID = " + dgv["reID", r_index].Value.ToString();
            SqlCommand cmd = new SqlCommand(cmd_txt,con);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحذف بنجاح");
            }
            catch (Exception ex)
             {  MessageBox.Show(ex.Message, "add", MessageBoxButtons.OK, MessageBoxIcon.Error); 
               
          
            }
            dt = new DataTable();
            da = new SqlDataAdapter("select * from viewReview ", con);
            da.Fill(dt);


            dgv.DataSource = dt;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            da = new SqlDataAdapter("select * from viewReview  where paName+doName+spName like'%" + textBox1.Text + "%'", con);
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        private void Formreview11_Load(object sender, EventArgs e)
        {
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            int r_index = dgv.SelectedCells[0].RowIndex;
            da = new SqlDataAdapter("select diaID,diName from Disease,Diagnosis where diID=dia_diID and dia_reID= " + dgv["reID", r_index].Value.ToString(), con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1. SelectedCells.Count == 0)
            {
                MessageBox.Show("يجب تحديد مرض لحذفه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int r_index = dataGridView1. SelectedCells[0].RowIndex;


            string cmd_txt = "DELETE FROM Diagnosis WHERE diaID = " + dataGridView1["diaID", r_index].Value.ToString();
            SqlCommand cmd = new SqlCommand(cmd_txt, con);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحذف بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "add", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            int r_index = dgv.SelectedCells[0].RowIndex;
            da = new SqlDataAdapter(" select  * from Recipe ,Drug where rec_drID= drID  and rec_reID= " + dgv["reID", r_index].Value.ToString(), con);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
           
            dataGridView2.Columns["rec_drID"].Visible = false;
            dataGridView2.Columns["rec_reID"].Visible = false;
            dataGridView2.Columns["drID"].Visible = false;




        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count == 0)
            {
                MessageBox.Show("يجب تحديد دواء لحذفه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int r_index = dataGridView2.SelectedCells[0].RowIndex;


            string cmd_txt = "DELETE FROM Recipe WHERE recID= " + dataGridView2["recID", r_index].Value.ToString();
            SqlCommand cmd = new SqlCommand(cmd_txt, con);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحذف بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "add", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            int r_index = dgv.SelectedCells[0].RowIndex;
            da = new SqlDataAdapter(" select  * from ReviewAnalysis ,Analysis where ra_anID=anID and ra_reID=" + dgv["reID", r_index].Value.ToString(), con);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
           dataGridView3. Columns["ra_reID"].Visible = false;
           dataGridView3.Columns["ra_anID"].Visible = false;
           dataGridView3.Columns["anID"].Visible = false;

        //   dataGridView3.Columns["raData"].HeaderText = "التاريخ ";
        //   dataGridView3.Columns["raAnalysisResult"].HeaderText = " نتيجة التحليل";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedCells.Count == 0)
            {
                MessageBox.Show("يجب تحديد تحليل لحذفه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int r_index = dataGridView3.SelectedCells[0].RowIndex;


            string cmd_txt = "DELETE FROM ReviewAnalysis WHERE raID= " + dataGridView3["raID", r_index].Value.ToString();
            SqlCommand cmd = new SqlCommand(cmd_txt, con);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحذف بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "add", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

    }
}
         
      
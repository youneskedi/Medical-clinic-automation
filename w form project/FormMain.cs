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
    public partial class FormMain : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");



        SqlDataAdapter da;

        DataTable dt = new DataTable();
        public FormMain()
        {
            InitializeComponent();
            string sql = " SELECT reDone,Patient.paFName ,Patient.paLName,Review.reID,Specialization.spName, rebookDate,ReviewType.rtName,Review.reNotes from Review,Patient,Specialization,ReviewType where Review.re_paID=Patient.paID and Review.re_paID=Patient.paID  and    Review.re_spID=Specialization.spID and Review.re_rtID=ReviewType.rtID and reDone=0 order by rebookDate ";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);



            dataGridView1.DataSource = dt;
            dataGridView1.Columns["paFName"].HeaderText = "الاسم";
            dataGridView1.Columns["paLName"].HeaderText = "الكنية";

            dataGridView1.Columns["rebookDate"].HeaderText = "وقت الحجز";

            dataGridView1.Columns["spName"].HeaderText = "العيادة";
            dataGridView1.Columns["rtName"].HeaderText = "نوع الكشف";
            dataGridView1.Columns["reNotes"].HeaderText = "ملاحظات";

            dataGridView1.Columns["reID"].Visible = false;
            dataGridView1.Columns["reDone"].Visible = false;
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("يجب تحديد مريض لإجراء المعاية له", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int r_index = dataGridView1.SelectedCells[0].RowIndex;

            string str = dataGridView1["reID", r_index].Value.ToString();

            FormREVIEW frm = new FormREVIEW(int.Parse(str));
            frm.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("يجب تحديد مريض لإلغاء الححجز", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("هل أنت متاكد من إلغاء حجز المريض المحدد", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            int r_index = dataGridView1.SelectedCells[0].RowIndex;
            string str_ID = dataGridView1["reID", r_index].Value.ToString();

            string smd_txt = " delete  from Review  WHERE reID = " + str_ID;
            SqlCommand cmd = new SqlCommand(smd_txt, con);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("تمت الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error); }



            finally
            {
                con.Close();
            }// string sql = " SELECT reDone,Patient.paFName ,Patient.paLName,Review.reID,Specialization.spName, rebookDate,ReviewType.rtName,Review.reNotes from Review,Patient,Specialization,ReviewType where Review.re_paID=Patient.paID and Review.re_paID=Patient.paID  and    Review.re_spID=Specialization.spID and Review.re_rtID=ReviewType.rtID and reDone=0 order by rebookDate ";
           // da = new SqlDataAdapter(sql, con);
           // da.Fill(dt);



           // dataGridView1.DataSource = dt;

        }



        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            formBook f12 = new formBook();
            f12.ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Form1 f9 = new Form1();
            f9.ShowDialog();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Formpantintaadd_edite f10 = new Formpantintaadd_edite();
            f10.ShowDialog();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            Formreview11 f13 = new Formreview11();
            f13.ShowDialog();
        }

        private void toolStripButton10_Click_1(object sender, EventArgs e)
        {
            Formpantintaadd_edite f10 = new Formpantintaadd_edite();
            f10.ShowDialog();
        }

        private void toolStripButton13_Click_1(object sender, EventArgs e)
        {
              Formreview11 f13 = new Formreview11();
              f13.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormDark d = new FormDark();
            d.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormAnaL a = new FormAnaL();
            a.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
          Formreviewtype p= new Formreviewtype();
            p.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Formspla s = new Formspla();
            s.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Formdisen d1 = new Formdisen();
            d1.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

           
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = " SELECT reDone,Patient.paFName ,Patient.paLName,Review.reID,Specialization.spName, rebookDate,ReviewType.rtName,Review.reNotes from Review,Patient,Specialization,ReviewType where Review.re_paID=Patient.paID and Review.re_paID=Patient.paID  and    Review.re_spID=Specialization.spID and Review.re_rtID=ReviewType.rtID and reDone=0 order by rebookDate ";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);



            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            string sql = " SELECT reDone,Patient.paFName ,Patient.paLName,Review.reID,Specialization.spName, rebookDate,ReviewType.rtName,Review.reNotes from Review,Patient,Specialization,ReviewType where Review.re_paID=Patient.paID and Review.re_paID=Patient.paID  and    Review.re_spID=Specialization.spID and Review.re_rtID=ReviewType.rtID and reDone=0 order by rebookDate ";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("تم تحديث البيانات","",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Formlorestart fl1 = new Formlorestart();
            fl1.Show();
        }

      

    }
}
      
        
    


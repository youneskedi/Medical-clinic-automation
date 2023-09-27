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
    public partial class FormREVIEW : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");
        CurrencyManager cm;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommandBuilder cmdb;
      
        DataTable d1 = new DataTable();

        public FormREVIEW(int id)
        {
            InitializeComponent();

            ID = id;
         
        
            cm = (CurrencyManager)this.BindingContext[d1];
           
           
           

            
            da = new SqlDataAdapter("select * from Review where reID="+ID, con);
           
            da.Fill(d1);
            try
            {
                re_paID.DataBindings.Add(new Binding("SelectedValue", d1, "re_paID", true));
                rebookDate.DataBindings.Add(new Binding("Value", d1, "rebookDate", true));
                re_spID.DataBindings.Add(new Binding("SelectedValue", d1, "re_spID", true));
                re_rtID.DataBindings.Add(new Binding("SelectedValue", d1, "re_rtID", true));
                reNotes.DataBindings.Add(new Binding("Text", d1, "reNotes", true));
                re_doID.DataBindings.Add(new Binding("SelectedValue", d1, "re_doID", true));
                reDate.DataBindings.Add(new Binding("Value", d1, "reDate", true));
                re_ptID.DataBindings.Add(new Binding("SelectedValue", d1, "re_ptID", true));
                reValue.DataBindings.Add(new Binding("Text", d1, "reValue", true));
                reCutof.DataBindings.Add(new Binding("Text", d1, "reCutof", true));
                textdone.DataBindings.Add(new Binding("Text", d1, "reDone", true));
            }
            catch  (SqlException ex) { MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally { cm.EndCurrentEdit(); }
            /////////////////////////////////////////////////////////////////

        } int ID;
           
            
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            cm.EndCurrentEdit();

            cmdb = new SqlCommandBuilder(da);
            try
            {
                da.Update(d1);
                cm.Refresh();
                MessageBox.Show("تم الحفظ", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
              
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { cm.EndCurrentEdit(); }


        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "insert into ReviewAnalysis values (@ra_reID,@ra_anID,@raAnalysisResult,@raDate )";
            SqlCommand cmd3 = new SqlCommand(sql, con);
            try
            {
                cmd3.Parameters.Add("@ra_reID", textBox1.Text);
                cmd3.Parameters.Add("@ra_anID", ra_anID.SelectedValue);
                cmd3.Parameters.AddWithValue("@raAnalysisResult", raAnalysisResult.Text);
                cmd3.Parameters.AddWithValue("@raDate", reDate.Value);
                
                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ","اضافة",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
         
            finally
            {
                con.Close();

            }

            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            string sql = "insert into  Recipe values (@rec_reID,@rec_drID,@recAmmount )";
            SqlCommand cmd3 = new SqlCommand(sql, con);
            try
            {
                cmd3.Parameters.Add("@rec_reID", textBox1.Text);
                cmd3.Parameters.AddWithValue("@rec_drID", rec_drID.SelectedValue);
                cmd3.Parameters.Add("@recAmmount", recAmmount.Text);
                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("save","save",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            }
            
         
        }

        private void FormREVIEW_Load(object sender, EventArgs e)
        {
            int z = 1;
            textdone.Text = z.ToString();
          
            textBox1.Text = ID.ToString();
            textdone.Visible=false;
            textBox1.Visible = false;
                label19.Visible=false;
                label15.Visible = false;
            DataTable dt = new DataTable();
                

                SqlDataAdapter da_Disease = new SqlDataAdapter(" SELECT * FROM Disease order by diName", con);
                dt = new DataTable();
                da_Disease.Fill(dt);
                combdorc.DataSource = dt;
                combdorc.ValueMember="diID";
                combdorc.DisplayMember="diName";
    
                

                SqlDataAdapter da_Analysis = new SqlDataAdapter(" SELECT * FROM Analysis order by anName", con);
                dt = new DataTable();
                da_Analysis.Fill(dt);
                ra_anID.DataSource = dt;
                ra_anID.ValueMember = "anID";
                ra_anID.DisplayMember = "anName";

                SqlDataAdapter da_Drug = new SqlDataAdapter(" SELECT * FROM Drug order by drID", con);
                dt = new DataTable();
                da_Drug.Fill(dt);
                rec_drID.DataSource = dt;
                rec_drID.ValueMember = "drID";
                rec_drID.DisplayMember = "drName";

                dt = new DataTable();
                string sq = "  select *, paFName+' '+paLName  as paName from Patient,Review where paID=Review.re_paID and reID= "+ID;
                SqlDataAdapter da_Social = new SqlDataAdapter(sq,con);
                    da_Social.Fill(dt);
                re_paID.DataSource = dt;
                re_paID.ValueMember = "paID";
                re_paID.DisplayMember = "paName";
                dt = new DataTable();
                SqlDataAdapter da_Specialization = new SqlDataAdapter(" SELECT * FROM Specialization,Review  where spID=Review.re_spID and Review.reID="+ID, con);
                da_Specialization.Fill(dt);
                re_spID.DataSource = dt;
                re_spID.ValueMember = "spID";
                re_spID.DisplayMember = "spName";
                dt = new DataTable();
                SqlDataAdapter da_ReviewType = new SqlDataAdapter(" SELECT * FROM ReviewType,Review where rtID=Review.re_rtID and Review.reID="+ID, con);
                da_ReviewType.Fill(dt);
                re_rtID.DataSource = dt;
                re_rtID.ValueMember = "rtID";
                re_rtID.DisplayMember = "rtName";
                dt = new DataTable();
                SqlDataAdapter da_Doctor = new SqlDataAdapter(" SELECT  *, doFName +' '+ doLName as doName FROM Doctor order by doFName, doLName", con);
             
                da_Doctor.Fill(dt);
                re_doID.DataSource = dt;
                re_doID.ValueMember = "doID";
                re_doID.DisplayMember = "doName";
                dt = new DataTable();
           
                SqlDataAdapter da_PayType = new SqlDataAdapter(" SELECT * FROM PayType order by ptName", con);
                da_PayType.Fill(dt);
                re_ptID.DataSource = dt;
                re_ptID.ValueMember = "ptID";
                re_ptID.DisplayMember = "ptName";

                ////////// 
               
                //////////////////////// Relation ///////////////////////////////
              
            //===================================

            /////////////////////////////////////////////////////////////////


               }

     

        private void buttadddo_Click(object sender, EventArgs e)
        {
              string sql = "insert into  Recipe values (@rec_reID,@rec_drID,@recAmmount )";
            SqlCommand cmd3 = new SqlCommand(sql, con);
            try
            {
                cmd3.Parameters.Add("@rec_reID", textBox1.Text);
                cmd3.Parameters.AddWithValue("@rec_drID", rec_drID.SelectedValue);
                cmd3.Parameters.Add("@recAmmount", recAmmount.Text);
                con.Open();

                cmd3.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ بنجاح","حفظ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();
            }
            string sql1 ="insert into Diagnosis values (@dia_reID,@dia_diID )";
            SqlCommand cmd32=new SqlCommand(sql1,con);
            try
            {
                cmd32.Parameters.Add("@dia_reID", textBox1.Text);
                cmd32.Parameters.AddWithValue("@dia_diID", combdorc.SelectedValue);
             
                con.Open();

                cmd32.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ ");
            }
            catch(SqlException ex) {  MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                con.Close();

            }

        }

        private void buttanew_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void re_doID_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             listBox1.Items.Add(re_doID.Text);
            listBox1.Items.Add(re_paID.Text);
            listBox1.Items.Add(raDate.Text);
            listBox1.Items.Add(combdorc.Text);
            listBox1.Items.Add(rec_drID.Text);
            listBox1.Items.Add(recAmmount.Text);
            listBox1.Items.Add(ra_anID.Text);
            listBox1.Items.Add(raDate.Text);
            listBox1.Items.Add(raAnalysisResult.Text);
            listBox1.Items.Add(rec_drID.Text);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font f = new Font("anial", 12, FontStyle.Bold); 
            e.Graphics.DrawString("    ( الوصفة الطبية)  " + "   data:  " + reDate.Text, f, Brushes.Red, 20, 10);
            e.Graphics.DrawString("name patient: "+re_paID.Text   +
          "  name doctor:  " + re_doID.Text  + "   Disen :" + combdorc.Text , f, Brushes.Blue, 40,40);
          
            e.Graphics.DrawString("   analise: " + ra_anID.Text, f, Brushes.Green, 40, 60);
            e.Graphics.DrawString("   dark: " + rec_drID.Text + "   Ammount:  " + recAmmount.Text, f, Brushes.Green, 40, 80);
             }
       

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) ;
            { printDocument1.Print(); }
        }

      
        private void button6_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

   

       
        }
    }
       
    


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
    public partial class formBook : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-G8IMPO8;database=y2000;integrated security=true");
        CurrencyManager cm;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        DataTable d1 = new DataTable();
      
        public formBook()
        {
            InitializeComponent();





            cm = (CurrencyManager)this.BindingContext[d1];
         
            da =new SqlDataAdapter("select * from Review where 1<>1", con);

            da.Fill(d1);
         

            try
            {
              
                rebookName.DataBindings.Add(new Binding("SelectedValue", d1, "re_paID", true));
                rebookDate.DataBindings.Add(new Binding("Value", d1, "rebookDate", true));
                respid.DataBindings.Add(new Binding("SelectedValue", d1, "re_spID", true));
                review.DataBindings.Add(new Binding("SelectedValue", d1, "re_rtID", true));
                reNotes.DataBindings.Add(new Binding("Text", d1, "reNotes", true));

               
            }
            catch (SqlException ex) { MessageBox.Show("خطأ اعد المحاولة", "حطأ", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                cm.EndCurrentEdit();
            } 
           

        }


        private void butbook_Click(object sender, EventArgs e)
        {
            cm.EndCurrentEdit();

            cmdb = new SqlCommandBuilder(da);
            try
            {
                da.Update(d1);
                MessageBox.Show("تم الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(" احد المدخلات خطأ اعد المحاولة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                cm.EndCurrentEdit();

            } 

        }
        

        private void butbookdel_Click(object sender, EventArgs e)
        {
            cm.AddNew();
          
        }

        private void formBook_Load(object sender, EventArgs e)
        {

           DataTable dt = new DataTable();
           SqlDataAdapter dapat = new SqlDataAdapter(" SELECT *, paFName+' '+paLName as paName FROM Patient order by paName ", con);

            dapat.Fill(dt);
            rebookName.DataSource = dt;
            rebookName.DisplayMember = "paName";
            rebookName.ValueMember = "paID";

            SqlDataAdapter da_Specialization = new SqlDataAdapter(" SELECT * FROM Specialization order by spName", con);
            dt = new DataTable();
            da_Specialization.Fill(dt);
            respid.DataSource = dt;
            respid.ValueMember = "spID";
            respid.DisplayMember = "spName";


            SqlDataAdapter darefw = new SqlDataAdapter("select * from ReviewType order by rtName", con);
            dt = new DataTable();
            darefw.Fill(dt);
            review.DataSource = dt;
            review.DisplayMember = "rtName";
            review.ValueMember = "rtID";
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

   

       
    }
}

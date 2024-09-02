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
namespace car
{
    public partial class _ُEmployee : Form
    {
        SqlConnection con;
        DataTable dt;
        public _ُEmployee()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-AIJBK5D;Initial Catalog=E-RMODLE;Integrated Security=True");
            dt = new DataTable();
        }

        private void _ُEmployee_Load(object sender, EventArgs e)
        {
            polyee();
        }

        private void polyee()
        {
            SqlDataAdapter ar = new SqlDataAdapter("select*from Employee", con);
            dt.Clear();
            ar.Fill(dt);
            Emp.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            checkconnection();
            SqlCommand cmd = new SqlCommand
                       ("Insert into Employee (Employee_name,Employee_Id,salary,Address,card_number)Values('" + name.Text + "'," + id.Text + "," + sal.Text + ",'" + Add.Text + "'," + number.Text + ")", con);
                
                cmd.ExecuteNonQuery();
          DialogResult r=      MessageBox.Show("تمت الاضافة بنجاح","هل تريد الاضافة فعلا",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
          if (r ==DialogResult.Yes) 
                polyee();
            checkconnection();

            
      
        }
        void checkconnection()
        {
            if (con.State.ToString().ToLower()=="open")
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkconnection();
            SqlCommand cmd = new SqlCommand
           ("Delete from  Employee where Employee_Id='" + id.Text + "'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("تمت الحذف بنجاح");
            polyee();
            checkconnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkconnection();
            SqlCommand com = new SqlCommand
                ("Update Employee set Employee_name='" + name.Text + "',Employee_id='" + id.Text + "',salary='" + sal.Text + "',Address='" + Add.Text + "',card_number='" + number.Text + "'", con);
            com.ExecuteNonQuery();
            polyee();
            checkconnection();
        }

        private void panel1_Pain
            (object sender, PaintEventArgs e)
        {

        }
        
        }
    }


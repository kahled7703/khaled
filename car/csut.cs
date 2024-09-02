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
    public partial class csut : Form
    {
        SqlConnection con;
        DataTable dt;
        public csut()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-AIJBK5D;Initial Catalog=E-RMODLE;Integrated Security=True");
            dt = new DataTable();
        }

        private void csut_Load(object sender, EventArgs e)
        {
            csutf(); 
        }

        private void csutf()
        {
            SqlDataAdapter ar = new SqlDataAdapter("select*from Cust1", con);
            dt.Clear();
            ar.Fill(dt);
            csut_.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddData();
            SqlCommand cm = new SqlCommand
                ("Insert into cust1 (cust_name,card_number,Phone_number,Address,cust_id)values('" + name.Text + "' ,"+card.Text+"," + ph.Text + ",'" + Add.Text + "'," + id.Text + ")", con);
            cm.ExecuteNonQuery();
            DialogResult r = MessageBox.Show("تمت الاضافة بنجاح", "هل تريد الاضافة فعلا", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                csutf();

            AddData();

        }
        private void AddData()
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
            AddData();
            SqlCommand cmd = new SqlCommand
             ("Delete from  cust1 where cust_id='" + id.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت الاضافة بنجاح");
            csutf();
            AddData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddData();
            SqlCommand com = new SqlCommand
                ("Update Cust1 set Cust_name='" + name.Text + "',card_number='" + card.Text + "',Phone_number='" + ph.Text + "',Address='" + Add.Text + "',cust_id='" + id.Text + "'", con);
            com.ExecuteNonQuery();
            csutf();

            AddData();
        } 
    }
}

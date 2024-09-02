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
    public partial class car_csut : Form
    {
        SqlConnection con;
        DataTable dt;
        SqlDataReader dr;
        public car_csut()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-AIJBK5D;Initial Catalog=E-RMODLE;Integrated Security=True");
            dt = new DataTable();
        }

        private void car_csut_Load(object sender, EventArgs e)
        {
            csuk();
        }

        private void csuk()
        {
            SqlDataAdapter ar = new SqlDataAdapter("select*from car_cust1", con);
            ar.Fill(dt);
            carsd.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddData();
            SqlCommand com = new SqlCommand
                ("Insert into car_cust1(cust_id,Rent_period,count_before,count_after,price_day)values(" + id.Text + "," + carss.Text + "," + be.Text + "," + of.Text + "," + tade.Text + ")", con);
            com.ExecuteNonQuery();
            DialogResult r = MessageBox.Show("تمت الاضافة بنجاح", "هل تريد الاضافة فعلا", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                csuk();
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
             ("Delete from  car_cust1 where cust_id='" + id.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت الحذف بنجاح");
            csuk();
            AddData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddData();
            SqlCommand com = new SqlCommand
                ("Update car_cust1 set cust_id='" + id.Text + "',Rent_period='" + carss.Text + "',count_before='" + be.Text + "',count_after='" + of.Text + "',price_day='" + tade.Text + "'", con);
            com.ExecuteNonQuery();
            csuk();

            AddData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddData();
            SqlCommand cmd = new SqlCommand
             ("select Rent_period,count_before,count_after,price_day from Car_cust1 where cust_id ='" + id.Text + "'", con);
            dr = cmd.ExecuteReader();

            dr.Read();
            carss.Text = dr["Rent_period"].ToString();
            //  ple.Text = dr["Car_plete"].ToString();
            be.Text = dr["count_before,count"].ToString();
            of.Text = dr["count_after"].ToString();
            tade.Text = dr["price_day "].ToString();
           // model.Text = dr["Car_model"].ToString();
           // col.Text = dr["Car_color"].ToString();

            dr.Close();
            csuk();

            AddData();
        }
    }
}

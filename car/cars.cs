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
    public partial class cars : Form
    {
        SqlConnection con;
        DataTable dt;
        SqlDataReader dr;
        
        public cars()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-AIJBK5D;Initial Catalog=E-RMODLE;Integrated Security=True");
            dt = new DataTable();
           
        }

        private void cars_Load(object sender, EventArgs e)
        {
            carsd();
        }
       private void carsd()
        {
            SqlDataAdapter ar = new SqlDataAdapter("select *from Car1", con);
            dt.Clear();
            ar.Fill(dt);
            carTable.DataSource = dt;
        }

       private void btnAdd_Click(object sender, EventArgs e)
       {
           AddData();
           SqlCommand cmd = new SqlCommand
              ("Insert into Car1( Car_plete,Car_name,Car_type,Car_model,Car_color )values("+ple.Text+",'" + name.Text + "','" + tep.Text + "'," + model.Text + ",'" + col.Text + "')", con);
           cmd.ExecuteNonQuery();
         DialogResult r=  MessageBox.Show("هل تريدالاضافة فعلا","تاكيدالاضافة",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
       if(  r== DialogResult.Yes)
           carsd();
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
            ("Delete from  Car1 where Car_plete ='" + ple.Text + "'", con);
           cmd.ExecuteNonQuery();
           MessageBox.Show("تمت عمليةالحذف بنجاح");
           carsd();
           AddData();

       }

       private void button1_Click(object sender, EventArgs e)
       {
           AddData();
           SqlCommand cmd = new SqlCommand
            ("select  Car_plete,Car_name,Car_type,Car_model,Car_color from Car1 where Car_plete ='" + ple.Text + "'", con);
           dr = cmd.ExecuteReader();
           
           dr.Read();
     
         //  ple.Text = dr["Car_plete"].ToString();
          
           name.Text = dr["Car_name"].ToString();
           tep.Text = dr["Car_type"].ToString();
           model.Text = dr["Car_model"].ToString();
           col.Text = dr["Car_color"].ToString();
           
           dr.Close();
           carsd();
           
           AddData();
       }

       private void button3_Click(object sender, EventArgs e)
       {
           AddData();
           SqlCommand com = new SqlCommand
               ("Update Car1 set Car_plete ='" + ple.Text + "',Car_name='" + name.Text + "',Car_type='" + tep.Text + "',Car_model='" + model.Text + "',Car_color='" + col.Text + "'", con);
           com.ExecuteNonQuery();
           carsd();
           AddData();
       }

       
    }
}

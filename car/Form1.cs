using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class Form1 : Form
    {
        string name = "خالد المدار";
        string passa = "770322";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            
            DialogResult r=MessageBox.Show("هل تريد الخروج فعلا","تاكيد الخروج",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
          

            if (r == DialogResult.Yes) 
            this.Close();
           }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txtpassa.UseSystemPasswordChar = false;   
            }
            else if (checkBox1.Checked==false)
            {
                txtpassa.UseSystemPasswordChar = true; 
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Enter();
        }
        private void Enter()
        {
            string username = txtname.Text;
            string userpassa = txtpassa.Text;
            if (username==name)
            {
                if (userpassa==passa)
                {
                    MessageBox.Show(" مرحبابك في معرض سيارات", "نظام", MessageBoxButtons.OK);
                    Form2 g = new Form2();
                    g.Show();
                   
                }
                else
                {
                    MessageBox.Show("كلمة السر خطاء");
               txtpassa.Focus();
                    return;
                }

            }
            else
            {
                MessageBox.Show("اسم المستخدم خطاء");
              txtname.Focus();
                return;      
            }
           
        }
        
       
        }
    }


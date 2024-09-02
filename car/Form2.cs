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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       

        private void سياراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cars m = new cars();
            m.Show();

        }

        private void المستأجرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csut cs = new csut();
            cs.Show();
        }

        private void الموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ُEmployee Em = new _ُEmployee();
            Em.Show();
        }

        private void عقدالتأجيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            car_csut ct = new car_csut();
            ct.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }   
        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void حولالنظامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            حول_النظامcs c = new حول_النظامcs();
            c.ShowDialog();
        }

       
    }
}

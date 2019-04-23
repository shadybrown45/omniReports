using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Form2 Login_btn = new Form2();
            Login_btn.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Students_btn(object sender, EventArgs e)
        {
            students Students_btn = new students();
            Students_btn.Show();
        }

        private void report_btn(object sender, EventArgs e)
        {
            report report_btn = new report();
            report_btn.Show();
        }

       
        private void teach_btn(object sender, EventArgs e)
        {
            teachers teach_btn = new teachers();
            teach_btn.Show();
        }
    }
}

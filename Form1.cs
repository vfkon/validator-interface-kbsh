using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            IsMdiContainer = true;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                buy_select_station frm = new buy_select_station();
               //frm.MdiParent = this;
              //this.Hide();
              frm.Show();
            }
            catch
            {
                error_fetch frm_error = new error_fetch();
                frm_error.Show();
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Form1 mainForm = new Form1();
                schedule frm = new schedule();
                //frm.MdiParent = this;
                this.Hide();
                frm.Show();
            }
            catch
            {
                error_fetch frm_error = new error_fetch();
                frm_error.Show();
            }
}

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss \t dd-MM");
        }
    }
}

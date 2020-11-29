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
    public partial class continue_dialog : Form
    {
        public continue_dialog(finalize_puchase handle)
        {
            InitializeComponent();
            parent = handle;
        }
        finalize_puchase parent;
        private void timeout_timer_Tick(object sender, EventArgs e)
        {
            timeout_timer.Interval = 60000;
            timeout_timer.Start();
            timer_string.Text= timeout_timer.Interval.ToString();
            if(timeout_timer.Interval == 0)
            {
                Form1 frm = new Form1();
                parent.Close();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_back_lgoti_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            parent.Close();
            Close();
        }
    }
}

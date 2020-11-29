using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class lgoti_est : Form
    {
        public lgoti_est()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("buf.txt", true))
            {
                sw.WriteLine(" 2");
            }
            finalize_puchase frm = new finalize_puchase();

            frm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("buf.txt", true))
            {
                sw.WriteLine(" 1");
            }
            finalize_puchase frm = new finalize_puchase();

            frm.Show();
            Close();
        }
    }
}

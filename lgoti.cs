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
    public partial class lgoti : Form
    {
        public lgoti()
        {
            InitializeComponent();
        }

        private void button_back_lgoti_Click(object sender, EventArgs e)
        {
            buy_select_station frm = new buy_select_station();
            frm.Show();
            Close();
        }

        private void button_lgoti_no_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("buf.txt", true))
            {
                sw.WriteLine(" 0");
            }
            finalize_puchase frm = new finalize_puchase();
            frm.Show();
            Close();
        }

        private void button_lgoti_yes_Click(object sender, EventArgs e)
        {
            lgoti_est frm = new lgoti_est();
            frm.Show();
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class finalize_puchase : Form
    {
        string a = "75";
        ComPort com = new ComPort();
        public finalize_puchase()
        {
            InitializeComponent();
            label4.Visible = false;
            label3.Text = a + " руб.";
        }

        private void paymentSuccsess()
        {
            ComPort com = new ComPort();
            if (com.waitForPayment())
            {
                Thread.Sleep(3000);

                final_page frm = new final_page();
                frm.Show();
                Close();
            }
        }
        private void button_card_Click(object sender, EventArgs e)
        {
            
            com.writePrice(a, '0');
            final_page frm = new final_page();
            frm.Show();
            Close();
        }

        private void button_paper_Click(object sender, EventArgs e)
        {
            if(com.writePrice(a, '1'))
            {
                label4.Visible = true;
                paymentSuccsess();
            }
        }

        private void button_back_finalize_Click(object sender, EventArgs e)
        {
            lgoti frm = new lgoti();
            frm.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timeout_payment_Tick(object sender, EventArgs e)
        {
            timeout_payment.Interval = 60000;
            timeout_payment.Start();
            if (timeout_payment.Interval == 0)
            {
                continue_dialog frm = new continue_dialog(this);
                frm.Show();
            }
        }
    }
}

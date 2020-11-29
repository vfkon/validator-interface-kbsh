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
    public partial class final_page : Form
    {
        public final_page()
        {
            InitializeComponent();
            ComPort com = new ComPort();
            mongoImport.setTicketDocumentsAsync(mongoImport.initMongoTicketCollection());
            //com.sendData();
            label_thankyou.Visible = true;
        }


        private void final_page_Click(object sender, EventArgs e)
        {
            //label_checkout.Visible = false;
            //label_thankyou.Visible = true;
        }

        private void label_thankyou_Click(object sender, EventArgs e)
        {
            //Close();
        }

        private void button_back_final_page_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Close();
        }

    }
}

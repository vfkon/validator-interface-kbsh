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
    public partial class buy_select_station : Form
    {
            List<stations> list = mongoExport.getStationDocumentsAsync(mongoExport.initMongoStationCollection()).GetAwaiter().GetResult();
     public buy_select_station()
        {
            InitializeComponent();
            for (int i = 0; i < list.Count; i++)
            {
                comboBox1.Items.Add(list.ElementAt(i).Station.ToString());
            }
            
            label1.Text = "";
            using (StreamWriter sw = new StreamWriter("buf.txt", false))
            {
                sw.Write("1 ");
            }
        }
        private void button_back_to_main_2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string id = "0";
                using (StreamWriter sw = new StreamWriter("buf.txt", true))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list.ElementAt(i).Station.Equals(comboBox1.SelectedItem.ToString()))
                            id = list.ElementAt(i).station_id;
                    }
                    sw.Write(id);
                }
                lgoti frm = new lgoti();
                frm.Show();
                Close();
            }
            else
            {
                label1.Text = "Выберете станцию прибытия";
            }
        }


        private void button_paper_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

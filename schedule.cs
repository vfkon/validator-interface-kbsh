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
    public partial class schedule : Form
    {
        List<stations> list = mongoExport.getStationDocumentsAsync(mongoExport.initMongoStationCollection()).GetAwaiter().GetResult();
        List<trains> list2 = mongoExport.getTrainDocumentsAsync(mongoExport.initMongoTrainsCollection()).GetAwaiter().GetResult();
        public schedule()
        {
            InitializeComponent();
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).station_id.Equals(list2.ElementAt(0).arrive_id))
                    label5.Text = list.ElementAt(i).Station;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).station_id.Equals(list2.ElementAt(1).arrive_id))
                    label6.Text = list.ElementAt(i).Station;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).station_id.Equals(list2.ElementAt(2).arrive_id))
                    label7.Text = list.ElementAt(i).Station;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).station_id.Equals(list2.ElementAt(3).arrive_id))
                    label8.Text = list.ElementAt(i).Station;
            }

            label9.Text = list2.ElementAt(0).time;
            label10.Text = list2.ElementAt(1).time;
            label11.Text = list2.ElementAt(2).time;
            label12.Text = list2.ElementAt(3).time;

            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).station_id.Equals(list2.ElementAt(0).depart_id))
                    label13.Text = list.ElementAt(i).Station;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).station_id.Equals(list2.ElementAt(1).depart_id))
                    label14.Text = list.ElementAt(i).Station;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).station_id.Equals(list2.ElementAt(2).depart_id))
                    label15.Text = list.ElementAt(i).Station;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).station_id.Equals(list2.ElementAt(3).depart_id))
                    label16.Text = list.ElementAt(i).Station;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            //frm.MdiParent = this;
            
            frm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

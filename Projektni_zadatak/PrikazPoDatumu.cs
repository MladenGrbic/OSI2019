using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projektni_zadatak
{
    public partial class PrikazPoDatumu : UserControl
    {
        private static PrikazPoDatumu _instance;
        public static PrikazPoDatumu Instance
        {
            get
            {
                
                _instance = new PrikazPoDatumu();
                return _instance;
            }
        }
        public PrikazPoDatumu()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void funkcija(object sender, MouseEventArgs e)
        {
            ListViewItem itm = List1.SelectedItems[List1.SelectedItems.Count - 1];
            panel1.Controls.Clear();
            panel1.Controls.Add(ocitajDogadjajsaKoment.Instance(itm));
            ocitajDogadjajsaKoment.Instance(itm).Dock = DockStyle.Fill;
            ocitajDogadjajsaKoment.Instance(itm).BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List1.Items.Clear();

            string[] filePaths = Directory.GetFiles(@"Events\", "*.txt", SearchOption.AllDirectories);
            foreach (string fileq in filePaths)
            {

                var tekst = System.IO.File.ReadAllLines(fileq);
                DateTime dT1 = DateTime.Parse(tekst[2]);
                DateTime dT2 = DateTime.Now;
                if (dT1.Date == dT2.Date)
                {
                    List1.Items.Add(new ListViewItem(new[]{
                    tekst[0],
                    tekst[1],
                    tekst[2],
                    tekst[3],
                    tekst[4]
                }));
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List1.Items.Clear();

            string[] filePaths = Directory.GetFiles(@"Events\", "*.txt", SearchOption.AllDirectories);
            foreach (string fileq in filePaths)
            {

                var tekst = System.IO.File.ReadAllLines(fileq);
                DateTime dT1 = DateTime.Parse(tekst[2]);
                DateTime dT2 = DateTime.Now;
                if (dT1.Date > dT2.Date)
                {
                    List1.Items.Add(new ListViewItem(new[]{
                    tekst[0],
                    tekst[1],
                    tekst[2],
                    tekst[3],
                    tekst[4]
                }));
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List1.Items.Clear();

            string[] filePaths = Directory.GetFiles(@"Events\", "*.txt", SearchOption.AllDirectories);
            foreach (string fileq in filePaths)
            {

                var tekst = System.IO.File.ReadAllLines(fileq);
                DateTime dT1 = DateTime.Parse(tekst[2]);
                DateTime dT2 = DateTime.Now;
                if (dT1.Date < dT2.Date)
                {
                    List1.Items.Add(new ListViewItem(new[]{
                    tekst[0],
                    tekst[1],
                    tekst[2],
                    tekst[3],
                    tekst[4]
                }));
                }

            }
        }
    }
}

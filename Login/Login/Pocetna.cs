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

namespace Login
{
    public partial class Pocetna : UserControl
    {
        private static Pocetna _instance;
        public static Pocetna Instance
        {
            get//Kreira novu User Formu
            {
                _instance = new Pocetna();
                return _instance;
            }
        }
        public Pocetna()
        {
            InitializeComponent();
            ReadInList();
        }
        private void ReadInList()
        {//dodavanje dogadjaja iz fajla
            string[] filePaths = Directory.GetFiles(@"Events\", "*.txt", SearchOption.AllDirectories);
            foreach (string fileq in filePaths)
            {
                var tekst = System.IO.File.ReadAllLines(fileq);
                listPrva.Items.Add(new ListViewItem(new[]{
                    tekst[0],
                    tekst[1],
                    tekst[2],
                    tekst[3],
                    tekst[4]
                }));
            }
        }
        private void funkcija(object sender, MouseEventArgs e)
        {
            ListViewItem itm = listPrva.SelectedItems[listPrva.SelectedItems.Count - 1];
            panel1.Controls.Clear();
            panel1.Controls.Add(ocitajDogadjajsaKoment.Instance(itm));
            ocitajDogadjajsaKoment.Instance(itm).Dock = DockStyle.Fill;
            ocitajDogadjajsaKoment.Instance(itm).BringToFront();

        }
    }
}

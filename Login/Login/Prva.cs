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
    public partial class Prva : UserControl
    {
        private static Prva _instance;
        public static Prva Instance
        {
            get
            {
                _instance = new Prva();
                return _instance;
            }
        }
        public Prva()
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
        private void uredi_Click(object sender, EventArgs e)
        {//izmjena dogadjaja
            if (listPrva.SelectedItems.Count > 0)
            {
                
                ListViewItem itm = listPrva.SelectedItems[listPrva.SelectedItems.Count - 1];
                panelpri.Controls.Clear();
                panelpri.Controls.Add(uredidodaj.Instance(itm));
                uredidodaj.Instance(itm).Dock = DockStyle.Fill;
                uredidodaj.Instance(itm).BringToFront();                     
            }
        }
        private void obrisi_Click(object sender, EventArgs e)
        {// brisanje dogadjaja
            if (listPrva.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Da li ste sigurni da želite obrisati?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    for (int i = listPrva.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem itm = listPrva.SelectedItems[i];
                        string str = listPrva.SelectedItems[i].Text;
                        str = str.Replace(" ", String.Empty);
                        File.Delete(@"Events\"+ str + ".txt");
                        listPrva.Items[itm.Index].Remove();
                    }
                }
            }
            
                

        }

        private void funkcija(object sender, MouseEventArgs e)
        {
            ListViewItem itm = listPrva.SelectedItems[listPrva.SelectedItems.Count - 1];
            panelpri.Controls.Clear();
            panelpri.Controls.Add(ocitajDogadjajsaKoment.Instance(itm));
            ocitajDogadjajsaKoment.Instance(itm).Dock = DockStyle.Fill;
            ocitajDogadjajsaKoment.Instance(itm).BringToFront();
            
        }

    }
}

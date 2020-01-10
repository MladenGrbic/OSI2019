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
    public partial class Kategorija : UserControl
    {
        private static Kategorija _instance;
        public static Kategorija Instance
        {
            get
            {
                _instance = new Kategorija();
                return _instance;
            }
        }
        
        public Kategorija()
        {
            InitializeComponent();
            
            string line;

            var sve = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(@"kategorije.txt");
            while ((line = file.ReadLine()) != null)
            {

                Odabir1.Items.Add(line);

            }
            file.Close();


        }
        private void ReadInList()
        {

        }

        private void Odabir1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List1.Items.Clear();
            string[] filePaths = Directory.GetFiles(@"Events\", "*.txt", SearchOption.AllDirectories);
            foreach (string fileq in filePaths)
            {
                var tekst = System.IO.File.ReadAllLines(fileq);
                if (tekst[1] == Odabir1.Text)
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
       
        private void funkcija(object sender, MouseEventArgs e)
        {
            ListViewItem itm = List1.SelectedItems[List1.SelectedItems.Count - 1];
            panel1.Controls.Clear();
            panel1.Controls.Add(ocitajDogadjajsaKoment.Instance(itm));
            ocitajDogadjajsaKoment.Instance(itm).Dock = DockStyle.Fill;
            ocitajDogadjajsaKoment.Instance(itm).BringToFront();
        }
    }
}

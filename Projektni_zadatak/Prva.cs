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
                if (_instance == null)
                    _instance = new Prva();
                return _instance;
            }
        }
        public Prva()
        {
            InitializeComponent();
            ReadInList();
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
            string[] filePaths = Directory.GetFiles(@"Events", "*.txt", SearchOption.AllDirectories);
            foreach (string fileq in filePaths)
            {
                var tekst = System.IO.File.ReadAllLines(fileq);
                List1.Items.Add(new ListViewItem(new[]{
                    tekst[0],
                    tekst[1],
                    tekst[2],
                    tekst[3],
                    tekst[4]
                }));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Odabir1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void Odabir1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

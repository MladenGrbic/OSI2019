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
    public partial class dodizkat : UserControl
    {
        private static dodizkat _instance;
        public static dodizkat Instance
        {
            get//Kreira novu User Formu
            {
                if(_instance==null)
                    _instance = new dodizkat();
                return _instance;
            }
        }
        public dodizkat()
        {
            InitializeComponent();
            ReadInList();
        }

        private void ReadInList()
        {
            string line;
            var sve = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(@"kategorije.txt");
            while ((line = file.ReadLine()) != null)
            {
                sve.Add(line);
            }
            file.Close();
            for (int b=0;b<sve.Count();b++)
            {
                listPrva.Items.Add(new ListViewItem(new[]{
                    sve[b]
                }));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listPrva.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Da li ste sigurni da želite obrisati?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    string tempFile = Path.GetTempFileName();
                    using (var sr = new StreamReader(@"kategorije.txt"))
                    using (var sw = new StreamWriter(tempFile))
                    {
                        string line;
                        for (int i = listPrva.SelectedItems.Count - 1; i >= 0; i--)
                        {
                            ListViewItem itm = listPrva.SelectedItems[i];
                            string str = listPrva.SelectedItems[i].Text;
                            while ((line = sr.ReadLine()) != null)
                            {
                                if (line != str)
                                    sw.WriteLine(line);
                            }
                            listPrva.Items[itm.Index].Remove();
                        }
                    }
                    File.Delete(@"kategorije.txt");
                    File.Move(tempFile, @"kategorije.txt");    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                string sved;
                sved = textBox1.Text;
                using (System.IO.StreamWriter file2 =
                new System.IO.StreamWriter(@"kategorije.txt", true))
                {
                    file2.WriteLine(sved);
                }
                listPrva.Items.Add(new ListViewItem(new[]{
                    sved
                }));
            }
        }
    }
}

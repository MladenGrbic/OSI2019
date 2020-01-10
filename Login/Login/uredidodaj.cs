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
    public partial class uredidodaj : UserControl
    {
        static string stradresa;
        private static uredidodaj _instance;
        public static uredidodaj Instance(ListViewItem a)
        {
            
            {
                _instance = new uredidodaj(a);
                return _instance;
            }
        }
        public uredidodaj(ListViewItem a)
        {//učitava tekst u kockice
            InitializeComponent();
            string str = a.Text;
            string line;
            str = str.Replace(" ", String.Empty);
            stradresa = str;
            var sve = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(@"kategorije.txt");
            while ((line = file.ReadLine()) != null)
            {

                Odabir1.Items.Add(line);

            }
            file.Close();
            var lines = File.ReadAllLines(@"Events\" + str +".txt");
            textBox1.Text = lines[0];
            Odabir1.Text = lines[1];
            textBox3.Text = lines[2];
            textBox4.Text = lines[3];
            textBox5.Text = lines[4];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {//klik na dugme i onda mjenjanje u fajlu
            string line,p;
            int c=0;
            var sve = new List<string>();
            System.IO.StreamReader file =new System.IO.StreamReader(@"Events\" + stradresa + ".txt");
            while ((line = file.ReadLine()) != null)
            {
                sve.Add(line);
                c++;
            }
            file.Close();
            if (sve[0] != textBox1.Text)
            {
                sve[0] = textBox1.Text;
                sve[1] = Odabir1.Text;
                sve[2] = textBox3.Text;
                sve[3] = textBox4.Text;
                sve[4] = textBox5.Text;
                p = sve[0];
                p=p.Replace(" ", String.Empty);
                TextWriter tw = new StreamWriter(@"Events\" + p + ".txt");
                foreach (String s in sve)
                    tw.WriteLine(s);

                tw.Close();
                File.Delete(@"Events\" + stradresa + ".txt");
            }
            else
            {
                sve[1] = Odabir1.Text;
                sve[2] = textBox3.Text;
                sve[3] = textBox4.Text;
                sve[4] = textBox5.Text;
                TextWriter tw = new StreamWriter(@"Events\" + stradresa + ".txt");
                foreach (String s in sve)
                    tw.WriteLine(s);

                tw.Close();
            }
            MessageBox.Show("Uspješno ste izmjenili događaj", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Prva.Instance.BringToFront();
            
        }
    }
}

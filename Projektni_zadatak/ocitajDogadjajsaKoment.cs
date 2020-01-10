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
    public partial class ocitajDogadjajsaKoment : UserControl
    {
        static string strd;
        private static ocitajDogadjajsaKoment _instance;
        public static ocitajDogadjajsaKoment Instance(ListViewItem a)
        {

            {
                _instance = new ocitajDogadjajsaKoment(a);
                return _instance;
            }
        }
        public ocitajDogadjajsaKoment(ListViewItem a)
        {
            InitializeComponent();
            string line;
            int c = 0;
            var sve = new List<string>();
            string str = a.Text;
            str = str.Replace(" ", String.Empty);
            strd = str;
            System.IO.StreamReader file = new System.IO.StreamReader(@"Events\" + str + ".txt");
            while ((line = file.ReadLine()) != null)
            {
                sve.Add(line);
                c++;
            }
            file.Close();

            textBox1.Text = sve[0];
            textBox2.Text = sve[1];
            textBox3.Text = sve[2];
            textBox4.Text = sve[3];
            textBox5.Text = sve[4];
            for (int b = 5; b < sve.Count; b = b + 2)
            {
                    komentari.Items.Add(new ListViewItem(new[]{
                        sve[b],
                        sve[b+1],
                    }));
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox6.Text) && !String.IsNullOrEmpty(textBox7.Text))
            {
                var sved = new List<string>();
                sved.Add(textBox6.Text);
                sved.Add(textBox7.Text);
                int k = komentari.Items.Count;
                if (k == 0)
                {
                    using (System.IO.StreamWriter file2 =
                    new System.IO.StreamWriter(@"Events\" + strd + ".txt", true))
                    {
                        file2.WriteLine("");

                    }
                }
                using (System.IO.StreamWriter file2 =
                new System.IO.StreamWriter(@"Events\" + strd + ".txt", true))
                {
                    file2.WriteLine(sved[0]);
                    file2.WriteLine(sved[1]);
                }
                komentari.Items.Add(new ListViewItem(new[]{
                    sved[0],
                    sved[1],
                }));
            }
        }
    }
}

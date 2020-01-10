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
    public partial class dodajNovi : UserControl
    {
        private static dodajNovi _instance;
        public static dodajNovi Instance
        {
            get
            {
                
                _instance = new dodajNovi();
                return _instance;
            }
        }
        public dodajNovi()
        {
            string line;
            InitializeComponent();
            var sve = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(@"kategorije.txt");
            while ((line = file.ReadLine()) != null)
            {

                Odabir1.Items.Add(line);

            }
            file.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p;
            var sve = new List<string>();
            sve.Add(textBox1.Text);
            sve.Add(Odabir1.Text);
            sve.Add(textBox3.Text);
            sve.Add(textBox4.Text);
            sve.Add(textBox5.Text);
            p = sve[0];
            p = p.Replace(" ", String.Empty);
            TextWriter tw = new StreamWriter(@"Events\" + p + ".txt");
            foreach (String s in sve)
                tw.WriteLine(s);
            tw.Close();
            MessageBox.Show("Uspješno ste dodali događaj", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
        }
    }
}

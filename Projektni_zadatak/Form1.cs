using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projektni_zadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            panel4.Controls.Clear();
            panel4.Controls.Add(Pocetna.Instance);
            Pocetna.Instance.Dock = DockStyle.Fill;
            Pocetna.Instance.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            panel4.Controls.Clear();
            panel4.Controls.Add(Pocetna.Instance);
            Pocetna.Instance.Dock = DockStyle.Fill;
            Pocetna.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            panel4.Controls.Clear();
            panel4.Controls.Add(Kategorija.Instance);
            Kategorija.Instance.Dock = DockStyle.Fill;
            Kategorija.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            panel4.Controls.Clear();
            panel4.Controls.Add(PrikazPoDatumu.Instance);
            PrikazPoDatumu.Instance.Dock = DockStyle.Fill;
            PrikazPoDatumu.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;
            panel4.Controls.Clear();
            panel4.Controls.Add(Aplikacija.Instance);
            Aplikacija.Instance.Dock = DockStyle.Fill;
            Aplikacija.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Height = button5.Height;
            panel3.Top = button5.Top;
            panel4.Controls.Clear();
            panel4.Controls.Add(Kviz_UserControl.Instance);
            Kviz_UserControl.Instance.Dock = DockStyle.Fill;
            Kviz_UserControl.Instance.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

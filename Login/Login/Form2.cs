using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Kutija.Height = button1.Height;
            Kutija.Top = button1.Top;
            prikaznipanel.Controls.Add(Pocetna.Instance);
            Pocetna.Instance.Dock = DockStyle.Fill;
            Pocetna.Instance.BringToFront();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Početna
            prikaznipanel.Controls.Clear();
            Kutija.Height = button1.Height;
            Kutija.Top = button1.Top;
            prikaznipanel.Controls.Add(Pocetna.Instance);
            Pocetna.Instance.Dock = DockStyle.Fill;
            Pocetna.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {//Uredi/izbriši
            prikaznipanel.Controls.Clear();
            Kutija.Height = button4.Height;
            Kutija.Top = button4.Top;
            prikaznipanel.Controls.Add(Prva.Instance);
            Prva.Instance.Dock = DockStyle.Fill;
            Prva.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {//Dodaj događaj
            prikaznipanel.Controls.Clear();
            Kutija.Height = button3.Height;
            Kutija.Top = button3.Top;
            prikaznipanel.Controls.Add(dodajNovi.Instance);
            dodajNovi.Instance.Dock = DockStyle.Fill;
            dodajNovi.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {//Kategorije
            prikaznipanel.Controls.Clear();
            Kutija.Height = button5.Height;
            Kutija.Top = button5.Top;
            prikaznipanel.Controls.Add(dodizkat.Instance);
            dodizkat.Instance.Dock = DockStyle.Fill;
            dodizkat.Instance.BringToFront();
        }

    }
}

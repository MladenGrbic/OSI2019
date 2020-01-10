using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektni_zadatak
{
    public partial class Kviz_UserControl : UserControl
    {
        private string[] linijeFajla;  //Za smjestanje linija ucitanog fajla
        private string tacanOdgovor;  //Za smjestanje tacnog odgovora za svako pitanje u toku igranja kviza
        private int indeksPitanja;  //Za pracenje redoslijeda pitanja
        private int brojTacnihOdgovora;  //Za brojanje tacnih odgovora radi ispisa po zavrsetku kviza

        private static Kviz_UserControl _instance;
        public static Kviz_UserControl Instance
        {
            get
            {
                _instance = new Kviz_UserControl();
                return _instance;
            }
        }

        private void updateQuiz(string[] podaciLinije)  //Sluzi za kretanje kroz pitanja (promjena pitanja i ponudjenih odgovora)
        {
            //Postavljanje svih vrijednosti za trenutnu iteraciju kviza (iteriranje se vrsi odabirom odgovora tj. klikom na bilo koje dugme)
            tacanOdgovor = podaciLinije[4];

            Pitanje.Text = podaciLinije[0];
            Odg1.Text = podaciLinije[1];
            Odg2.Text = podaciLinije[2];
            Odg3.Text = podaciLinije[3];
        }
        private void ispisiRezultat()
        {
            //Ispisuje rezultat po zavrsetku kviza
            double postotak = (double)brojTacnihOdgovora * 10;
            MessageBox.Show(String.Format("Tacno je odgovoreno na {0}% pitanja.", postotak));
        }
        private void resetujKviz()
        {
            //Resetuje kviz i omogucava ponovno igranje
            Pitanje.Hide();
            Odg1.Hide();
            Odg2.Hide();
            Odg3.Hide();

            label1.Show();
            ListaGradova.Show();
            StartKviz.Show();

            indeksPitanja = 0;
            brojTacnihOdgovora = 0;
        }
        private void izvrsiSveFunkcijeDugmeta(Button btn)
        {
            if (indeksPitanja < 10)  //Ako nisu prosla sva pitanja
            {
                if (String.Equals(btn.Text, tacanOdgovor))  //Ako je izabrani odgovor tacan onda se dati brojac uvecava za 1
                {
                    brojTacnihOdgovora++;
                }
                string[] podaciLinije = linijeFajla[++indeksPitanja].Split(new char[1] { ',' });  //Citanje sljedeceg pitanja
                updateQuiz(podaciLinije);
            }
            else  //Ako su prosla sva pitanja
            {
                if (String.Equals(btn.Text, tacanOdgovor))  //Kada prodju sva pitanja provjerava se da li je i odgovor na posljednje pitanje tacan
                {
                    brojTacnihOdgovora++;
                }
                ispisiRezultat();
                resetujKviz();
            }
        }

        public Kviz_UserControl()  //Konstruktor
        {
            InitializeComponent();

            //Prije pocetka kviza, pitanje i odgovori su sakriveni
            Pitanje.Hide();
            Odg1.Hide();
            Odg2.Hide();
            Odg3.Hide();

            indeksPitanja = 0;
            brojTacnihOdgovora = 0;
            linijeFajla = null;
        }

        private void ListaGradova_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartKviz_Click(object sender, EventArgs e)  //Klik na dugme za pocetak kviza
        {
            string grad = (string)ListaGradova.SelectedItem;  //Uzima se ime izabranog grada radi pronalaska fajla iz kojeg ce se citati pitanja

            if (grad != null)
            {
                //Kad kviz pocne, sakrivaju se komponente za odabir grada
                label1.Hide();
                ListaGradova.Hide();
                StartKviz.Hide();

                linijeFajla = System.IO.File.ReadAllLines(@"Gradovi\" + grad + ".txt");  //Citanje fajla i smjestanje linija u dati string (folder Gradovi se nalazi na istom mjestu kao i exe fajl)
                string[] podaciLinije = linijeFajla[++indeksPitanja].Split(new char[1] { ',' });  //Citanje prvog pitanja (++indeksPitanja jer se preskace prva linija fajla koja samo imenuje kolone)

                updateQuiz(podaciLinije);

                //Kviz je zapocet i sada se pojavljuje pitanje zajedno sa ponudjenim odgovorima
                Pitanje.Show();
                Odg1.Show();
                Odg2.Show();
                Odg3.Show();
            }

        }

        private void Pitanje_TextChanged(object sender, EventArgs e)
        {

        }

        private void Odg1_Click(object sender, EventArgs e)  //Klik na prvo dugme
        {
            izvrsiSveFunkcijeDugmeta(Odg1);
        }

        private void Odg2_Click(object sender, EventArgs e)  //Klik na drugo dugme
        {
            izvrsiSveFunkcijeDugmeta(Odg2);
        }

        private void Odg3_Click(object sender, EventArgs e)  //Klik na trece dugme
        {
            izvrsiSveFunkcijeDugmeta(Odg3);
        }

    }
}

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
    
    public partial class Aplikacija : UserControl
    {
        private static Aplikacija _instance;
        public static Aplikacija Instance
        {
            get
            {
                _instance = new Aplikacija();
                return _instance;
            }
        }
        public Aplikacija()
        {
            InitializeComponent();
            string s = File.ReadAllText(@"Informacije.txt");
            tekst.Text = s;

        }
    }
}

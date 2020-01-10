using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        string usp = "Uspjesno ste se prijavili, aplikacija se ucitava", neus="Username/Password nepravilan";

        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            { 
                txtPassword.Text = "Password";
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] lines = File.ReadAllLines(@"UserPass.txt");
            foreach (string linija in lines)
            {
                if (linija.Contains(txtUsername.Text) && linija.Contains(txtPassword.Text))
                {
                    i = 1;
                    var owner = new Form { TopMost = true }; //Automatski gasi svoje
                    Task.Delay(1000).ContinueWith(t => {
                        owner.Invoke(new Action(() =>
                        {
                            if (!owner.IsDisposed)
                            {
                                owner.Close();
                            }
                        }));
                    });
                    var dialogRes =

                    MessageBox.Show(owner, usp, "USPJESNO!");
                    Form2 myForm = new Form2();
                    this.Hide();
                    myForm.ShowDialog();
                    this.Close();
                }
            }
            if (i != 1)
            {
                MessageBox.Show(neus);
            }
        }
    }
}

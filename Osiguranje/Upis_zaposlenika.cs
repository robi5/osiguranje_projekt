using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Osiguranje
{
    public partial class Upis_zaposlenika : Form
    {
        public Upis_zaposlenika()
        {
            InitializeComponent();

            // postavljanje šifre (password-a) na zvjezdice
            textBox5.PasswordChar = '*';
            textBox5.MaxLength = 15;
        }

        // button natrag

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Main_poslovođa().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // provjera je li napisano neki string u SVIM textboxovima 

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if(String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if(String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if(String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            // upis u C# bazu podataka (baza.mdf) 

            else {

            Voditelj a = new Voditelj();
            a.dodaj_zaposlenika(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

            this.Close();
            new Main_poslovođa().Show();

            }
        }
    }
}

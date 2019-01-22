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
    public partial class Upis_klijenta : Form
    {

        public int read;

        public Upis_klijenta(int x)
        {
            InitializeComponent();
            this.read = x;
            
 
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (string.IsNullOrEmpty(comboBox1.Text)) {
                MessageBox.Show("Niste odabrali spol!");
            }


            else
            {
                
                Zaposlenik a = new Zaposlenik();
                a.upis_klijent(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, comboBox1.Text, this.read);


                this.Close();
            }


        }

    
    }
}

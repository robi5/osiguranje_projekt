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
    public partial class dodaj_policu : Form
    {
        public dodaj_policu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(richTextBox2.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(richTextBox3.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(richTextBox4.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else
            {
                Voditelj a = new Voditelj();
                a.dodaj_policu(richTextBox1.Text, richTextBox2.Text, richTextBox3.Text, richTextBox4.Text);

                this.Close();
            }
        }
    }
}

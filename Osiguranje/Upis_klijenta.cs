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
using MaterialSkin;
using MaterialSkin.Controls;

namespace Osiguranje
{
    public partial class Upis_klijenta : MaterialForm
    {

        public int read;

        public Upis_klijenta(int x)
        {
            InitializeComponent();
            this.read = x;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);


        }


        private void materialFlatButton1_Click(object sender, EventArgs e)
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

            else if (String.IsNullOrEmpty(dateTimePicker1.Text))
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

            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Niste odabrali spol!");
            }


            else
            {

                Zaposlenik a = new Zaposlenik();
                a.upis_klijent(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text.ToString(), textBox5.Text, textBox6.Text, textBox7.Text, comboBox1.Text, this.read);


                this.Close();
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

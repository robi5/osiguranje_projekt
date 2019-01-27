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
    public partial class Upis_zaposlenika : MaterialForm
    {
        public Upis_zaposlenika()
        {
            InitializeComponent();

            // postavljanje šifre (password-a) na zvjezdice
            textBox5.PasswordChar = '*';
            textBox5.MaxLength = 15;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);
        }

        // button natrag

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

            else if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }



            else
            {

                Voditelj a = new Voditelj();
                a.dodaj_zaposlenika(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

                this.Close();
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

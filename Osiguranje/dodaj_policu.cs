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
    public partial class dodaj_policu : MaterialForm
    {
        public dodaj_policu()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);
        }

      

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(materialSingleLineTextField1.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(materialSingleLineTextField2.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(materialSingleLineTextField3.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else if (String.IsNullOrEmpty(materialSingleLineTextField4.Text))
            {
                MessageBox.Show("Niste upisali sva polja!");
            }

            else
            {
                Voditelj a = new Voditelj();
                a.dodaj_policu(materialSingleLineTextField1.Text, materialSingleLineTextField2.Text, materialSingleLineTextField3.Text, materialSingleLineTextField4.Text);

                this.Close();
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

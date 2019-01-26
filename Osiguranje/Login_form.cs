using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Osiguranje
{
    public partial class Login_form : MaterialForm 
    {
        public Login_form()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);          
        }


        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Niste odabrali svoju poziciju!");
            }

            else
            {
                if (radioButton1.Checked == true)
                {
                    int id;
                    Login a = new Login();
                    id = a.login_zaposlenik(textBox1.Text, textBox2.Text);

                    if (id == -1)
                    {

                    }

                    else
                    {
                        Zaposlenik x = new Zaposlenik();
                        x.kontrola_prijave(id);
                        new Main_zaposlenik(id).Show();
                        this.Hide();
                    }
                }

                else
                {
                    Login a = new Login();
                    int id = a.login_poslovoda(textBox1.Text, textBox2.Text);

                    if (id == 0)
                    {

                    }

                    else
                    {
                        new Main_poslovođa().Show();
                        this.Hide();
                    }
                }

            }
        }

        
    }
}

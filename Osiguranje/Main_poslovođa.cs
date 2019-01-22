using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Osiguranje
{
    public partial class Main_poslovođa : MaterialForm
    {
        public Main_poslovođa()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Upis_zaposlenika a = new Upis_zaposlenika();
            a.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dodaj_policu a = new dodaj_policu();
            a.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            stats a = new stats();
            a.ShowDialog();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login_form().Show();
        }
    }
}

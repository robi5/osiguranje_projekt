using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Osiguranje
{
    public partial class zaposlenik_control : MaterialForm
    {
        public zaposlenik_control()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zaposlenik_control_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet3.Kontrola' table. You can move, or remove it, as needed.
            this.kontrolaTableAdapter.Fill(this.bazaDataSet3.Kontrola);

        }
    }
}

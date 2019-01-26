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
    public partial class Main_zaposlenik : MaterialForm
    {
        
        private int x;
        

        public Main_zaposlenik(int read)
        {
            
            InitializeComponent();
            this.x= read;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login_form().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Upis_klijenta a = new Upis_klijenta(this.x);
            a.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new search(this.x).Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Zaposlenik x = new Zaposlenik();
            x.kontrola_odjave(this.x);
            this.Close();
            new Login_form().Show();
        }

        private void Main_zaposlenik_Load(object sender, EventArgs e)
        {

        }
    }
}

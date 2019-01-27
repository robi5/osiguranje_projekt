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
    public partial class stats : MaterialForm
    {
        public stats()
        {
            InitializeComponent();
            combo();
            comboBox2.Items.Add("Ukupan broj korisnika police");
            comboBox2.Items.Add("Po spolu");

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);


        }


       

        void combo()
        {
            stats_class xyz = new stats_class();       
            var itemi = xyz.popuni();
            comboBox1.DataSource = itemi;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string x = comboBox2.Text;
            switch (x)
            {
                case "Ukupan broj korisnika police":
                    {
                        prozor_stats kek = new prozor_stats(comboBox1.Text);
                        kek.ShowDialog();
                        break;
                    }

                case "Po spolu":
                    {
                        prozor_stats_spol kek = new prozor_stats_spol(comboBox1.Text);
                        kek.ShowDialog();
                        break;
                    }

                default:
                    {
                        MessageBox.Show("Odaberite kriterij");
                        break;
                    }
            }

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

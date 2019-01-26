using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osiguranje
{
    public partial class stats : Form
    {
        public stats()
        {
            InitializeComponent();
            combo();
            comboBox2.Items.Add("Ukupan broj korisnika police");
            comboBox2.Items.Add("Po spolu");



        }


       

        void combo()
        {
            stats_class xyz = new stats_class();       
            var itemi = xyz.popuni();
            comboBox1.DataSource = itemi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}

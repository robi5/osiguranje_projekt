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
            new Main_poslovođa().Show();  
        }

        private void button2_Click(object sender, EventArgs e)
        {

            prozor_stats kek = new prozor_stats(comboBox1.Text);
            kek.ShowDialog();
            stats_class xyz = new stats_class();

            



        }
    }
}

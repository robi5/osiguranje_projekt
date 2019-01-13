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
    public partial class Main_poslovođa : Form
    {
        public Main_poslovođa()
        {
            InitializeComponent();
        }

        // klikanje na 'upis zaposlenika'

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Upis_zaposlenika().Show();
        }

        // vracanje natrag

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login_poslovođe().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new dodaj_policu().Show();
        }
    }
}

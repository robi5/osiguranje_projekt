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

namespace Osiguranje
{
    public partial class zaposlenik_control : Form
    {
        public zaposlenik_control()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Zaposlenik kek = new Zaposlenik();
            metroGrid1.DataSource = kek.kontrola(materialSingleLineTextField1.Text);
        }
    }
}

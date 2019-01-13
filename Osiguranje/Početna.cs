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
    public partial class Početna : Form
    {
        public Početna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ovisno o odabiru, tj. kliku button se otvaraju novi prozori

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_zaposlenik().Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_poslovođe().Show();
        }
    }
}

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

namespace Osiguranje
{
    public partial class Main_zaposlenik : Form
    {
        
        private int x;
        

        public Main_zaposlenik(int read)
        {
            
            InitializeComponent();
            this.x= read;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Upis_klijenta(this.x).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login_zaposlenik().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new search(this.x).Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Osiguranje
{
    public partial class search : Form
    {

        private int x;
        int a;
        string id;

        public search(int read)
        {
            InitializeComponent();
            this.x = read;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Main_zaposlenik(this.x).Show();
        }

        // upis imena za search

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Niste upisali ime!");
            }

            else
            {
                Zaposlenik c = new Zaposlenik();
                dataGridView1.DataSource = c.search(textBox1.Text);

            }
        }

        // pritisak na cell click i onda ispis u textbox

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ID, Ime, Prezime FROM Klijent WHERE Id = '" + a + "'";
            a = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString());

            Zaposlenik b = new Zaposlenik();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = b.cellclick(a);
           

            foreach (DataRow dr in table.Rows)
            {
                
                id = dr["Id"].ToString();
                textBox3.Text = dr["Ime"].ToString();
                textBox4.Text = dr["Prezime"].ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Niste odabrali klijenta!");
            }

            else
            {
                string a = id;
                string b = textBox3.Text;
                string c = textBox4.Text;
                this.Close();
                new klijent_control(a, b, c, x).Show();

            }
        }
    }
}

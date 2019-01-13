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
    public partial class klijent_control : Form
    {
        // id zaposlenika koji se ulogirao
        private int x;
        //

        //varijabla za id_police
        int id_pol;
        //


        //id klijenta
        string id;
        //

        public klijent_control(string a, string b, string c, int read)
        {
            InitializeComponent();
            id = a;
            textBox2.Text = b;
            textBox3.Text = c;
            this.x = read;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Polica";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Robert\Desktop\projekt_PI\projekt_PI\Projekt\Osiguranje\baza.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter();

            sda.SelectCommand = cmd;
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;


        }

        // klik na ćeliju i prepisivanje u textbox , kasnije upis ako kliknemo 'da'

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Robert\Desktop\projekt_PI\projekt_PI\Projekt\Osiguranje\baza.mdf; Integrated Security = True; Connect Timeout = 30");
            id_pol = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Polica WHERE Id = '" + id_pol + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable table = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(table);
            foreach (DataRow dr in table.Rows)
            {

                textBox4.Text = dr["Tip"].ToString();
                textBox5.Text = dr["Naziv"].ToString();
                textBox6.Text = dr["Vrijednost"].ToString();
                textBox7.Text = dr["Rata"].ToString();

            }

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new search(x).Show();
        }

        //dodavanja police

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Niste odabrali policu!");
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite pridodati policu klijentu?"," ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DateTime time = DateTime.Now;

                    string query = "INSERT INTO Klijent_polica (Id_klijent, Id_pol, Id_zap, Vrijeme) VALUES ('" + id + "', '" + id_pol + "', '" + x + "', '" + time + "')";
                    SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Robert\Desktop\projekt_PI\projekt_PI\Projekt\Osiguranje\baza.mdf; Integrated Security = True; Connect Timeout = 30");
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Pridodana polica klijentu!");
                    this.Close();
                    new search(x).Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
               
            }
        }

        // prikaz tablica klijenata

        private void button1_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT Tip, Naziv, Vrijednost, Rata FROM Polica INNER JOIN Klijent_polica ON Klijent_polica.Id_klijent='" + id + "' AND Polica.Id = Klijent_polica.Id_pol";
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Robert\Desktop\projekt_PI\projekt_PI\Projekt\Osiguranje\baza.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter();

            sda.SelectCommand = cmd;
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView2.DataSource = table;
        }
    }
}

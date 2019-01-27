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
using MaterialSkin;
using MaterialSkin.Controls;

namespace Osiguranje
{
    public partial class klijent_control : MaterialForm
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
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);
        }

 

        // klik na ćeliju i prepisivanje u textbox , kasnije upis ako kliknemo 'da'

        private void metroGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_pol = Convert.ToInt32(metroGrid2.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Polica WHERE Id = '" + id_pol + "'";
            Zaposlenik x = new Zaposlenik();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = x.cellclick_2(id_pol);
          

            foreach (DataRow dr in table.Rows)
            {

                textBox4.Text = dr["Tip"].ToString();
                textBox5.Text = dr["Naziv"].ToString();
                textBox6.Text = dr["Vrijednost"].ToString();
                textBox7.Text = dr["Rata"].ToString();

            }

        }

     
        // prikaz tablica klijenata



        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Zaposlenik x = new Zaposlenik();
            metroGrid2.DataSource = x.klijent_ctrl();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Zaposlenik y = new Zaposlenik();
            metroGrid1.DataSource = y.prikazi_klijent_policu(id);
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Niste odabrali policu!");
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite pridodati policu klijentu?", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    Zaposlenik kek = new Zaposlenik();
                    kek.klijentu_dodaj_policu(this.id, this.id_pol, this.x);

                    this.Close();
                    new search(x).Show();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            new search(x).Show();
        }
    }
}

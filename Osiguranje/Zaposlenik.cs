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
    class Zaposlenik : DB
    {

    

    public void upis_klijent(string a, string b, string c, string d, string e, string f, string g, string h, int x)
        {
            int id = x;
            string ime = a;
            string prezime = b;
            string OIB = c;
            string dat_rod = d;
            string mobitel = e;
            string grad = f;
            string adresa = g;
            string spol = h;
            DateTime now = DateTime.Now;

            string query = "INSERT INTO Klijent (Ime, Prezime, OIB, Dat_rod, Mobitel, Grad, Adresa, Id_zap, Vrijeme, Spol) VALUES ('" + ime + "', '" + prezime + "', '" + OIB + "', '" + dat_rod + "', '" + mobitel + "', '" + grad + "', '" + adresa + "', '" + id + "', '" + now + "', '" + spol + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dodan Klijent!");
            

        }

    public DataTable search(string ime)
        {
            string abc = ime;
            string query = "SELECT ID, Ime, Prezime, Dat_rod, Grad, Adresa, Spol FROM Klijent WHERE Ime='" + abc + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter();

            sda.SelectCommand = cmd;
            DataTable table = new DataTable();
            sda.Fill(table);
            return table;

        }

    public DataTable cellclick(int a)
        {
            int id = a;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ID, Ime, Prezime FROM Klijent WHERE Id = '" + id + "'";
 
            cmd.ExecuteNonQuery();
     
            DataTable table = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(table);
            return table;
        }

    public DataTable klijent_ctrl()
        {
            string query = "SELECT * FROM Polica";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter();

            sda.SelectCommand = cmd;
            DataTable table = new DataTable();
            sda.Fill(table);
            return table;
        }

    public DataTable cellclick_2(int id)
        {
            int id_police = id;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Polica WHERE Id = '" + id_police + "'";

            cmd.ExecuteNonQuery();

            DataTable table = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(table);
            return table;
        }

        public void klijentu_dodaj_policu(string id, int id_pol, int id_zap)
        {
            DateTime time = DateTime.Now;

            string query = "INSERT INTO Klijent_polica (Id_klijent, Id_pol, Id_zap, Vrijeme) VALUES ('" + id + "', '" + id_pol + "', '" + id_zap + "', '" + time + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
 
            MessageBox.Show("Pridodana polica klijentu!");
        }

        public DataTable prikazi_klijent_policu(string id)
        {
            string query = "SELECT Tip, Naziv, Vrijednost, Rata FROM Polica INNER JOIN Klijent_polica ON Klijent_polica.Id_klijent='" + id + "' AND Polica.Id = Klijent_polica.Id_pol";
           
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter();

            sda.SelectCommand = cmd;
            DataTable table = new DataTable();
            sda.Fill(table);

            return table;
        }
    }
}

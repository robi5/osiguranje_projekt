using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Osiguranje
{
    class Voditelj : DB
    {
        
    public void dodaj_policu(string a, string b, string c, string d)
        {
            string tip = a;
            string naziv = b;
            string vrijednost = c;
            string rata = d;
            string query = "INSERT INTO Polica (Tip, Naziv, Vrijednost, Rata) VALUES ('" + tip + "', '" + naziv + "', '" + vrijednost + "', '" + rata + "');";
            SqlCommand cmd = new SqlCommand(query, con);
    
            cmd.ExecuteNonQuery();
  
            MessageBox.Show("Dodana polica!");
            
        }

    public void dodaj_zaposlenika(string a1, string b1, string c1, string d1, string e1)
        {

            string ime = a1;
            string prezime = b1;
            string OIB = c1;
            string username = d1;
            string password = e1;

            string query = "INSERT INTO Zaposlenik (Ime, Prezime, OIB, username, password) VALUES ('" + ime + "', '" + prezime + "', '" + OIB + "', '" + username + "', '" + password + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dodan zaposlenik!");

        }

    }
}

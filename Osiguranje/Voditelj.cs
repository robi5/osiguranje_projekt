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

    }
}

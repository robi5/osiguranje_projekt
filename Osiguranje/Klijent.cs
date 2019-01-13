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
    class Klijent : DB
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

    public void search()
        {

        }

    }
}

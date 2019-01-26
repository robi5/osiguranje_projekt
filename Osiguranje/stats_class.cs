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
    class stats_class : DB
    {
        internal List<string> popuni()
        {
            List<string> items = new List<string>();



            string query = "SELECT Naziv FROM Polica";
            SqlCommand cmd = new SqlCommand(query, con);


            SqlDataReader myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                items.Add(myReader[0].ToString());
            }

            myReader.Close();


            return items;
        }

        public int popuni_grid(string naziv)
        {
            
            string query = "SELECT ID FROM Polica WHERE naziv='" + naziv + "'";
            
            SqlCommand cmd = new SqlCommand(query, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
  
        

            string query1 = "SELECT COUNT(*) FROM Klijent_polica where Id_pol ='" + id + "'";
            int count = 0;

            
                using (SqlCommand cmdCount = new SqlCommand(query1, con))
                {
                    
                    count = (int)cmdCount.ExecuteScalar();
                }
                        
            return count;
        }

        public int popuni_statistiku(string naziv)
        {
            string query = "SELECT ID FROM Polica WHERE naziv='" + naziv + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());



            string query1 = "SELECT COUNT(*) FROM Klijent";
            int count = 0;


            using (SqlCommand cmdCount = new SqlCommand(query1, con))
            {

                count = (int)cmdCount.ExecuteScalar();
            }

            return count;
        }

        public int ukupan_broj_klijent()
        {

            int ukupan;
            string query = "SELECT COUNT(*) FROM Klijent";
            

            using (SqlCommand cmdCount = new SqlCommand(query, con))
            {

                ukupan = (int)cmdCount.ExecuteScalar();
            }



            return ukupan;
        }

        public int ukupan_broj_zensko(string naziv)
        {
            string query1 = "SELECT ID FROM Polica WHERE naziv='" + naziv + "'";

            SqlCommand cmd = new SqlCommand(query1, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            string spol = "Žensko";
            int zensko;

            string query = "SELECT COUNT(*) FROM Klijent_polica INNER JOIN Klijent ON Klijent_polica.Id_klijent = Klijent.Id AND Klijent.Spol = '" + spol + "'";


            using (SqlCommand cmdCount = new SqlCommand(query, con))
            {

                zensko = (int)cmdCount.ExecuteScalar();
            }
                
                return zensko;     
        }

        public int ukupan_broj_musko(string naziv)
        {
            string query1 = "SELECT ID FROM Polica WHERE naziv='" + naziv + "'";

            SqlCommand cmd = new SqlCommand(query1, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            int musko;
            string spol = "Muško";

            string query = "SELECT COUNT(*) FROM Klijent_polica INNER JOIN Klijent ON Klijent_polica.Id_klijent = Klijent.Id AND Klijent.Spol = '" + spol + "'";
            MessageBox.Show(query);

            using (SqlCommand cmdCount = new SqlCommand(query, con))
            {

                musko = (int)cmdCount.ExecuteScalar();
            }
            MessageBox.Show(musko.ToString());
            return musko;
        }
    }
}

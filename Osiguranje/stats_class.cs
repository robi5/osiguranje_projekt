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



            string query1 = "SELECT COUNT(*) FROM Klijent_polica";
            int count = 0;


            using (SqlCommand cmdCount = new SqlCommand(query1, con))
            {

                count = (int)cmdCount.ExecuteScalar();
            }

            return count;
        }

    }
}

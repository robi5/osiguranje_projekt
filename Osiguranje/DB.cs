using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Osiguranje
{
    class DB
    {
        private static DB instance;
        private SqlConnection connection;

        /*

        public static DB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
            return instance;
            }
            
        }

        */

        public SqlConnection con
        {
            get { return connection; }
            private set { connection = value; }
        }

        public DB()
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Robert\Documents\GitHub\osiguranje_projekt\Osiguranje\baza.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(constring);
            con.Open();
        }

        ~DB()
        {
           // if (con.State == System.Data.ConnectionState.Open)
           //    con.Close();
          // con.Dispose();
          // con = null;
        }

        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, con);
            return command.ExecuteReader();
        }
        
        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, con);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, con);
            return command.ExecuteNonQuery();
        }
        
     }
}


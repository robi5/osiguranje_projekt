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
    class Login : DB
    {

    public int login_zaposlenik(string username, string password)
        {          
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Zaposlenik WHERE username='" + username + "' AND password='" + password + "'", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                //selektanje ID zaposlenika koji se ULOGIRAO (treba nam id za kasnije)

                SqlCommand cmd = new SqlCommand("SELECT Id FROM Zaposlenik WHERE username='" + username + "' AND password='" + username + "'", con);
                
                //convertanje upita

                int id = Convert.ToInt32(cmd.ExecuteScalar());
          
                return id;

            }

            else
            {
                
                MessageBox.Show("Wrong username or password!");
                return -1;
            }
 
        }

    public int login_poslovoda(string username, string password)
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Voditelj WHERE username='" + username + "' AND password='" + password + "'", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            // ukoliko postoji otvara sljedeci prozor

            if (dt.Rows[0][0].ToString() == "1")
            {

                return 1;
            }

            else
            {

                MessageBox.Show("Wrong username or password!");
                return 0;

            }
        }

    }
}

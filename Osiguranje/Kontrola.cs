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
    class Kontrola 
    {
        int id;
        int id_zap;
        DateTime vrijeme_prijave;
        DateTime vrijeme_odjave;

    public Kontrola (SqlDataReader dr)
        {
            this.id = int.Parse(dr["Id"].ToString());
            this.id_zap = int.Parse(dr["id_zap"].ToString());
            
            
            if (!(dr["vrijeme_prijave"] is DBNull))
                this.vrijeme_prijave = Convert.ToDateTime(dr["vrijeme_prijave"]);
            if (!(dr["vrijeme_odjave"] is DBNull))
                this.vrijeme_odjave = Convert.ToDateTime(dr["vrijeme_odjave"]);
        }
    }
}

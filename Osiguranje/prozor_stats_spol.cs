using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Osiguranje
{
    public partial class prozor_stats_spol : MaterialForm
    {
        public prozor_stats_spol(string a)
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);

            stats_class xyz = new stats_class();

            this.chart1.Series[0].YValueType = ChartValueType.Int32;
            this.chart1.Series["Broj korisnika"].XValueMember = "Broj korisnika police";
            this.chart1.Series["Broj korisnika"].YValueMembers = "Ukupan broj korisnika";
            this.chart1.Series["Broj korisnika"].Points.AddXY("Broj korisnika: Muško", xyz.ukupan_broj_musko(a));
            this.chart1.Series["Broj korisnika"].Points.AddXY("Broj korisnika: Žensko", xyz.ukupan_broj_zensko(a));
            this.chart1.Series["Broj korisnika"].Points.AddXY("Ukupan broj klijenata", xyz.popuni_statistiku(a));
        }
    }
}

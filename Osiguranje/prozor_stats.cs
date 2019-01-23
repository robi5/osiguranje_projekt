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

namespace Osiguranje
{
    public partial class prozor_stats : Form
    {
        public prozor_stats(string a)
        {
            InitializeComponent();
            stats_class xyz = new stats_class();

            this.chart1.Series[0].YValueType = ChartValueType.Int32;
            this.chart1.Series["Broj korisnika"].XValueMember = "Broj korisnika police";
            this.chart1.Series["Broj korisnika"].YValueMembers = "Ukupan broj korisnika";
            this.chart1.Series["Broj korisnika"].Points.AddXY("Broj korisnika police", xyz.popuni_grid(a));
            this.chart1.Series["Broj korisnika"].Points.AddXY("Ukupan broj klijenata", xyz.popuni_statistiku(a));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvdekiHesap
{
    public partial class Istatistikler : Form
    {
        
        GiderDagılımIstatistic giderDagılım = new GiderDagılımIstatistic();
        BirikimDagılımIstatistic birikimDagılım = new BirikimDagılımIstatistic();
        
        public Istatistikler()
        {
            InitializeComponent();
        }

        private void Istatistikler_Load(object sender, EventArgs e)
        {
            Dağılım1.Series["Dağılım1"].Points.Clear();
            Dağılım2.Series["Birikim Miktarı"].Points.Clear();
            giderDagılım.GrafikCiz(this.Dağılım1);
            birikimDagılım.GrafikCiz(this.Dağılım2);
 
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvdekiHesap
{
    interface IGrafikCizme
    {
        void  GrafikCiz(System.Windows.Forms.DataVisualization.Charting.Chart a);
    }

    class GiderGrafigi : IGrafikCizme
    {
        public void GrafikCiz(System.Windows.Forms.DataVisualization.Charting.Chart a)
        {

            
            a.Series["Dağılım1"].Points.Add(Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\toplamMutfakGideri.txt")));
            a.Series["Dağılım1"].Points[0].Color = Color.Red;
            a.Series["Dağılım1"].Points[0].AxisLabel = "Mutfak";
            a.Series["Dağılım1"].Points[0].LegendText = "Mutfak";
            a.Series["Dağılım1"].Points[0].Label = "Mutfak"  ;


            a.Series["Dağılım1"].Points.Add(Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\toplamFaturaGideri.txt")));
            a.Series["Dağılım1"].Points[1].Color = Color.Green;
            a.Series["Dağılım1"].Points[1].AxisLabel = "Faturalar";
            a.Series["Dağılım1"].Points[1].LegendText = "Faturalar";
            a.Series["Dağılım1"].Points[1].Label = "Faturalar";

            a.Series["Dağılım1"].Points.Add(Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\toplamGiyimGideri.txt")));
            a.Series["Dağılım1"].Points[2].Color = Color.Blue;
            a.Series["Dağılım1"].Points[2].AxisLabel = "Giyim";
            a.Series["Dağılım1"].Points[2].LegendText = "Giyim";
            a.Series["Dağılım1"].Points[2].Label = "Giyim";

            a.Series["Dağılım1"].Points.Add(Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\toplamKiraGideri.txt")));
            a.Series["Dağılım1"].Points[3].Color = Color.Brown;
            a.Series["Dağılım1"].Points[3].AxisLabel = "Kira";
            a.Series["Dağılım1"].Points[3].LegendText = "Kira";
            a.Series["Dağılım1"].Points[3].Label = "Kira";

            a.Series["Dağılım1"].Points.Add(Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\toplamTemizlikGideri.txt")));
            a.Series["Dağılım1"].Points[4].Color = Color.Yellow;
            a.Series["Dağılım1"].Points[4].AxisLabel = "Temizlik";
            a.Series["Dağılım1"].Points[4].LegendText = "Temizlik";
            a.Series["Dağılım1"].Points[4].Label = "Temizlik";

            a.Series["Dağılım1"].Points.Add(Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\toplamDigerGider.txt")));
            a.Series["Dağılım1"].Points[5].Color = Color.Pink;
            a.Series["Dağılım1"].Points[5].AxisLabel = "Diğer";
            a.Series["Dağılım1"].Points[5].LegendText = "Diğer";
            a.Series["Dağılım1"].Points[5].Label = "Diğer";

        }
    }

    class BirikimGrafiği : IGrafikCizme
    {
        public void GrafikCiz(System.Windows.Forms.DataVisualization.Charting.Chart a)
        {



            a.Series["Birikim Miktarı"].Points.Add(Convert.ToInt32(System.IO.File.ReadAllText
                ("D:\\EvdekiHesap\\TEB_22ayarAltınNakittutarı.txt"))+ Convert.ToInt32(System.IO.File.ReadAllText
                ("D:\\EvdekiHesap\\TEB_24ayarAltınNakittutarı.txt"))+ Convert.ToInt32(System.IO.File.ReadAllText
                ("D:\\EvdekiHesap\\TEBBirikimTL.txt")));
                      
                //a.Series["Birikim Miktarı"].Points[0].Color = Color.Firebrick;
                //a.Series["Birikim Miktarı"].Points[0].AxisLabel = "TEB Birikimi";
                a.Series["Birikim Miktarı"].Points[0].LegendText = "TEB Birikimi";
                a.Series["Birikim Miktarı"].Points[0].Label = "TEB Birikimi";


                a.Series["Birikim Miktarı"].Points.Add(Convert.ToInt32(System.IO.File.ReadAllText
                ("D:\\EvdekiHesap\\Albaraka_22ayarAltınNakittutarı.txt")) + Convert.ToInt32(System.IO.File.ReadAllText
                ("D:\\EvdekiHesap\\Albaraka_24ayarAltınNakittutarı.txt")) + Convert.ToInt32(System.IO.File.ReadAllText
                ("D:\\EvdekiHesap\\AlbarakaBirikimTL.txt")));
                //a.Series["Birikim Miktarı"].Points[1].Color = Color.Green;
                //a.Series["Birikim Miktarı"].Points[1].AxisLabel = "Albaraka Birikimi";
                a.Series["Birikim Miktarı"].Points[1].LegendText = "Albaraka Birikimi";
                a.Series["Birikim Miktarı"].Points[1].Label = "Albaraka Birikimi";

            
        }
    }
}

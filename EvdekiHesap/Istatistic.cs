using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvdekiHesap
{
    class Istatistic 
    {
        IGrafikCizme grafikCizme;
        public virtual void GrafikCiz(System.Windows.Forms.DataVisualization.Charting.Chart a)
        {
            grafikCizme.GrafikCiz(a);
        }

        public virtual void setGrafikCizme(IGrafikCizme grafikCizme)
        {
            this.grafikCizme = grafikCizme;
        }

    }

    class GiderDagılımIstatistic : Istatistic, IGrafikCizme
    {

        public GiderDagılımIstatistic()
        {
            setGrafikCizme(new GiderGrafigi());
        }


    }

    class BirikimDagılımIstatistic : Istatistic, IGrafikCizme
    {

        public BirikimDagılımIstatistic()
        {
            setGrafikCizme(new BirikimGrafiği());
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvdekiHesap
{

    public enum ödemeTürü
    {
        kartHarcaması, Nakitharcaması
    }
    public  class Giderler
    {
        public AnaKasa anaKasa = AnaKasa.GetAnaKasa();
        private int giderMiktarı;
        private string Açıklama;

        public string getAçıklama()
        {
            return Açıklama;
        }

        public void setAçıklama(string a)
        {

            Açıklama = a;
        }

        public int getgiderMiktarı()
        {
            return giderMiktarı;
        }

        public void setgiderMiktarı(int a)
        {
            giderMiktarı = a;
        }

        public ödemeTürü ödemeTürü;

        

        public virtual void GiderEkle(int a){}

    }

    class TemizlikGideri : Giderler
    {
        string Açıklama = "Temizlik Gideri ";
        int toplamTemizlikGideri = Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\datatxt\\toplamTemizlikGideri.txt"));
        public override void GiderEkle(int a)
        {
            anaKasa.bakiyeCıkar(a);
            toplamTemizlikGideri += a;
            System.IO.File.WriteAllText("D:\\EvdekiHesap\\datatxt\\toplamTemizlikGideri.txt", toplamTemizlikGideri.ToString());
        }
    }
    class MutfakGideri : Giderler
    {
        string Açıklama = "Mutfak Gideri ";
        int toplamMutfakGideri = Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\datatxt\\toplamMutfakGideri.txt"));
        public override void GiderEkle(int a)
        {
            anaKasa.bakiyeCıkar(a);
            toplamMutfakGideri += a;
            System.IO.File.WriteAllText("D:\\EvdekiHesap\\datatxt\\toplamMutfakGideri.txt", toplamMutfakGideri.ToString());
        }
    }
        class FaturaGideri : Giderler
        {
            string Açıklama = "Fatura Gideri ";
            int toplamFaturaGideri = Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\datatxt\\toplamFaturaGideri.txt"));
            public override void GiderEkle(int a)
            {
                anaKasa.bakiyeCıkar(a);
                toplamFaturaGideri += a;
                System.IO.File.WriteAllText("D:\\EvdekiHesap\\datatxt\\toplamFaturaGideri.txt", toplamFaturaGideri.ToString());
            }

        }
        class giyimGideri : Giderler
        {
            string Açıklama = "Giyim Gideri ";
            int toplamGiyimGideri = Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\datatxt\\toplamGiyimGideri.txt"));
            public override void GiderEkle(int a)
            {
                anaKasa.bakiyeCıkar(a);
                toplamGiyimGideri += a;
                System.IO.File.WriteAllText("D:\\EvdekiHesap\\datatxt\\toplamGiyimGideri.txt", toplamGiyimGideri.ToString());
            }
        }
        class KiraGideri : Giderler
        {
            string Açıklama = "Kira Gideri ";
            int toplamKiraGideri = Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\datatxt\\toplamKiraGideri.txt"));
            public override void GiderEkle(int a)
            {
                anaKasa.bakiyeCıkar(a);
                toplamKiraGideri += a;
                System.IO.File.WriteAllText("D:\\EvdekiHesap\\datatxt\\toplamKiraGideri.txt", toplamKiraGideri.ToString());
            }
        }
        class DigerGider : Giderler
        {
            string Açıklama = "Diğer Gider ";
            int toplamDiğerGider = Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\datatxt\\toplamDigerGider.txt"));
            public override void GiderEkle(int a)
            {
                anaKasa.bakiyeCıkar(a);
                toplamDiğerGider += a;
                System.IO.File.WriteAllText("D:\\EvdekiHesap\\datatxt\\toplamDigerGider.txt", toplamDiğerGider.ToString());
            }
        }

        class YöntemDekarötör : Giderler
        {
            Giderler giderler;
        }
        class NakitDekarötör : YöntemDekarötör
        {
            Giderler giderler;
            ödemeTürü ödemeTürü;
            public NakitDekarötör(Giderler gider)
            {
                giderler = gider;
                giderler.ödemeTürü = ödemeTürü.Nakitharcaması;
                giderler.setAçıklama (giderler.getAçıklama() + " ( Nakit ) ");
                

            }
        }
        class KartDekarötör : YöntemDekarötör
        {
            Giderler giderler;
            ödemeTürü ödemeTürü;
            public KartDekarötör(Giderler gider)
            {
                giderler = gider;
                giderler.ödemeTürü = ödemeTürü.kartHarcaması;
                giderler.setAçıklama(giderler.getAçıklama() + " ( Kart ) ");
        }


        }
    }


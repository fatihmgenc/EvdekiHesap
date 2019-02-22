using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvdekiHesap
{
    public class AnaKasa
    {
        private static AnaKasa anaKasa ;
        private int bakiye = Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\AnaKasaBakiyesi.txt"));
        private AnaKasa() { }
        public int getBakiye()
        {
            return bakiye;
        }
        public void bakiyeCıkar(int a)
        {
            bakiye -= a;
            System.IO.File.WriteAllText("D:\\EvdekiHesap\\AnaKasaBakiyesi.txt", bakiye.ToString());
        }
        public void bakiyeEkle(int a )
        {
            bakiye += a;
            System.IO.File.WriteAllText("D:\\EvdekiHesap\\AnaKasaBakiyesi.txt", bakiye.ToString());
        }
        public static AnaKasa GetAnaKasa()
        {
            if (anaKasa == null)
            {
                anaKasa = new AnaKasa();
            }
            return anaKasa;
        }
    }
    public class KumbaraHesap  
    { 
        private static KumbaraHesap kumbaraHesap;
        private int para = Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\KumbaraHesapBakiye.txt"));
        private KumbaraHesap() { }
        public int getKumbara()
        {
            return para;
        }
        public void ParaEkle(int a)
        {
            para += a;
            System.IO.File.WriteAllText("D:\\EvdekiHesap\\KumbaraHesapBakiye.txt",para.ToString());

        }
        public void ParaÇıkar(int a)
        {
            para -= a;
            System.IO.File.WriteAllText("D:\\EvdekiHesap\\KumbaraHesapBakiye.txt", para.ToString());
        }
        public static KumbaraHesap GetKumbaraHesap()
        {
            if (kumbaraHesap == null)
            {
                kumbaraHesap = new KumbaraHesap();
            }
            return kumbaraHesap;
        }
    }
}

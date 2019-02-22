using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EvdekiHesap
{
    class VadeKontrol : ISubject
    {

        static Object lockObject = new object();
        private static VadeKontrol uniqueVadeKontrol;
        private string LocalAlbarakVadeGünü = System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\AlbarakaVadeGunu.txt");
        private string LocalTEBVadeGünü = System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\TEBVadeGunu.txt");
        private IList<IObserver> gözlemciler = new List<IObserver>();


        private VadeKontrol() { }
        public IList<IObserver> getGözlemciList()
        {
            return gözlemciler;
        }
        public static VadeKontrol getVadeKontrol()
        {
            if (uniqueVadeKontrol == null)
            {
                lock (lockObject)
                    if (uniqueVadeKontrol == null)
                    {
                        uniqueVadeKontrol = new VadeKontrol();
                    }
            }
            return uniqueVadeKontrol;
        }
        public string getLocalAlbarakVadeGünü()
        {
            return LocalAlbarakVadeGünü;
        }
        public void setLocalAlbarakVadeGünü(string day)
        {
            //LocalAlbarakVadeGünü = Convert.ToInt32(day);
            //TextWriter tw = new StreamWriter("VadeGünleri");
            //tw.Write("LAV=" + day); //LocalAlbarakaVade
            //tw.Close();
            System.IO.File.WriteAllText("D:\\EvdekiHesap\\AlbarakaVadeGunu.txt", day);
        }
        public string getLocalTEBVadeGünü()
        {
            //return Convert.ToInt32(LocalTEBVadeGünü);
            return LocalTEBVadeGünü;
        }
        public void setLocalTEBVadeGünü(string day)
        {
            //LocalTEBVadeGünü = Convert.ToInt32(day);
            //TextWriter tw = new StreamWriter("VadeGünleri");
            //tw.Write("LTV=" + day); //LocalTEBVade
            //tw.Close();
            System.IO.File.WriteAllText("D:\\EvdekiHesap\\TEBVadeGunu.txt", day);
        }
        public void AboneCık(IObserver a)
        {
            gözlemciler.Remove(a);
        }
        public void AboneOl(IObserver a)
        {
            gözlemciler.Add(a);
        }
        public void GözlemciyeBildirim(string tür)
        {
            for (int i = 0; i < 2; i++)
            {
                if (tür == "Albaraka")
                {

                    if (gözlemciler[i].ToString() == "EvdekiHesap.AlbarakaBirikimHesabı")
                    {
                        System.IO.File.WriteAllText("D:\\EvdekiHesap\\HataDosyasi.txt", "AlbarakayaGirdiniz ");
                        gözlemciler[i].update();
                    }

                }
            }
            for (int i = 0; i < 2; i++)
            {
                if (tür == "TEB")

                {

                    if (gözlemciler[i].ToString() == "EvdekiHesap.TebBirikimHesabı")
                    {
                        System.IO.File.WriteAllText("D:\\EvdekiHesap\\HataDosyasi.txt", "TEBE Girdin");
                        gözlemciler[i].update();
                    }

                }
            }

        }
        public void VadeGünüKontolü(string day)
        {
            if (LocalAlbarakVadeGünü == day)
            {
                GözlemciyeBildirim("Albaraka");
            }
            if (LocalTEBVadeGünü == day)
            {
                GözlemciyeBildirim("TEB");
            }
        }
    }
}

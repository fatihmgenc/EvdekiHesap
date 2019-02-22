using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvdekiHesap
{

    interface Birikimhesap
    {
        void KarPayıUygula();
        void _22AyarAltınEkle(int altınGramı);
        void _24ayarAltınEkle(int altınGramı);
        void _22ayarAltınHesabıKatkısı();
        void _24ayarAltınHesabıKatkısı();
    }
    interface ParaGetiri
    {

    }
    interface AltınFaiz
    {
       


    }

    class IslamiKaarUzerinden : ParaGetiri
    {
        public int yuzdeMiktarı = 3;
    }
    class FaizUzerinden : ParaGetiri 
    {
        public int yuzdeMiktar = 5;
    }
    class DüsükFaizAltın: AltınFaiz
    {
        public int _22gramFaizMiktarı = 3;
        public int _24gramFaizMiktarı = 5;
    }
    class YüksekFaizAltın: AltınFaiz
    {
        public int _22gramFaizMiktarı = 5;
        public int _24gramFaizMiktarı = 8;
    }
    class AlbarakaBirikimHesabı : Birikimhesap, IObserver
    {
       

        int _22ayarGramFiyatı = 188;
        int _24ayarGramFiyatı = 205;
        int _22ayarAltınNakittutarı = Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\Albaraka_22ayarAltınNakittutarı.txt"));
        int _24ayarAltınNakitTutarı = Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\Albaraka_24ayarAltınNakittutarı.txt"));
        int TlNakitTutarı = Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\AlbarakaBirikimTL.txt"));

        VadeKontrol vadeKontrol = VadeKontrol.getVadeKontrol();
        KumbaraHesap kumbaraHesap = KumbaraHesap.GetKumbaraHesap();
        IslamiKaarUzerinden IslamiUzerinden = new IslamiKaarUzerinden();
        YüksekFaizAltın YüksekFaizAltın = new YüksekFaizAltın();

        public AlbarakaBirikimHesabı()
        {
            vadeKontrol.AboneOl(this);
        }
        public int getTlNakitTutar()
        {
            return Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\AlbarakaBirikimTL.txt"));
        }
        public int getTLAltınTutarı()
        {
            return Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\Albaraka_22ayarAltınNakittutarı.txt"))+ Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\Albaraka_24ayarAltınNakittutarı.txt"));
        }
        public void TLNakitEkle(int tutar)
        {
            TlNakitTutarı += tutar;
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\AlbarakaBirikimTL.txt", TlNakitTutarı.ToString());
            kumbaraHesap.ParaEkle(tutar);
        }
        public void _22AyarAltınEkle(int altınGramı)
        {
            _22ayarAltınNakittutarı += altınGramı * _22ayarGramFiyatı;
            kumbaraHesap.ParaEkle(altınGramı * _22ayarGramFiyatı);
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\Albaraka_22ayarAltınNakittutarı.txt", _22ayarAltınNakittutarı.ToString());
        }
        public void _22ayarAltınHesabıKatkısı()
        {
            int temp = _22ayarAltınNakittutarı * YüksekFaizAltın._22gramFaizMiktarı / 100;
            _22ayarAltınNakittutarı += temp;
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\Albaraka_22ayarAltınNakittutarı.txt", _22ayarAltınNakittutarı.ToString());
            kumbaraHesap.ParaEkle(temp);
        }
        public void _24ayarAltınHesabıKatkısı()
        {
            int temp = _24ayarAltınNakitTutarı * YüksekFaizAltın._22gramFaizMiktarı / 100;
            _24ayarAltınNakitTutarı += temp;
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\Albaraka_22ayarAltınNakittutarı.txt", _24ayarAltınNakitTutarı.ToString());
            kumbaraHesap.ParaEkle(temp);
        }
        public void _24ayarAltınEkle(int altınGramı)
        {
           
            _24ayarAltınNakitTutarı += altınGramı * _24ayarGramFiyatı;
            kumbaraHesap.ParaEkle(altınGramı * _24ayarGramFiyatı);
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\Albaraka_24ayarAltınNakittutarı.txt", _24ayarAltınNakitTutarı.ToString());
        }
        public void KarPayıUygula()
        {
            int temp = TlNakitTutarı * IslamiUzerinden.yuzdeMiktarı / 100;
            TlNakitTutarı += temp;
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\AlbarakaBirikimTL.txt", TlNakitTutarı.ToString());
            kumbaraHesap.ParaEkle(temp);


        }
        public void update()
        {
            KarPayıUygula();
            _24ayarAltınHesabıKatkısı();
            _22ayarAltınHesabıKatkısı();
        }
        
    }
    class TebBirikimHesabı : Birikimhesap , IObserver  
    {
       
        
        int _22ayarGramFiyatı = 188;
        int _24ayarGramFiyatı = 205;
        int _22ayarAltınNakittutarı = Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\TEB_22ayarAltınNakittutarı.txt"));
        int _24ayarAltınNakitTutarı = Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\TEB_24ayarAltınNakittutarı.txt"));
        int TlNakitTutarı = Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\TEBBirikimTL.txt"));

        VadeKontrol vadeKontrol = VadeKontrol.getVadeKontrol();
        KumbaraHesap kumbaraHesap = KumbaraHesap.GetKumbaraHesap();
        FaizUzerinden faizUzerinden = new FaizUzerinden();
        DüsükFaizAltın düsükFaizAltın = new DüsükFaizAltın();

        public TebBirikimHesabı()
        {
            vadeKontrol.AboneOl(this);
        }
        public int getTlNakitTutar()
        {
            return Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\TEBBirikimTL.txt")); 
        }
        public int getTLAltınTutarı()
        {
            return Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\TEB_24ayarAltınNakittutarı.txt"))+ Convert.ToInt32(System.IO.File.ReadAllText
            ("D:\\EvdekiHesap\\TEB_22ayarAltınNakittutarı.txt"));
        }
        public void TLNakitEkle(int tutar)
        {

            TlNakitTutarı += tutar;
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\TEBBirikimTL.txt", TlNakitTutarı.ToString());
            kumbaraHesap.ParaEkle(tutar);
        }
        public void KarPayıUygula()
        {
            int temp = TlNakitTutarı * faizUzerinden.yuzdeMiktar / 100 ;
            TlNakitTutarı += temp ;
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\TEBBirikimTL.txt", TlNakitTutarı.ToString());
            kumbaraHesap.ParaEkle(temp);

        }
        public void _22AyarAltınEkle(int altınGramı)
        {
         
            _22ayarAltınNakittutarı += altınGramı * _22ayarGramFiyatı;
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\TEB_22ayarAltınNakittutarı.txt", _22ayarAltınNakittutarı.ToString());
            kumbaraHesap.ParaEkle(altınGramı * _22ayarGramFiyatı);
        }
        public void _22ayarAltınHesabıKatkısı()
        {
            int temp = _22ayarAltınNakittutarı * düsükFaizAltın._22gramFaizMiktarı/100;
            _22ayarAltınNakittutarı += temp;
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\TEB_22ayarAltınNakittutarı.txt", _22ayarAltınNakittutarı.ToString());
            kumbaraHesap.ParaEkle(temp);
        }
        public void _24ayarAltınEkle(int altınGramı)
        {

            _24ayarAltınNakitTutarı += altınGramı * _24ayarGramFiyatı;
            kumbaraHesap.ParaEkle(altınGramı * _24ayarGramFiyatı);
            System.IO.File.WriteAllText
                ("D:\\EvdekiHesap\\TEB_24ayarAltınNakittutarı.txt", _24ayarAltınNakitTutarı.ToString());
        }
        public void _24ayarAltınHesabıKatkısı()
        {
            int temp = _24ayarAltınNakitTutarı * düsükFaizAltın._24gramFaizMiktarı;
            _24ayarAltınNakitTutarı += temp;
            System.IO.File.WriteAllText
            ("D:\\EvdekiHesap\\TEB_24ayarAltınNakittutarı.txt", _24ayarAltınNakitTutarı.ToString());
            kumbaraHesap.ParaEkle(temp);
        }
        void IObserver.update()
        {
            KarPayıUygula();
            _22ayarAltınHesabıKatkısı();
            _24ayarAltınHesabıKatkısı();
        }

    }
}





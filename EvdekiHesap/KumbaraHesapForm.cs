using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EvdekiHesap
{
    public partial class KumbaraHesapForm : Form
    {


        VadeKontrol vadeKontrol = VadeKontrol.getVadeKontrol();
        KumbaraHesap kumbaraHesap = KumbaraHesap.GetKumbaraHesap();
        AlbarakaBirikimHesabı albarakaBirikim = new AlbarakaBirikimHesabı();
        TebBirikimHesabı tebBirikim = new TebBirikimHesabı();

        bool loaded = false;
        bool AlbarakaOlusturuldu = false;
        bool TEBOlusturuldu = false;

        public KumbaraHesapForm()
        {
            InitializeComponent();
        }
        private void KumbaraHesapForm_Load(object sender, EventArgs e)
        {
            MiktarLabelAtama();
            if (loaded == false)
            {
                vadeKontrol.getGözlemciList().Add(albarakaBirikim);
                
                vadeKontrol.getGözlemciList().Add(tebBirikim);
                
                vadeKontrol.VadeGünüKontolü(System.DateTime.Now.ToString("dd"));
                MiktarLabelAtama();
                
                loaded = true;
                label3.Text = Convert.ToString(kumbaraHesap.getKumbara());
                comboBox1.Items.Add("Albaraka");
                comboBox1.Items.Add("TEB");
                
            }
            
        }
        private void comboBox2AlbarakaYukle()
        {

            if (!AlbarakaOlusturuldu)
            {
                    AlbarakaOlusturuldu = true;
                    comboBox2.Items.Add("Albaraka Nakit");
                    comboBox2.Items.Add("Albaraka Altın (22 ayar)");
                    comboBox2.Items.Add("Albaraka Altın (24 ayar)");
            }

            
        }
        private void comboBox2TEBYukle()
        {
            if (!TEBOlusturuldu)
            {
                TEBOlusturuldu = true;
                comboBox2.Items.Add("TEB Nakit");
                comboBox2.Items.Add("TEB Altın (22 Ayar)");
                comboBox2.Items.Add("TEB Altın (24 Ayar)");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Albaraka")
            {
                comboBox2AlbarakaYukle();
                label6.Visible = true;
                label8.Visible = true;
                button4.Visible = true;
                vadeKontrol.setLocalAlbarakVadeGünü(textBox2.Text);
                vadeKontrol.AboneOl(albarakaBirikim);
            }
            else if (comboBox1.Text == "TEB")
            {
                comboBox2TEBYukle();   
                label7.Visible = true;
                label9.Visible = true;
                button5.Visible = true;
                vadeKontrol.setLocalTEBVadeGünü(textBox2.Text);
                vadeKontrol.AboneOl(tebBirikim);
            }

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void MiktarLabelAtama()
        {
            label9.Text = Convert.ToString(tebBirikim.getTlNakitTutar() +
                       " TL nakit " + tebBirikim.getTLAltınTutarı() +
                       " TL degerinde altın");
            label8.Text = Convert.ToString(albarakaBirikim.getTlNakitTutar() +
            " TL nakit " + albarakaBirikim.getTLAltınTutarı() +
            " TL degerinde altın");
            label3.Text = System.IO.File.ReadAllText("D:\\EvdekiHesap\\KumbaraHesapBakiye.txt");


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.Text == "Albaraka Altın (22 ayar)" ||
               comboBox2.Text == "Albaraka Altın (24 ayar)" ||
               comboBox2.Text == "TEB Altın (22 Ayar)" ||
               comboBox2.Text == "TEB Altın (24 Ayar)"
               )
            {
                label12.Text = "Gram Giriniz ";
            }
            else
            {
                label12.Text = "Tutar Giriniz ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(comboBox2.Text== "Albaraka Nakit")
            {
                albarakaBirikim.TLNakitEkle(Convert.ToInt32(textBox1.Text));

            }
            else if(comboBox2.Text== "Albaraka Altın (22 ayar)")
            {
                albarakaBirikim._22AyarAltınEkle(Convert.ToInt32(textBox1.Text));
            }
            else if(comboBox2.Text == "Albaraka Altın (24 ayar)")
            {
                albarakaBirikim._24ayarAltınEkle(Convert.ToInt32(textBox1.Text));
            }
            else if(comboBox2.Text== "TEB Nakit")
            {
                tebBirikim.TLNakitEkle(Convert.ToInt32(textBox1.Text));
            }
            else if(comboBox2.Text== "TEB Altın (22 Ayar)")
            {
                tebBirikim._22AyarAltınEkle(Convert.ToInt32(textBox1.Text));
            }
            else if(comboBox2.Text== "TEB Altın (24 Ayar)")
            {
                tebBirikim._24ayarAltınEkle(Convert.ToInt32(textBox1.Text));
            }

            MiktarLabelAtama();
            //label3.Text = kumbaraHesap.getKumbara().ToString();
            //label9.Text = Convert.ToString(tebBirikim.getTlNakitTutar() +
            //       " TL nakit " + tebBirikim.getTLAltınTutarı() +
            //       " TL degerinde altın");
            //label8.Text = Convert.ToString(albarakaBirikim.getTlNakitTutar() +
            //        " TL nakit " + albarakaBirikim.getTLAltınTutarı() +
            //        " TL degerinde altın");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

                System.IO.File.WriteAllText("D:\\EvdekiHesap\\KumbaraHesapBakiye.txt",
                Convert.ToString(Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\KumbaraHesapBakiye.txt")) - (
                Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\Albaraka_22ayarAltınNakittutarı.txt")) +
                Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\Albaraka_24ayarAltınNakittutarı.txt")) +
                Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\AlbarakaBirikimTL.txt")))
                ));

                StreamWriter _22 = new StreamWriter(@"D:\EvdekiHesap\Albaraka_22ayarAltınNakittutarı.txt");
                int a = 0;
                
                _22.WriteLine(a);
                _22.Close();
               

                StreamWriter _24 = new StreamWriter(@"D:\EvdekiHesap\Albaraka_24ayarAltınNakittutarı.txt");

                _24.WriteLine(a);
                _24.Close();

                StreamWriter nakit = new StreamWriter(@"D:\EvdekiHesap\AlbarakaBirikimTL.txt");

                nakit.WriteLine(a);
                nakit.Close();

                MiktarLabelAtama();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            System.IO.File.WriteAllText("D:\\EvdekiHesap\\KumbaraHesapBakiye.txt",
                Convert.ToString(Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\KumbaraHesapBakiye.txt")) - (
                Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\TEB_22ayarAltınNakittutarı.txt")) +
                Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\TEB_24ayarAltınNakittutarı.txt")) +
                Convert.ToInt32(System.IO.File.ReadAllText("D:\\EvdekiHesap\\TEBBirikimTL.txt")))
                ));

            StreamWriter _22 = new StreamWriter(@"D:\EvdekiHesap\TEB_22ayarAltınNakittutarı.txt");
                int a = 0;

                _22.WriteLine(a);
                _22.Close();


                StreamWriter _24 = new StreamWriter(@"D:\EvdekiHesap\TEB_24ayarAltınNakittutarı.txt");

                _24.WriteLine(a);
                _24.Close();

                StreamWriter nakit = new StreamWriter(@"D:\EvdekiHesap\TEBBirikimTL.txt");

                nakit.WriteLine(a);
                nakit.Close();

                MiktarLabelAtama();



            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


    }
}

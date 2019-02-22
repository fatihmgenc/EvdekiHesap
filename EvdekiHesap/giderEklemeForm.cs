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
    public partial class giderEklemeForm : Form
    {
        public  void dosyayaYaz(string a)
        {

            StreamWriter sw = new StreamWriter(@"D:\EvdekiHesap\Harcamalar.txt", true);

            sw.WriteLine(a);
            sw.Close();

        }
        AnaKasa anaKasa = AnaKasa.GetAnaKasa();
        public Giderler mutfakGideri = new MutfakGideri();
        public Giderler temizlikGideri = new TemizlikGideri();
        public Giderler kiraGideri = new KiraGideri();
        public Giderler giyimGideri = new giyimGideri();
        public Giderler digerGider = new DigerGider();
        public Giderler faturaGideri = new FaturaGideri();
        bool loaded = false;

        
        public giderEklemeForm()
        {
            mutfakGideri.setAçıklama("Mutfak gideri ");
            temizlikGideri.setAçıklama("Temizlik gideri ");
            kiraGideri.setAçıklama("Kira gideri ");
            giyimGideri.setAçıklama("Giyim gideri ");
            faturaGideri.setAçıklama( "Fatura gideri ");
            digerGider.setAçıklama("Diğer giderler ");
            InitializeComponent();
        }

        private void giderEklemeForm_Load(object sender, EventArgs e)
        {

            label1.Text = anaKasa.getBakiye().ToString();
            if (!loaded)
            {
                loaded = true;
                comboBox1.Items.Add("Mutfak");
                comboBox1.Items.Add("Temizlik");
                comboBox1.Items.Add("Kira");
                comboBox1.Items.Add("Giyim");
                comboBox1.Items.Add("Fatura");
                comboBox1.Items.Add("Diğer");

                comboBox2.Items.Add("Nakit");
                comboBox2.Items.Add("Kredi Kartı");
               
            }
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
                
                if (comboBox1.Text == "Mutfak")
                {
                    mutfakGideri.GiderEkle(Convert.ToInt32(textBox1.Text));
                    label1.Text = anaKasa.getBakiye().ToString();
                    
                    mutfakGideri.setAçıklama(mutfakGideri.getAçıklama()+textBox2.Text);
                    
                    if (comboBox2.Text == "Nakit")
                    {
                        NakitDekarötör yenigider = new NakitDekarötör(mutfakGideri);
                        System.IO.File.WriteAllText("D:\\EvdekiHesap\\NakitGiderTutar.txt",textBox1.Text);
                        
                    }
                    else if (comboBox2.Text == "Kredi Kartı")
                     {
                    KartDekarötör yenigider = new KartDekarötör(mutfakGideri);
                    System.IO.File.WriteAllText("D:\\EvdekiHesap\\KrediGiderTutar.txt",textBox1.Text);
                }

                    dosyayaYaz(mutfakGideri.getAçıklama() + " " + textBox1.Text);
                    label1.Text = anaKasa.getBakiye().ToString();

                }
                else if (comboBox1.Text == "Temizlik")
                {
                temizlikGideri.GiderEkle(Convert.ToInt32(textBox1.Text));
                label1.Text = anaKasa.getBakiye().ToString();
                temizlikGideri.setAçıklama(temizlikGideri.getAçıklama() + textBox2.Text);
                if (comboBox2.Text == "Nakit")
                {
                    NakitDekarötör yenigider = new NakitDekarötör(temizlikGideri);
                }
                else if(comboBox2.Text== "Kredi Kartı")
                {
                    KartDekarötör yenigider = new KartDekarötör(temizlikGideri);
                }
                dosyayaYaz(temizlikGideri.getAçıklama() + " " + textBox1.Text);
                label1.Text = anaKasa.getBakiye().ToString();

            }
                else if (comboBox1.Text == "Kira")
            {
                kiraGideri.GiderEkle(Convert.ToInt32(textBox1.Text));
                label1.Text = anaKasa.getBakiye().ToString();
                kiraGideri.setAçıklama(kiraGideri.getAçıklama()+textBox2.Text);
                if (comboBox2.Text == "Nakit")
                {
                    NakitDekarötör yenigider = new NakitDekarötör(kiraGideri);
                }
                else if (comboBox2.Text == "Kredi Kartı")
                {
                    KartDekarötör yenigider = new KartDekarötör(kiraGideri);
                }
                dosyayaYaz(kiraGideri.getAçıklama() + " " + textBox1.Text);
                label1.Text = anaKasa.getBakiye().ToString();

            }
                else if (comboBox1.Text == "Giyim")
            {
                giyimGideri.GiderEkle(Convert.ToInt32(textBox1.Text));
                label1.Text = anaKasa.getBakiye().ToString();
                giyimGideri.setAçıklama(giyimGideri.getAçıklama() +  textBox2.Text);
                if (comboBox2.Text == "Nakit")
                {
                    NakitDekarötör yenigider = new NakitDekarötör(giyimGideri);
                }
                else if (comboBox2.Text == "Kredi Kartı")
                {
                    KartDekarötör yenigider = new KartDekarötör(giyimGideri);
                }
                dosyayaYaz(giyimGideri.getAçıklama() + " " + textBox1.Text);
                label1.Text = anaKasa.getBakiye().ToString();

            }
                else if (comboBox1.Text == "Fatura")
                {
                faturaGideri.GiderEkle(Convert.ToInt32(textBox1.Text));
                label1.Text = anaKasa.getBakiye().ToString();
                faturaGideri.setAçıklama(faturaGideri.getAçıklama() + textBox2.Text);
                if (comboBox2.Text == "Nakit")
                {
                    NakitDekarötör yenigider = new NakitDekarötör(faturaGideri);
                }
                else if (comboBox2.Text == "Kredi Kartı")
                {
                    KartDekarötör yenigider = new KartDekarötör(faturaGideri);
                }
                dosyayaYaz(faturaGideri.getAçıklama() + " " + textBox1.Text);
                label1.Text = anaKasa.getBakiye().ToString();

            }
                else if (comboBox1.Text == "Diğer")
            {
                digerGider.GiderEkle(Convert.ToInt32(textBox1.Text));
                label1.Text = anaKasa.getBakiye().ToString();
                digerGider.setAçıklama (digerGider.getAçıklama() +textBox2.Text);
                if (comboBox2.Text == "Nakit")
                {
                    NakitDekarötör yenigider = new NakitDekarötör(digerGider);
                }
                else if (comboBox2.Text == "Kredi Kartı")
                {
                    KartDekarötör yenigider = new KartDekarötör(digerGider);
                }
                dosyayaYaz(digerGider.getAçıklama() + " " + textBox1.Text);
                label1.Text = anaKasa.getBakiye().ToString();

            }
            comboBox1.Text ="";
            comboBox2.Text ="";
            textBox1.Text = "";
            textBox2.Text = "";
                this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          
        
        }
    }

}



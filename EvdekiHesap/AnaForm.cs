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
    
    public  partial class AnaForm : Form
    {
      
        KumbaraHesapForm kumbaraHesapForm = new KumbaraHesapForm();
        AnaKasa anaKasa = AnaKasa.GetAnaKasa();
        giderEklemeForm giderEklemeForm = new giderEklemeForm();
        VadeKontrol vadeKontrol = VadeKontrol.getVadeKontrol();
        Istatistikler ıstatistikler = new Istatistikler();
        //IList<Iobserver> tempList = new List<Iobserver>();
        public AnaForm()
        {
            InitializeComponent();
        }

        public  AnaForm getForm1()
        {
            
            return this;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text =Convert.ToString(anaKasa.getBakiye())+" TL";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            giderEklemeForm.ShowDialog();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            StreamReader oku = new StreamReader(@"D:\EvdekiHesap\Harcamalar.txt");
            string metin = oku.ReadLine();

            while(metin != null)
            {
                listBox1.Items.Add(metin);
                metin= oku.ReadLine();
            }
            oku.Close();
            

            
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kumbaraHesapForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
                anaKasa.bakiyeEkle(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Kasanıza " + Convert.ToInt32(textBox1.Text) + " TL Eklendi .");
                textBox1.Clear();
                label4.Text = anaKasa.getBakiye().ToString()+" TL";
                
           
  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ıstatistikler.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter harcamalar = new StreamWriter(@"D:\EvdekiHesap\Harcamalar.txt");
            string a = " ";

            harcamalar.WriteLine(a);
            harcamalar.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            anaKasa.bakiyeCıkar(Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Kasanıza " + Convert.ToInt32(textBox1.Text) + " TL Çıkarıldı .");
            textBox1.Clear();
            label4.Text = anaKasa.getBakiye().ToString() + " TL";
        }
    }
}

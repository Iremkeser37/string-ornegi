using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_örnrkleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToUpper();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToLower();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
           string mesaj = $"toplam {lblMesaj.Text.Length} karakter vardır.";
           MessageBox.Show(mesaj);
            
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = $"merhaba dünya ben {txtMesaj.Text}";
        }

        private void btnBırlestır_Click(object sender, EventArgs e)
        {
            string mesaj1 = "merhaba dünya";
            string mesaj2 = "ben irem";
            string yeniMesaj = string.Concat(mesaj1,mesaj2);
            lblMesaj.Text = yeniMesaj;
        }

        private void btnSıraGetır_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            // mesaj[4] // char türündedir
            MessageBox.Show($"6.sıradaki harf:{mesaj[5]}");
        }

        private void btnKacıs_Click(object sender, EventArgs e)
        {
            string mesaj = "Merhaba ben \"irem\". \rNasılsın?";
            lblMesaj.Text = mesaj;
        }

        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            string isim1 = "yasemin";
            string isim2 = "yasemin";
            string isim3 = "irem";

            bool durum1 = isim1.Equals(isim2);
            bool durum2 = isim1 == isim2;

            bool durum3 = isim1.Equals(isim3);
            bool durum4 = isim1 == isim3;

            string mesaj = $"durum1:{durum1} --> durum2 {durum2} \rdurum3 :{durum3} --> durum4 : {durum4}";
            MessageBox.Show(mesaj);





        }

        private void btnBicim_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            string mesaj = $"{a} + {b} +{c}";
            MessageBox.Show(mesaj);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string isim1 = "İrem";
            string isim2 = "Ceren";
            string isim3 = "Yasemin";
            string isim4 = "Ela";
            string isim5 = "kumsal";
            
            int sonuc1 = string.Compare(isim1, isim2); //0
            int sonuc2 = string.Compare(isim1, isim3); //1
            int sonuc3 = string.Compare(isim1, isim4); //-1
            int sonuc4 = string.Compare(isim1, isim5); //1
            int sonuc5 = string.Compare(isim1, isim2,true); //0




        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string mesaj1 = lblMesaj.Text.Remove( 7);
            string mesaj2 = lblMesaj.Text.Remove(0, 4);
            MessageBox.Show(mesaj1);
            MessageBox.Show(mesaj2);
        }

        private void btnContanıs_Click(object sender, EventArgs e)
        {
            bool durum = lblMesaj.Text.Contains(txtMesaj.Text);
            MessageBox.Show($"{txtMesaj.Text}.....{durum}");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text.Replace("irem",txtMesaj.Text);
            lblMesaj.Text = mesaj;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
           lbAd.DataSource = lblMesaj.Text.Split(' ').ToList();
        }
    }
}

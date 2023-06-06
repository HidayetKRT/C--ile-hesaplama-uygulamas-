using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class standartsapma : Form
    {
        public standartsapma()
        {
            InitializeComponent();
        }
        List<int> sayilar = new List<int>();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            foreach (string satir in richTextBox1.Lines)
            {
                string[] kelimeler = satir.Split(' ');
                foreach (string kelime in kelimeler)
                {
                    int sayi;
                    if (int.TryParse(kelime, out sayi))
                    {
                        sayilar.Add(sayi);
                    }
                }
            }
            double toplam = sayilar.Sum(); // Elemanların toplamını hesapla
            double ortalama = toplam / sayilar.Count; // Aritmetik ortalama hesapla

            double toplamKareFarki = sayilar.Select(x => (x - ortalama) * (x - ortalama)).Sum(); // Elemanların aritmetik ortalamaya olan farklarının karelerinin toplamını hesapla

            double standartSapma = Math.Sqrt(toplamKareFarki / (    sayilar.Count - 1)); // Standart sapmayı hesapla
            lblSonuc.Text = "Dizideki eleman sayısı: "+"\n" +"Dizini ortalaması: "+"\n"+"Standat sapma: ";
            lblSonuc2.Text = sayilar.Count + "\n" + ortalama + "\n" + standartSapma.ToString();
        }
    }
}

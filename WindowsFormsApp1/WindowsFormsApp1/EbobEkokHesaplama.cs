using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace WindowsFormsApp1
{
    public partial class EbobEkokHesaplama : Form
    {
        public EbobEkokHesaplama()
        {
            InitializeComponent();
        }
        private List<int> sayilar = new List<int>(); // sayıları tutmak için bir liste tanımlıyoruz
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliSayi = Convert.ToInt32(comboBox1.SelectedItem);
            panel1.Controls.Clear();
            panel2.Controls.Clear();// önceki textbox'ları temizliyoruz
            sayilar.Clear(); // önceki sayıları temizliyoruz
            
            for (int i = 0; i < seciliSayi; i++)
            {
                TextBox textBox = new TextBox();
                Label lbl = new Label();
                textBox.Name = "txtSayi" + (i + 1);
                textBox.Location = new Point(10, 40 * i);
                lbl.Location = new Point(10,(40*i)+20);
                lbl.Size = new Size(140, 2);
                textBox.ForeColor = Color.White;
                textBox.BorderStyle = BorderStyle.None;
                textBox.BackColor =Color.FromArgb(26,26,26);
                lbl.BackColor = Color.MediumSpringGreen;
                textBox.Font = new Font("Arial", 12);
                textBox.Size = new Size(140, 19);
                panel1.Controls.Add(lbl);
                panel1.Controls.Add(textBox);
            }
            for (int i = 0; i < seciliSayi; i++)
            {
                Label label = new Label();
                label.Size = new Size(100, 22);
                label.Text = ("Sayı " + (i + 1).ToString()+ ":");
                label.Font = new Font("Arial", 14);
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.MediumSpringGreen;
                label.Location = new Point(10, i * 40);
                panel2.Controls.Add(label);

            }

        }
        public int Ebob(params int[] sayilar)
        {
            int minSayi = sayilar.Min();
            int ebob = 1;

            for (int i = 2; i <= minSayi; i++)
            {
                bool bolunebilir = true;
                for (int j = 0; j < sayilar.Length; j++)
                {
                    if (sayilar[j] % i != 0)
                    {
                        bolunebilir = false;
                        break;
                    }
                }
                if (bolunebilir)
                {
                    ebob = i;
                }
            }

            return ebob;
        }



        private int EkokBul(int[] sayilar)
        {
            int ekok = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                int ebob = Ebob(sayilar[i], ekok);
                ekok = (sayilar[i] * ekok) / ebob;
            }
            return ekok;
        }

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            // Textbox'lardan sayıları al
           
            int[] sayilar = new int[panel1.Controls.OfType<TextBox>().Count()];
            int index = 0;
            //Control control in flowLayoutPanel1.Controls)
            foreach (Control control in panel1.Controls.OfType<TextBox>())
            {
                if (control is TextBox)
                {
                    int sayi;
                    if (int.TryParse(control.Text, out sayi))
                    {
                        sayilar[index++] = sayi;
                    }

                }
            }
            // EKOK'u hesapla
            int ekok = EkokBul(sayilar);
            int ebob = Ebob(sayilar);
            // Sonucu göster
            
            lblSonuc.Text = "Girilen sayıların EKOK'u: " + ekok+ "\n" + "Girilen sayıların EBOB'u: " + ebob;

        }

        private void EbobEkokHesaplama_Load(object sender, EventArgs e)
        {

        }
    }
}

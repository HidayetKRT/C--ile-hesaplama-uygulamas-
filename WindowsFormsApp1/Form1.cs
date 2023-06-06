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
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }
      
        private bool hareketettir = false;
        private Point hareketKonumu;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel2.Size = new Size(10,522);
            panel2.AutoScrollMargin = new Size(0, 0);
          
                panel3.Controls.Clear();
                anasayfa fr = new anasayfa();
                fr.TopLevel = false;
                panel3.Controls.Add(fr);
                fr.Show();
            
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void alanhesaplama_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            alanhesaplama fr = new alanhesaplama();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();

        }
        private void desihesaplama_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            desihesaplama fr = new desihesaplama();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();

        }
        private void asalçarpanhesaplama_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Asalcarpan fr = new Asalcarpan();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();
        }
        private void EbobEkokHesaplama_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            EbobEkokHesaplama fr = new EbobEkokHesaplama();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();
        }
        private void cmincdönüşümü_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            cmİncDönüşümü fr = new cmİncDönüşümü();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();
        }
        private void kmmilHesaplama_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            kmMilHesaplama fr = new kmMilHesaplama();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();
        }
        private void hacimHesaplama_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            hacimHesaplama fr = new hacimHesaplama();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();
        }
        private void sayıtabanDönüşümüHesaplama_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            sayıtabandönüşümü fr = new sayıtabandönüşümü();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();
        }
        private void standartsapma_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            standartsapma fr = new standartsapma();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();
        }
        private void yagoranıhesaplama_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            yagorani fr = new yagorani();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();
        }
        private void anasayfa_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            anasayfa fr = new anasayfa();
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();
        }
        private void lbskgHesaplama_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            lbskghesaplama fr = new lbskghesaplama();        
            fr.TopLevel = false;
            panel3.Controls.Add(fr);
            fr.Show();
        }
        private void menubtn_Click(object sender, EventArgs e)
        {
            a = a + 1;
            if (a % 2 == 1)
            {
                panel2.Size = new Size(150, 522);
                panel2.AutoScrollMargin = new Size(2, 449);

            }
            if (a % 2 == 0)
            {
                panel2.Size = new Size(10, 522);
                panel2.AutoScrollMargin = new Size(0, 0);

            }
        }

        private void uygulamakapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            hareketettir = true;
            hareketKonumu = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareketettir)
            {
                Point konum = Control.MousePosition;
                konum.Offset(-hareketKonumu.X, -hareketKonumu.Y);
                Location = konum;
            }

        }
       

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            hareketettir = false;
        }
    }
}

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
    public partial class hacimHesaplama : Form
    {
        public hacimHesaplama()
        {
            InitializeComponent();
        }

        private void hacimHesaplama_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            label1.Text = "Kenar Uzunluğu (a):";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Kenar Uzunluğu (a):";
            label2.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Taban Uzunluğu (a):";
            label2.Text = "Taban Genişliği (b):";
            label3.Text = "Yükseklik (h):";
            label2.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Taban Genişliği (a):";
            label2.Text = "Yükseklik (h):";
            label2.Visible = true;
            label7.Visible = true;
            label8.Visible=false; 
            label3.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Taban Yarıçapı (r):";
            label2.Text = "Yükseklik (h):";
            label2.Visible = true;
            label7.Visible = true;
            label8.Visible = false;
            label3.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Yarıçap (r):";
            label2.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Taban Yarıçapı (r):";
            label2.Text = "Yükseklik (h):";
            label2.Visible = true;
            label7.Visible = true;
            label8.Visible = false;
            label3.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = false;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sonuç;
            if (radioButton1.Checked)
            {
                sonuç = int.Parse(textBox1.Text) * int.Parse(textBox1.Text) * int.Parse(textBox1.Text);
                lblSonuç.Text = sonuç.ToString();
            }
            if (radioButton2.Checked)
            {
                sonuç = int.Parse(textBox1.Text) * int.Parse(textBox2.Text) * int.Parse(textBox3.Text);
                lblSonuç.Text = sonuç.ToString();
            }
            if (radioButton3.Checked)
            {
                sonuç = (int.Parse(textBox1.Text) * int.Parse(textBox1.Text)) / 3;
                lblSonuç.Text = sonuç.ToString();
            }
            if (radioButton4.Checked)
            {
                sonuç = (Math.PI * int.Parse(textBox1.Text) * int.Parse(textBox1.Text) * int.Parse(textBox2.Text)) / 3;
                lblSonuç.Text = sonuç.ToString();
            }
            if (radioButton5.Checked)
            {
                sonuç = (Math.PI * int.Parse(textBox1.Text) * int.Parse(textBox1.Text) * int.Parse(textBox1.Text) * 4) / 3;
                lblSonuç.Text = sonuç.ToString();
            }
            if (radioButton6.Checked)
            {
                sonuç = Math.PI * int.Parse(textBox1.Text) * int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                lblSonuç.Text = sonuç.ToString();
            }
        }
    }
}

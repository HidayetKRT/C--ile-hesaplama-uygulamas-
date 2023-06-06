using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class alanhesaplama : Form
    {
        public alanhesaplama()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "Dikdörtgen veya Kare";
            radioButton2.Text = "Üçgen";
            radioButton3.Text = "Daire";
            label1.Text = "Taban";
            label2.Text = "Yükseklik";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            label10.Visible = true;
            label2.Visible = true;
            label1.Text = "Taban";
            label2.Text = "Yükseklik";
            textBox2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            label10.Visible = true;
            label2.Visible = true;
            label1.Text = "Taban";
            label2.Text = "Yükseklik";
            textBox2.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            label10.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label1.Text = "Yarıçap";
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            
            
                if (radioButton1.Checked)
                {
                    double sonuç = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
                    label4.Text = sonuç.ToString();
                }
                if (radioButton2.Checked)
                {
                    double sonuç = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)) / 2;
                    label4.Text = sonuç.ToString();
                }
                if (radioButton3.Checked)
                {
                    double sonuç = Math.PI * (double.Parse(textBox1.Text) * double.Parse(textBox1.Text));
                    label4.Text = sonuç.ToString();
                }
            
        }
    }
}

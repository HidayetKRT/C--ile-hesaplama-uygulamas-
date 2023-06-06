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
    public partial class kmMilHesaplama : Form
    {
        public kmMilHesaplama()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "km";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "mil";
        }

        private void btbHesapla_Click(object sender, EventArgs e)
        {
            double sonuç;
            if (radioButton1.Checked)
            {
                sonuç = double.Parse(textBox1.Text) * 0.621371192;
                lblSonuc.Text = sonuç.ToString();
            }
            if (radioButton2.Checked)
            {
                sonuç = double.Parse(textBox1.Text) / 0.621371192;
                lblSonuc.Text = sonuç.ToString();
            }

        }
    }
}

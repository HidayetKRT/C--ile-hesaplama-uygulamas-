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
    public partial class yagorani : Form
    {
        public yagorani()
        {
            InitializeComponent();
        }

        private void btbHesapla_Click(object sender, EventArgs e)
        {
            double bel;
            double boyun;
            double boy;
            double kalça;
            double x, y;
            bel = double.Parse(textBoxBel.Text);
            boyun = double.Parse(textBoxBoyun.Text);
            boy = double.Parse(textBoxBoy.Text);
            if (radioButton1.Checked == true)
            {

                x = (1.0324 - (0.19077 * Math.Log10(bel - boyun))) + (0.15456 * Math.Log10(boy));
                y = (495 / x) - 450;

                if (y >= 10 && y <= 20)
                {
                    lblSonuç.Text = String.Format("Yağ ornınız {0:00,00}", Math.Round(y).ToString());


                }
                if (y <= 10)
                {
                    lblSonuç.Text = String.Format("Yağ oranınız {0:00,00}", Math.Round(y).ToString());
                }
                if (y <= 21)
                {
                    lblSonuç.Text = String.Format("Yağ oranınız {0:00,00}", Math.Round(y).ToString());
                }
            }
            if (radioButton2.Checked == true)
            {
                kalça = double.Parse(textBoxKalça.Text);
                x = (1.29579 - (0.35004 * Math.Log10(bel - boyun + kalça))) + (0.22100 * Math.Log10(boy));
                y = (495 / x) - 450;
                lblSonuç.Text = String.Format("Yağ ornınız {0:00,00}", Math.Round(y).ToString());
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKalça.ForeColor = Color.Red;
            textBoxKalça.Text = "Boş bırakınız!";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKalça.Text = "";
            textBoxKalça.ForeColor = Color.Black;
        }
    }
}

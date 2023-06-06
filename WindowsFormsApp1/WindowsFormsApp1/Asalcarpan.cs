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
    public partial class Asalcarpan : Form
    {
        public Asalcarpan()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi = Convert.ToInt32(textBox1.Text);

            // 2'nin kaç kere tam bölündüğünü bul
            int i = 2;
            while (sayi % i == 0)
            {
                sayi /= i;
                listBox1.Items.Add(i.ToString());
            }

            // Diğer asal çarpanları bul
            for (i = 3; i <= Math.Sqrt(sayi); i += 2)
            {
                while (sayi % i == 0)
                {
                    sayi /= i;
                    listBox1.Items.Add(i.ToString());
                }
            }

            // Eğer sayi hala 1'den büyükse, son asal çarpandır.
            if (sayi > 2)
            {
                listBox1.Items.Add(sayi.ToString());
            }
        }
    }
}

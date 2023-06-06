using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sayıtabandönüşümü : Form
    {
        public sayıtabandönüşümü()
        {
            InitializeComponent();
        }
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (comboBox1.SelectedItem.ToString() == "2 (İkili, Binary)" && comboBox2.SelectedItem.ToString() == "10 (Onlu, Decimal)")
            {
                if (IsBinary(input))
                {
                    int decimalNumber = Convert.ToInt16(textBox1.Text, 2);
                    lblSonuc.Text = decimalNumber.ToString();
                }
                else 
                {
                    MessageBox.Show("Girdiğiniz sayı sistemi yanlış", "Uyarı");
                }
                   
            }
            if(comboBox1.SelectedItem.ToString() == "2 (İkili, Binary)" && comboBox2.SelectedItem.ToString() == "16 (Onaltılı, Hexadecimal)")
            {
                if (IsBinary(input))
                {
                    int decimalNumber = Convert.ToInt16(textBox1.Text, 2);
                    string hexadecimalNumber = decimalNumber.ToString("X");
                    lblSonuc.Text = hexadecimalNumber;
                }
                else
                {
                    MessageBox.Show("Girdiğiniz sayı sistemi yanlış", "Uyarı");
                }
            }
            if(comboBox1.SelectedItem.ToString() == "16 (Onaltılı, Hexadecimal)" && comboBox2.SelectedItem.ToString() == "10 (Onlu, Decimal)")
            {
                if (IsHexadecimal(input))
                {
                    string hexNumber = textBox1.Text;
                    int decNumber = int.Parse(hexNumber, System.Globalization.NumberStyles.HexNumber);
                    lblSonuc.Text = decNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz sayı sistemi yanlış", "Uyarı");
                }
            }
            if(comboBox1.SelectedItem.ToString() == "16 (Onaltılı, Hexadecimal)" && comboBox2.SelectedItem.ToString() == "2 (İkili, Binary)")
            {
                if (IsHexadecimal(input))
                {
                    string hexNumber = textBox1.Text;
                    int decNumber = int.Parse(hexNumber, System.Globalization.NumberStyles.HexNumber);
                    string binaryNumber = Convert.ToString(decNumber, 2);
                    lblSonuc.Text = binaryNumber;
                }
                else
                {
                    MessageBox.Show("Girdiğiniz sayı sistemi yanlış", "Uyarı");
                }

            }
            if (comboBox1.SelectedItem.ToString() == "10 (Onlu, Decimal)" && comboBox2.SelectedItem.ToString() == "2 (İkili, Binary)")
            {
                if (IsDecimal(input))
                {
                    int decimalNumber = Convert.ToInt16(textBox1.Text);
                    string binaryNumber = Convert.ToString(decimalNumber, 2);
                    lblSonuc.Text = binaryNumber;
                }
                else
                {
                    MessageBox.Show("Girdiğiniz sayı sistemi yanlış", "Uyarı");
                }
            }
            if (comboBox1.SelectedItem.ToString() == "10 (Onlu, Decimal)" && comboBox2.SelectedItem.ToString() == "16 (Onaltılı, Hexadecimal)")
            {
                if (IsDecimal(input))
                {
                    int decimalNumber = Convert.ToInt16(textBox1.Text);
                    string hexNumber = decimalNumber.ToString("X");
                    lblSonuc.Text = hexNumber;
                    
                }
                else
                {
                    MessageBox.Show("Girdiğiniz sayı sistemi yanlış", "Uyarı");
                }
            }
        }
        private bool IsBinary(string input)
        {
            return input.All(c => c == '0' || c == '1');
        }

        private bool IsDecimal(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }

        private bool IsHexadecimal(string input)
        {
            return int.TryParse(input, System.Globalization.NumberStyles.HexNumber, null, out int result);
        }
    }
}

using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // SORU 1
        private void sayi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int val;
                if (txt_sayi.Text[0] == '-')
                {
                    txt_sign.Text = "1";
                    val = Convert.ToInt32(txt_sayi.Text.Substring(1));
                }
                else
                {
                    txt_sign.Text = "0";
                    val = Convert.ToInt32(txt_sayi.Text);
                }
                txtsayi_binary.Text = binaryHesaplayici(val);

            }
            catch
            {

            }
            int expSayisi, fracSayisi;
            int exp = 0, bias = 0, E = 0;
            try
            {
                expSayisi = Convert.ToInt32(txt_expsayi.Text);
                fracSayisi = Convert.ToInt32(txt_fracsayi.Text);

                // E, Exp, Bias Hesaplama
                bias = Convert.ToInt32(Math.Pow(2, (expSayisi - 1)) - 1);
                int binaryUzunlugu = txtsayi_binary.Text.Length;
                E = Convert.ToInt32(binaryUzunlugu) - 1;
                exp = E + bias;

                txt_EXP.Text = binaryHesaplayici(exp); // Convert.ToString(exp, 2);
                txt_FRAC.Text = txtsayi_binary.Text.Substring(1);
                for (int i = 0; i < fracSayisi - (binaryUzunlugu - 1); i++)
                {
                    txt_FRAC.Text += 0;
                }

            }
            catch
            {
                MessageBox.Show("EXP ya da FRAC'ta hata var!");
            }

        }
        private void txt_SayiKusur_TextChanged(object sender, EventArgs e)
        {
            // Kusur Hesaplama
            try
            {
                int val = Convert.ToInt32(txt_SayiKusur.Text);
                string smth = ".";
                double birlestirme = double.Parse($"{0}.{val}", CultureInfo.InvariantCulture);
                smth += binaryKusurHesaplayici(birlestirme);
                sayi_TextChanged(sender, e);
                txtsayi_binary.Text += smth;
            }
            catch (Exception)
            {

            }
        }
        string binaryHesaplayici(int num)
        {
            int i;
            string smth = "";
            int[] arr = new int[30];
            for (i = 0; num > 0; i++)
            {
                arr[i] = num % 2;
                num = num / 2;
            }
            for (i = i - 1; i >= 0 ; i--)
            {
               smth += arr[i];
            }
            return smth;
        }
        string binaryKusurHesaplayici(double num)
        {
            int Integral = (int)num;
            double fractional = num - Integral;
            string smth = "";
            while (fractional != 0)
            {
                fractional *= 2;
                int fract_bit = (int)fractional;

                if (fract_bit == 1)
                {
                    fractional -= fract_bit;
                    smth += (char)(1 + '0');
                }
                else
                {
                    smth += (char)(0 + '0');
                }
            }
            return smth;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string binarySayi = txt_sign.Text + txt_EXP.Text + txt_FRAC.Text;
            txt_Hex.Text = Convert.ToInt32(binarySayi, 2).ToString("X");
        }

        // SORU 2

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string smth = "";
                int sayi = Convert.ToInt16(txt_expsayi.Text);
                for (int i = 0; i < sayi; i++)
                {
                    smth += 1;
                }
                txt_EXP.Text = smth;
                smth = "";
                sayi = Convert.ToInt16(txt_fracsayi.Text);
                for (int i = 0; i < sayi; i++)
                {
                    smth += 0;
                }
                txt_FRAC.Text = smth;
            }
            catch (Exception)
            {
                MessageBox.Show("EXP veya FRAC sayısını girmedin galiba ha?..");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string smth = "";
                int sayi = Convert.ToInt16(txt_expsayi.Text);
                for (int i = 0; i < sayi; i++)
                {
                    smth += 1;
                }
                txt_EXP.Text = smth;
                smth = "";
                sayi = Convert.ToInt16(txt_fracsayi.Text);
                Random rnd = new Random();
                for (int i = 0; i < sayi; i++)
                {
                    smth += rnd.Next(2);
                }
                if (Convert.ToDouble(smth) == 0)
                {
                    MessageBox.Show("Ya çok şanssızsın ya da FRAC'ı çok küçük tuttun, bir daha basmayı dene butona");
                }
                else
                {
                    txt_FRAC.Text = smth;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("EXP veya FRAC sayısını girmedin galiba ha?..");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string smth = "";
                int sayi = Convert.ToInt16(txt_expsayi.Text);
                for (int i = 0; i < sayi; i++)
                {
                    smth += 0;
                }
                txt_EXP.Text = smth;
                smth = "";
                sayi = Convert.ToInt16(txt_fracsayi.Text);
                Random rnd = new Random();
                for (int i = 0; i < sayi; i++)
                {
                    smth += rnd.Next(2);
                }
                if (Convert.ToDouble(smth) == 0)
                {
                    MessageBox.Show("Ya çok şanssızsın ya da FRAC'ı çok küçük tuttun, bir daha basmayı dene butona");
                }
                else
                {
                    txt_FRAC.Text = smth;
                }
                string binarySayi = txt_sign.Text + txt_EXP.Text;
                txt10luk.Text = Convert.ToInt32(binarySayi, 2).ToString();
                binarySayi = txt_FRAC.Text;
                txt10luk.Text += "." + Convert.ToInt32(binarySayi, 2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("EXP veya FRAC sayısını girmedin galiba ha?..");
            }

        }

        // SORU 3
        int tasma = 0;
        private void button6_Click(object sender, EventArgs e)
        {

            int exp = 0, bias = 0, E = 0;
            int expSayisi = Convert.ToInt32(txt_expsayi.Text);
            int fracSayisi = Convert.ToInt32(txt_fracsayi.Text);

            bias = Convert.ToInt32(Math.Pow(2, (expSayisi - 1)) - 1);
            E = Convert.ToInt32(textBox2.Text)+tasma;
            exp = E + bias;
            txt_EXP.Text = binaryHesaplayici(exp);
            if (txt_EXP.Text.Length != expSayisi)
            {
                for (int i = 0; i < expSayisi - txt_EXP.Text.Length; i++)
                {
                    txt_EXP.Text = "0" + txt_EXP.Text;
                }
            }
            txt_FRAC.Text = "";
            try
            {
                if (txt_sign.Text == "1")
                {
                    for (int i = 0; i < fracSayisi; i++)
                    {
                        txt_FRAC.Text += textBox3.Text[3 + i];
                    }
                }
                else
                {
                    for (int i = 0; i < fracSayisi; i++)
                    {
                        txt_FRAC.Text += textBox3.Text[2 + i];
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int smth = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (textBox1.Text[i] == '.')
                    {
                        smth = i;
                        break;
                    }
                }
                if (textBox1.Text[0] == '-')
                {
                    txt_sign.Text = "1";
                    if (smth == 2)
                    {
                        textBox3.Text = "-" + textBox1.Text[1] + "." + textBox1.Text.Substring(3);
                    }
                    else
                    {
                        tasma = 1;
                        textBox3.Text = "-" + textBox1.Text[1] + "." + textBox1.Text.Substring(2, 1) + textBox1.Text.Substring(4);
                    }
                }
                else
                {

                    txt_sign.Text = "0";
                    if (smth == 1)
                    {
                        textBox3.Text = textBox1.Text[0] + "." + textBox1.Text.Substring(2);
                    }
                    else
                    {
                        tasma = 1;
                        textBox3.Text = textBox1.Text[0] + "." + textBox1.Text.Substring(1, 1) + textBox1.Text.Substring(3);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string binarySayi = textBox5.Text;
                textBox9.Text = Convert.ToInt32(binarySayi, 16).ToString();
            }
            catch (Exception)
            {

            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string binarySayi = textBox6.Text;
                textBox10.Text = Convert.ToInt32(binarySayi, 16).ToString();
            }
            catch (Exception)
            {

            }            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string smth = (Convert.ToInt32(textBox10.Text) * Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox9.Text) + Convert.ToInt32(textBox4.Text)).ToString();
                textBox12.Text = smth;
            }
            catch (Exception)
            {

            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            string binarySayi = textBox12.Text;
            textBox8.Text = Convert.ToInt32(binarySayi, 10).ToString("X");
        }
    }
}

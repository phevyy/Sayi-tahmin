using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NDP
{
    public partial class Form1 : Form
    {
        private int dusmanNumarasi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void YeniOyunBaslat()
        {
            Random rnd = new Random();
            dusmanNumarasi = rnd.Next(1, 101); 
            label2.Text = ""; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hedef;
            if (int.TryParse(textBox1.Text, out hedef))
            {
                
                if (hedef < 1 || hedef > 100)
                {
                    label2.Text = "Lütfen 1 ile 100 arasında bir sayı girin.";
                    return; 
                }

                if (hedef == dusmanNumarasi)
                {
                    label2.Text = "Tebrikler! Düşmanı vurmayı başardınız.";
                }
                else
                {
                    
                    DialogResult result = MessageBox.Show("Düşman kaçtı! Tekrar denemek ister misiniz?",
                                                          "Yanlış Tahmin",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        label2.Text = ""; 
                        textBox1.Clear(); 
                    }
                    else
                    {
                        label2.Text = "Oyun bitti. Tekrar başlatmak için formu kapatıp açabilirsiniz.";
                    }
                }
            }
            else
            {
                label2.Text = "Lütfen geçerli bir düşman numarası girin.";
            }
        }
    }
}
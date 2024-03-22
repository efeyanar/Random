using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Random rnd = new Random();
            int rasgele_sayi = rnd.Next(0,10);
            label1.Text = Convert.ToString(rasgele_sayi);

            int rasgele_sayi2 = rnd.Next(0, 10);
            label2.Text = Convert.ToString(rasgele_sayi2);

            int rasgele_sayi3 = rnd.Next(0, 10);
            label3.Text = Convert.ToString(rasgele_sayi3);

            int rasgele_sayi4 = rnd.Next(0, 10);
            label4.Text = Convert.ToString(rasgele_sayi4);

            int rasgele_sayi5 = rnd.Next(0, 10);
            label5.Text = Convert.ToString(rasgele_sayi5);

            int rasgele_sayi6 = rnd.Next(0, 10);
            label6.Text = Convert.ToString(rasgele_sayi6); */

            //_______________________________________________________________________________
            
            Random rnd2 = new Random();
            List<int> sayilar = new List<int>();
            List<int> tahmin = new List<int>();
            for(int i = 1; i<= 49; i++)
            {
                sayilar.Add(i);
            }
            for (int x = 1; x <= 6; x++)
            {
                int index = rnd2.Next(0, sayilar.Count);
                tahmin.Add(sayilar[index]);
                sayilar.RemoveAt(index);
            }
            tahmin.Sort();
            label1.Text = tahmin[0].ToString();
            label2.Text = tahmin[1].ToString();
            label3.Text = tahmin[2].ToString();
            label4.Text = tahmin[3].ToString();
            label5.Text = tahmin[4].ToString();
            label6.Text = tahmin[5].ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color[] renkler = new Color[8] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange, Color.White, Color.Pink, Color.Gray };

            Random rnd = new Random();

            int dizi = rnd.Next(0,8);
            this.BackColor = renkler[dizi];
        }
    }
}

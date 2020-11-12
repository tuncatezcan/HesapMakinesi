using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // form açılıyor olayı olduğunda çağırılan metot
            // Form1 kendine hitab ederken VB.net de me.Text, C# da this.Text diye hitab ediyor.
            // this.Text = "Merhaba Dünya";
            label1.Text = "merhaba dünya";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Label 1 e tıklandı";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = " label 1 e çift tıklandı";
        }

        private void FareUstuneGeldi(object sender, EventArgs e)
        {
            label1.Text = "Label 1 in üstüne fare geldi";
        }

        private void FareGitti(object sender, EventArgs e)
        {
            label1.Text = "Fare label üstünden gitti";
            // e olay argümanı
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "Bir tuşa basıldı";
            label1.Text += " " + e.KeyChar;
            // e basılan tuş olay argümanı
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            label1.Text = "form kapanıyor güle güle";
            MessageBox.Show("form kapanıyor güle güle");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc;
            sayi1 = float.Parse(textBox1.Text);
            sayi2 = float.Parse(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label1.Text = "Sonuç:" + sonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // txtbx1 ile txtbx2 ye girilen değerleri toplayıp label1 e gösterecek
            float sayi1, sayi2, sonuc;
            sayi1 = float.Parse(textBox1.Text);
            sayi2 = float.Parse(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label1.Text = "Sonuç:" + sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc;
            sayi1 = float.Parse(textBox1.Text);
            sayi2 = float.Parse(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label1.Text = "Sonuç:" + sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc;
            sayi1 = float.Parse(textBox1.Text);
            sayi2 = float.Parse(textBox2.Text);
            sonuc = (sayi2!=0) ? sayi1 / sayi2 : 0;
            label1.Text = "Sonuç:" + sonuc.ToString();
        }
        // sayi1 in karekökünü hesaplayan birer button ekleyiniz.
        private void button5_Click(object sender, EventArgs e)
        {
            double sonuc, sayi1;
            sayi1 = double.Parse(textBox1.Text);
            sonuc = Math.Sqrt(sayi1);
            label1.Text = "Sonuç:" + sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sonuc, sayi1, sayi2;
            sayi1 = double.Parse(textBox1.Text);
            sayi2 = double.Parse(textBox2.Text);
            sonuc = Math.Pow(sayi1, sayi2);
            label1.Text = "Sonuç:" + sonuc.ToString();
        }
        // üst alma

    }
}

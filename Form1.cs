using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İndirim_Tutarı_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(textBox1.Text);
            int fiyat = adet * 15;
            label5.Text = " " + fiyat;
            if (0<adet && adet < 21)
            {
                double indirim,toplam;
                indirim = (adet*15) * 20 / 100;
                label2.Text = " İndirim Tutarı: " + indirim;
                toplam = (adet * 15) - indirim;
                label8.Text = " " + toplam;
            }
            if(21<=adet && adet <= 40)
            {
                double indirim2,toplam2;
                indirim2 = (adet * 15) * 40 / 100;
                label2.Text = "İndirim Tutarı: " + indirim2;
                toplam2 = (adet * 15) - indirim2;
                label8.Text = " " + toplam2;
            }
            if (41 <= adet)
            {
                double indirim3,toplam3;
                indirim3 = (adet * 15) * 50 / 100;
                label2.Text = "İndirim Tutarı: " + indirim3;
                toplam3 = (adet * 15) - indirim3;
                label8.Text = " " + toplam3;
            }
        }
    }
}
// 0-20 20
// 21-40 40
// 41++  50
// kitap = 15
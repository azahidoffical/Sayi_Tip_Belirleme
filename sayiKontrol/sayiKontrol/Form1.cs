using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayiKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            lbSonuc.Items.Clear();

            int sayi = Convert.ToInt32(tbGirdi.Text);

            int toplam = 0;
            int bolenSayisi = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam += i;
                    bolenSayisi++;
                    lbSonuc.Items.Add(i);
                }
            }

            lbSonuc.Items.Add("---------------------------");

            // Mükemmel / Zengin / Eksik kontrolü
            if (toplam == sayi)
                lbSonuc.Items.Add($"{sayi} {"(Bölenlerin Toplamı: " + toplam+")"} MÜKEMMEL sayıdır.");
            else if (toplam > sayi)
                lbSonuc.Items.Add($"{sayi} {"(Bölenlerin Toplamı: " + toplam+")"} ZENGİN sayıdır.");
            else
                lbSonuc.Items.Add($"{sayi} {"(Bölenlerin Toplamı: " + toplam+")"} FAKİR sayıdır.");

            // Tek - Çift kontrolü
            if (sayi % 2 == 0)
                lbSonuc.Items.Add($"{sayi} ÇİFT sayıdır.");
            else
                lbSonuc.Items.Add($"{sayi} TEK sayıdır.");

            // Asallık kontrolü
            bool asal = true;
            if (sayi < 2) asal = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(sayi); i++)
                {
                    if (sayi % i == 0)
                    {
                        asal = false;
                        break;
                    }
                }
            }

            if (asal)
                lbSonuc.Items.Add($"{sayi} ASAL sayıdır.");
            else
                lbSonuc.Items.Add($"{sayi} ASAL değildir.");
        }
    }
}

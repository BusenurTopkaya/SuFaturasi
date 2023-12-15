using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuFaturasi
{
    public partial class Form1 : Form
    {
        List <String> AdiSoyadi = new List<String>();
        List <int> IlkIndex = new List<int>();
        List<int> SonIndex = new List<int>();
        List<int> Fatura = new List<int>();
        double MeskenBirimKupFiyati = 0.70;
        double UmumiBirimKupFiyati = 0.30;
        double MeskenAtikSuUcreti = 0.20;
        int sayi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtHesapla_Click(object sender, EventArgs e)
        {
            
            
            if (RbUmumi.Checked)
            {
                AdiSoyadi.Add(TbAdSoyad.Text);
                LbAdiSoyadi.Items.Add(AdiSoyadi[sayi]);
                IlkIndex.Add(Convert.ToInt32(TbIlkIndex.Text));
                SonIndex.Add(Convert.ToInt32(TbSonIndex.Text));
                int sumiktariHesaplama = SonIndex[sayi] - IlkIndex[sayi];
                LbSuMiktari.Items.Add(sumiktariHesaplama);
                double ToplamTuketimUcreti = sumiktariHesaplama * 0.3;
                ToplamTuketimUcreti = (ToplamTuketimUcreti + (((ToplamTuketimUcreti / 100) * 30)*0.2));
                LbFaturaTutari.Items.Add(ToplamTuketimUcreti);
            }
            else if (RbMesken.Checked)
            {
                AdiSoyadi.Add(TbAdSoyad.Text);
                LbAdiSoyadi.Items.Add(AdiSoyadi[sayi]);
                IlkIndex.Add(Convert.ToInt32(TbIlkIndex.Text));
                SonIndex.Add(Convert.ToInt32(TbSonIndex.Text));
                int sumiktariHesaplama = SonIndex[sayi] - IlkIndex[sayi];
                LbSuMiktari.Items.Add(sumiktariHesaplama);
                double ToplamTuketimUcreti = sumiktariHesaplama * 0.7;
                LbFaturaTutari.Items.Add(ToplamTuketimUcreti);
            }
            else
            {
                MessageBox.Show("Lütfen Umumi yada Mesken Seçiniz.");
                return;
            }
           
            sayi++;
            TbAdSoyad.Clear();
            TbIlkIndex.Clear();
            TbSonIndex.Clear();
           
        }
    }
}

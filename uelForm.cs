using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebakc___FIFA_Rebuild_Puan_Hesaplayıcı
{
    public partial class uelForm : Form
    {
        public uelForm()
        {
            InitializeComponent();
        }
        private void uelForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(uyari1, "Bölüşme sayısı kişisinde kendi oyuncunuzu da sayın. Örneğin sizin haricinizde 1 tane daha kişi varsa yazmanız" +
                " gereken sayı 2'dir. Hiç kimseyle bölüşmediyseniz 1 yazınız.");
        }

        private void hesaplaButon_Click(object sender, EventArgs e)
        {
            double toplamPuan = 0;
            double bolusumSayisi;



            //-------------LİG PUAN HESAPLAMA-----------------
            //Lig Sıralama
            switch (ligSiralamaCB.SelectedItem.ToString())
            {
                case "Birinci":
                    toplamPuan += 250;
                    break;
                case "İkinci":
                    toplamPuan += 100;
                    break;
                case "Üçüncü":
                    toplamPuan += 50;
                    break;
                case "Dördüncü":
                    toplamPuan += 25;
                    break;
                case "Beşinci+":
                    toplamPuan += 0;
                    break;
            }
            //Lig Gol Kralı
            switch (ligGolCB.SelectedItem.ToString())
            {
                case "Birinci":
                    bolusumSayisi = Convert.ToDouble(bolusumLigGolTB.Text);
                    toplamPuan += 20 / bolusumSayisi;
                    break;
                case "İkinci":
                    bolusumSayisi = Convert.ToDouble(bolusumLigGolTB.Text);
                    toplamPuan += 10 / bolusumSayisi;
                    break;
                case "Üçüncü":
                    bolusumSayisi = Convert.ToDouble(bolusumLigGolTB.Text);
                    toplamPuan += 5 / bolusumSayisi;
                    break;
                case "Dördüncü+":
                    toplamPuan += 0;
                    break;
            }
            //Lig Asist Kralı
            switch (ligAsistCB.SelectedItem.ToString())
            {
                case "Birinci":
                    bolusumSayisi = Convert.ToDouble(bolusumLigAsistTB.Text);
                    toplamPuan += 20 / bolusumSayisi;
                    break;
                case "İkinci":
                    bolusumSayisi = Convert.ToDouble(bolusumLigAsistTB.Text);
                    toplamPuan += 10 / bolusumSayisi;
                    break;
                case "Üçüncü":
                    bolusumSayisi = Convert.ToDouble(bolusumLigAsistTB.Text);
                    toplamPuan += 5 / bolusumSayisi;
                    break;
                case "Dördüncü+":
                    toplamPuan += 0;
                    break;
            }
            //Lig Kaleci Kralı
            switch (ligKaleciCB.SelectedItem.ToString())
            {
                case "Birinci":
                    bolusumSayisi = Convert.ToDouble(bolusumLigKaleciTB.Text);
                    toplamPuan += 20 / bolusumSayisi;
                    break;
                case "İkinci":
                    bolusumSayisi = Convert.ToDouble(bolusumLigKaleciTB.Text);
                    toplamPuan += 10 / bolusumSayisi;
                    break;
                case "Üçüncü":
                    bolusumSayisi = Convert.ToDouble(bolusumLigKaleciTB.Text);
                    toplamPuan += 5 / bolusumSayisi;
                    break;
                case "Dördüncü+":
                    toplamPuan += 0;
                    break;
            }
            //Lig Averaj+Puan Hesabı
            double ligapPuan = Convert.ToDouble(ligapTB.Text);
            toplamPuan += ligapPuan;
            //Lig Verim Hesabı
            double ligVerim = Convert.ToDouble(ligverimTB.Text);
            toplamPuan += ligVerim;

            //-----------------------------KUPALARIN HESABI-----------------------------
            //Fa Cup 
            switch (facupCB.SelectedItem.ToString())
            {
                case "Birinci":
                    toplamPuan += 50;
                    break;
                case "İkinci":
                    toplamPuan += 25;
                    break;
                case "Yarı Final":
                    toplamPuan += 10;
                    break;
                case "Çeyrek Final":
                    toplamPuan += 5;
                    break;
                case "Son16+":
                    toplamPuan += 0;
                    break;
            }
            //Carabao Cup 
            switch (carabaocupCB.SelectedItem.ToString())
            {
                case "Birinci":
                    toplamPuan += 50;
                    break;
                case "İkinci":
                    toplamPuan += 25;
                    break;
                case "Yarı Final":
                    toplamPuan += 10;
                    break;
                case "Çeyrek Final":
                    toplamPuan += 5;
                    break;
                case "Son16+":
                    toplamPuan += 0;
                    break;
            }

            //-----------------------------UEL HESAPLAMA-------------------------------------
            //Uel Sıralama
            switch (uelSiraCB.SelectedItem.ToString())
            {
                case "Birinci":
                    toplamPuan += 250;
                    break;
                case "İkinci":
                    toplamPuan += 120;
                    break;
                case "Yarı Final":
                    toplamPuan += 60;
                    break;
                case "Çeyrek Final":
                    toplamPuan += 30;
                    break;
                case "Son 16":
                    toplamPuan += 15;
                    break;
            }
            //Uel Gol Krallığı
            switch (uelGolCB.SelectedItem.ToString())
            {
                case "Birinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLGolTB.Text);
                    toplamPuan += 20 / bolusumSayisi;
                    break;
                case "İkinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLGolTB.Text);
                    toplamPuan += 10 / bolusumSayisi;
                    break;
                case "Üçüncü":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLGolTB.Text);
                    toplamPuan += 5 / bolusumSayisi;
                    break;
                case "Dördüncü+":
                    toplamPuan += 0;
                    break;
            }
            //Uel Asist Krallığı
            switch (uelAsistCB.SelectedItem.ToString())
            {
                case "Birinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLAsistTB.Text);
                    toplamPuan += 20 / bolusumSayisi;
                    break;
                case "İkinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLAsistTB.Text);
                    toplamPuan += 10 / bolusumSayisi;
                    break;
                case "Üçüncü":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLAsistTB.Text);
                    toplamPuan += 5 / bolusumSayisi;
                    break;
                case "Dördüncü+":
                    toplamPuan += 0;
                    break;
            }
            //Ucl Kaleci Krallığı
            switch (uelKaleciCB.SelectedItem.ToString())
            {
                case "Birinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLKaleciTB.Text);
                    toplamPuan += 20 / bolusumSayisi;
                    break;
                case "İkinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLKaleciTB.Text);
                    toplamPuan += 10 / bolusumSayisi;
                    break;
                case "Üçüncü":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLKaleciTB.Text);
                    toplamPuan += 5 / bolusumSayisi;
                    break;
                case "Dördüncü+":
                    toplamPuan += 0;
                    break;
            }

            //Ucl Elendiğin Takım Sıralaması
            switch (ueleltkCB.SelectedItem.ToString())
            {
                case "Birinci":
                    toplamPuan += 25;
                    break;
                case "Birinci değil":
                    toplamPuan += 0;
                    break;
            }

            //---------------------------UCL HESAPLAMALARI----------------------------------------
            //Ucl Gol Krallığı
            switch (uclGolCB.SelectedItem.ToString())
            {
                case "Birinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLGolTB.Text);
                    toplamPuan += 40 / bolusumSayisi;
                    break;
                case "İkinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLGolTB.Text);
                    toplamPuan += 20 / bolusumSayisi;
                    break;
                case "Üçüncü":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLGolTB.Text);
                    toplamPuan += 10 / bolusumSayisi;
                    break;
                case "Dördüncü+":
                    toplamPuan += 0;
                    break;
            }
            //Ucl Asist Krallığı
            switch (uclAsistCB.SelectedItem.ToString())
            {
                case "Birinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLAsistTB.Text);
                    toplamPuan += 40 / bolusumSayisi;
                    break;
                case "İkinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLAsistTB.Text);
                    toplamPuan += 20 / bolusumSayisi;
                    break;
                case "Üçüncü":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLAsistTB.Text);
                    toplamPuan += 10 / bolusumSayisi;
                    break;
                case "Dördüncü+":
                    toplamPuan += 0;
                    break;
            }
            //Ucl Kaleci Krallığı
            switch (uclKaleciCB.SelectedItem.ToString())
            {
                case "Birinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLKaleciTB.Text);
                    toplamPuan += 40 / bolusumSayisi;
                    break;
                case "İkinci":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLKaleciTB.Text);
                    toplamPuan += 20 / bolusumSayisi;
                    break;
                case "Üçüncü":
                    bolusumSayisi = Convert.ToDouble(bolusumUCLKaleciTB.Text);
                    toplamPuan += 10 / bolusumSayisi;
                    break;
                case "Dördüncü+":
                    toplamPuan += 0;
                    break;
            }
            

            //Hesapla Butonuna Basınca Ekrana Puanı Yazdırmak
            MessageBox.Show("Toplam Puan: " + toplamPuan.ToString(), "Puan Hesaplandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://www.github.com/ebakc") { UseShellExecute = true });
        }
    }
}

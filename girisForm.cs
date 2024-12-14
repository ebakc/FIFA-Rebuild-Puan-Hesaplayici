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
    public partial class girisForm : Form
    {
        public girisForm()
        {
            InitializeComponent();
        }

        private void girisForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(uclButton, "Rebuild yaptığınız takım UCL'de ilerlediyse bu butona basınız.");
            toolTip1.SetToolTip(uelButton, "Rebuild yaptığınız takım UEL'de ilerlediyse bu butona basınız.");
        }

        private void uclButton_Click(object sender, EventArgs e)
        {
            uclForm uclEkrani = new uclForm();
            uclEkrani.FormClosed += (s, args) => this.Show(); // uclForm kapandığında girisForm'u tekrar göster
            this.Hide(); // girisForm'u gizle
            uclEkrani.Show(); // uclForm'u aç
        }

        private void uelButton_Click(object sender, EventArgs e)
        {
            uelForm uelEkrani = new uelForm();
            uelEkrani.FormClosed += (s, args) => this.Show(); // uelForm kapandığında girisForm'u tekrar göster
            this.Hide(); // girisForm'u gizle
            uelEkrani.Show(); // uelForm'u aç
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://www.github.com/ebakc") { UseShellExecute = true });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LİG\r\n\r\n    Gol & Asist & Kaleci Lideri her biri için 20 puan\r\n    Verim: Her 1 verim için 1 puan\r\n    Sıralama Puanları(1-2-3-4): 250 - 100 - 50 - 25\r\n    Averaj + Puan: Her averaj ve puan için birer puan\r\n\r\nŞAMPİYONLAR LİGİ\r\n\r\n    Sıralama Puanları:\r\n        Birinci = 500\r\n        İkinci = 325\r\n        Yarı Final = 200\r\n        Çeyrek Final = 150\r\n        Son 16 = 75\r\n    Gruptan 1. Çıkmak: 30\r\n    Elendiğin Takım Kupayı Kazanırsa: 50\r\n    Gol & Asist & Kaleci Lideri her biri için 40 puan\r\n\r\n\r\nAVRUPA LİGİ\r\n\r\n    Sıralama Puanları:\r\n        Birinci = 250\r\n        İkinci = 120\r\n        Yarı Final = 60\r\n        Çeyrek Final = 30\r\n        Son 16 = 15\r\n    Elendiğin Takım Kupayı Kazanırsa: 25\r\n    Gol & Asist & Kaleci Lideri her biri için 20 puan\r\n\r\nFA & CARABAO CUP\r\n\r\n    Sıralama Puanları:\r\n        Birinci = 50\r\n        İkinci = 25\r\n        Yarı Final = 10\r\n        Çeyrek Final = 5",
                "Puan Listesi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

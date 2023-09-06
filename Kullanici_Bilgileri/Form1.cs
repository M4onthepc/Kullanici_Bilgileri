using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanici_Bilgileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sadece_sati_girisi(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://bio.ibb.istanbul/");
        }

        private void clean(object sender, EventArgs e)
        {
            txtGsm.Clear();
        }

        private void clean2(object sender, EventArgs e)
        {
            txtMeslek.Clear();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string ad, soyad, email, meslek, tc, gsm,egitimDurumu,calismaDurumu,
                engelDurumu,sehit_gaziBilgisi,deprem="",etkilenenIl=" ",paylasim;

            tc = txtTc.Text;
            ad=txtAd.Text;
            soyad=txtSoyad.Text;
            gsm=txtGsm.Text;
            email=txtEmail.Text;

            egitimDurumu = cmbEgitim.Text;
            calismaDurumu=cmbCalisma.Text;

            if (rdEngelyok.Checked=true)
            {
                engelDurumu = rdEngelyok.Text;
            }
            else if (rdOrtopedik.Checked=true)
            {
                engelDurumu=rdOrtopedik.Text;
            }
            else if (rdGorme.Checked=true)
            {
                engelDurumu = rdGorme.Text;
            }
            else if (rdIsitme.Checked = true)
            {
                engelDurumu = rdIsitme.Text;
            }
            else if (rdSuregen.Checked = true)
            {
                engelDurumu = rdSuregen.Text;
            }
            else
            {
                 engelDurumu=rdKonusmaGuclugu.Text;
            }

            meslek=txtMeslek.Text;

            if (rdYok.Checked=true)
            {
                sehit_gaziBilgisi=rdYok.Text;
            }
            else if (rdSehitYakini.Checked = true)
            {
                sehit_gaziBilgisi = rdSehitYakini.Text;
            }
            else if (rdGazi.Checked = true)
            {
                sehit_gaziBilgisi = rdGazi.Text;
            }
            else 
            {
                sehit_gaziBilgisi = rdGaziYakini.Text;
            }

            if (rdHayir.Checked=true)
            {
                deprem = rdHayir.Text;
               
            }
            else if(rdEvet.Checked=true)
            {
                deprem=rdEvet.Text;
            }
            etkilenenIl = cmbSehir.Text;


            if (rdIstemiyorum.Checked=true)
            {
                paylasim = rdIstemiyorum.Text;
            }
            else
            {
                paylasim = rdIstiyorum.Text;
            }


            listBilgiler.Items.Clear();

            listBilgiler.Items.Add("TC No : " + tc);
            listBilgiler.Items.Add("Ad : " + ad);
            listBilgiler.Items.Add("Soyad : " + soyad);
            listBilgiler.Items.Add("Gsm Numarası : " + gsm);
            listBilgiler.Items.Add("E-mail : " + email);
            listBilgiler.Items.Add("Eğitim Durumu : " + egitimDurumu);
            listBilgiler.Items.Add("Çalışma Durumu : " + calismaDurumu);
            listBilgiler.Items.Add("Engel Durumu : " + engelDurumu);
            listBilgiler.Items.Add("Meslek : " + meslek);
            listBilgiler.Items.Add("Şehit / Gazi Bilgisi : " + sehit_gaziBilgisi);
            listBilgiler.Items.Add("Depremden etkilenen bir il'den mi geliyor ? " + deprem);
            if (rdHayir.Checked=true)
            { }
            else
            {
                listBilgiler.Items.Add("Etkilediği il : " + etkilenenIl);

            }


            listBilgiler.Items.Add("Bilgileri'nin paylaşılmasını istiyor mu ? : " + paylasim);



        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace bbeOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void EkranSilme()
        {

            mskTxtBaslangic.Clear();
            mskTxtBaslangic.Text = "1"; 
            mskTxtBitis.Text = "10000";
            mskTxtBaslangic.Focus();
        }
        private void ListViewSilme()
        {
            listViewTek.Items.Clear();
            listViewCift.Items.Clear();
            listViewAsal.Items.Clear();
            listViewArmstrong.Items.Clear();
        }
            
        private void FonkTekSayilar()
        {
            int tekToplam = 0, tekCarpim = 1;
            int[] TekSayilar = new int[999999];
            
            for (int i = int.Parse(mskTxtBaslangic.Text); i < int.Parse(mskTxtBitis.Text); i++)
            {
                if(i % 2 == 1)
                {
                    TekSayilar[i] = i;
                    listeleTek("" + TekSayilar[i]);
                    tekToplam += TekSayilar[i];
                    tekCarpim *= TekSayilar[i];
                    
        
                }              
            }            
            listeleTek("Toplamı:" + tekToplam);
            listeleTek("Çarpımı:" + tekCarpim);
        }
         private void FonkCiftSayilar()
        {
            int ciftToplam = 0,ciftCarpim = 1;
            int[] CiftSayilar = new int[999999];
            for (int i = int.Parse(mskTxtBaslangic.Text); i<int.Parse(mskTxtBitis.Text); i++)
            {
                if(i % 2 == 0)
                {
                    CiftSayilar[i] = i;
                    listeleCift("" + CiftSayilar[i]);
                    ciftToplam += CiftSayilar[i];
                    ciftCarpim *= CiftSayilar[i];
                       
                }
            }
            listeleCift("Çift Sayıların Toplamı:" + ciftToplam);
            listeleCift("Çift Sayıların Çarpımı:" + ciftCarpim);
        } 

        private void FonkAsalSayilar()
        {
            int asalToplam = 0, asalCarpim = 1;         
            int baslangicSayi = int.Parse(mskTxtBaslangic.Text);
            int bitisSayi = int.Parse(mskTxtBitis.Text);
            for (int i= baslangicSayi; baslangicSayi <= bitisSayi; i++) 
            {
                int kontrol = 0;
                for (int k = 2; k<baslangicSayi;k++)
                {
                    if ((baslangicSayi % k) == 0)
                    {
                        kontrol = 1;
                        break;
                    }
                      if (kontrol != 1 && baslangicSayi != 1)
                      {
                        listeleAsal(" " + baslangicSayi);
                        asalToplam += baslangicSayi;
                        asalCarpim *= baslangicSayi;

                      }   
                }
            }
            listeleAsal("Asal Sayıların Toplamı:" + asalToplam);
            listeleAsal("Asal Sayıların Çarpımı:" + asalCarpim);
        }
        private void FonkArmstrongSayilar()
        {
            int armstrongToplam = 0, armstrongCarpim = 1;
            int[] armstrongSayılar = new int[999999];
            int baslangicSayi = int.Parse(mskTxtBaslangic.Text);
            int bitisSayi = int.Parse(mskTxtBitis.Text);
            for (int i = baslangicSayi; i <= bitisSayi; i++)
            {
                int a = i / 100;
                int b = (i - a * 100) / 10;
                int c = (i - a * 100 - b * 10);
                int d = a * a * a + b * b * b + c * c * c;
                if (i == d)
                {
                    armstrongSayılar[i] = i;
                    listeleArmstrong("" + armstrongSayılar[i]);
                    armstrongToplam += armstrongSayılar[i];
                    armstrongCarpim *= armstrongSayılar[i];
                }
            }
            listeleArmstrong("Armstrong Sayıların Toplamı:" + armstrongToplam);
            listeleArmstrong("Armstrong Sayıların Çarpımı:" + armstrongCarpim);
        }

        private void listeleTek(string gonder)
        {
            listViewTek.Items.Add(gonder);
            
        }
        private void listeleCift(string gonder)
        {
            listViewCift.Items.Add(gonder);
            
        }
        private void listeleAsal(string gonder)
        {
            listViewAsal.Items.Add(gonder);

        }
        private void listeleArmstrong(string gonder)
        {
            listViewArmstrong.Items.Add(gonder);
        }
        private void Loglama(string v)
        {
            StreamWriter logYaz = new StreamWriter(@"C:\\Log.txt");
            logYaz.WriteLine("Bunu yapamadım hocam.");
        }
        private void tabControl()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                FonkTekSayilar();
                                
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                FonkCiftSayilar();
            }
            else if(tabControl1.SelectedIndex == 2)
            {
                FonkAsalSayilar();
            }
            else if(tabControl1.SelectedIndex == 3)
            {
                FonkArmstrongSayilar();
            }
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            NotifyIcon hesaplaIcon = new NotifyIcon();
            hesaplaIcon.BalloonTipText = "Programa Hoşgeldiniz!";
            hesaplaIcon.Visible = true;
            hesaplaIcon.Text = "Bbe Ödev 1";
            hesaplaIcon.Icon = SystemIcons.Information;
            hesaplaIcon.ShowBalloonTip(2000);


        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            EkranSilme();

        }
        private void btnİleri_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex !=3 )
            {
                tabControl1.SelectedIndex += 1;
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex !=0)
            {
                tabControl1.SelectedIndex -= 1;
            }
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            tabControl();
            
        }

        private void btnListeTemizle_Click(object sender, EventArgs e)
        {
            ListViewSilme();
        }

    }
}

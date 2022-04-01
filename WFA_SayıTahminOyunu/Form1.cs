using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayıTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*

         Kullanıcının 5 hakkı olsun. Bilgisayar bir sayı tahmin etsin...Kullanıcı textbox'a sayı yazıp butona basarak bilgisayarın tahmin ettigi sayıyı bulmaya calıssın...Kullanıcı eger bilgisayarın tahmin ettigi sayıdan daha kücük veya büyük bir sayı yazmıssa MessaBox ile ona ipucu verilsin(daha büyük veya kücük sayı tahmin ediniz)...Eger kullanıcı bilgisayarın tahmin ettigi sayıyı bilirse oyunu kazandınız tekrar oynamak ister misiniz diye sorulsun...Kullanıcı eger evet derse programı bastan baslatma kodu Application.Restart()....Hayır derse programı kapatın...Eger kullanıcının hakları bitmişse kaybettiniz sayıyı bilemediniz diyerek program kapansın...Kullanıcının hakları sürekli olarak Form yazısında gözüksün...

         */

        Random rnd = new Random();
        int hak = 5, bilgisayarTahmini;

        private void Form1_Load(object sender, EventArgs e)
        {
            bilgisayarTahmini = rnd.Next(1, 11); // 1 dahil, 11 dahil değil.
            Text = hak.ToString(); // Form'un Text'inde yazacak.
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            try
            {
                int kullaniciTahmini = Convert.ToInt32(txtGiris.Text);

                if (kullaniciTahmini < bilgisayarTahmini)
                {
                    hak--;
                    Text = hak.ToString();
                    if (hak == 0)
                    {
                        DialogResult dr = MessageBox.Show("Kaybettiniz tekrar oynamak ister misiniz", "Kayıp", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            Application.Restart();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bilemediniz...Bilgisayar tahmini daha büyük");

                    }




                }
                else if (kullaniciTahmini > bilgisayarTahmini)
                {
                    hak--;
                    Text = hak.ToString();
                    if (hak == 0)
                    {
                        DialogResult dr = MessageBox.Show("Kaybettiniz.. Tekrar oynamak ister misiniz", "Kayıp", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            Application.Restart();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bilemediniz...Bilgisayar tahmini daha kücük");


                    }



                }
                else
                {
                    DialogResult dr = MessageBox.Show("Tebrikler...Sayıyı bildiniz...Tekrar oynamak ister misiniz?", "Zafer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }

         
            }
            catch (Exception ex)
            {


                MessageBox.Show($"Sistemsel hata {ex.Message}");
            }



        }
    
    }
}

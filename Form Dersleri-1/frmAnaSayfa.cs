using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Dersleri_1
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2 fr2 = new frm2(); //bu sınıfta yeni bir nesne üretiyorum
            fr2.Show(); //showdialog dersek yeni açılan sayfayı kapatmadan öncekinde işlem yapamıyorum, yalnızca show yazsaydım yenipencere açılsa da öncekilerde işlem yapabilirdim
            Hide(); //yeni pencere çıktığında bu gizlenecek demek oluyor
            //this.Hide(); desem de olurdu 
            //Close(); //yeni pencere çıktığında bu kapanacak demek oluyor
            //hide ve close u kullanmak için showdialog yerine show yazmak gerekiyor

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3 fr3 = new frm3();
            fr3.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //ya da bu kullanılabilir Environment.Exit(0);
            // Close(); anasayfaysa bunu yazarsak direk kapatır, anasayfa değilse sadece bulunduğu formu kapatır.
            // üst köşede kapatma tuşu var zaten öylesine gösteriyoruz bunu fnsdknfdkös

        }

        /*Tam Sayı Değişkenleri
         * 
         * byte:0-255
         * sbyte:-128 +127
         * short: -32768 +32767
         * int: -2.147.483.648 +2.147.483.647
         * long -9.... 49.... 19 basamaklı
         * ushort işaretsiz 0 ile 65535
         * uint 0 ile 4milyon
         * ulong 0 ile 18.446.. 20 basamaklı
         * 
         * 
         * Ondalıklı Sayı Değşkenleri
         * 
         * float 7 basamklı virgülden sonra ondalık yazacaksan sonuna f yazman gerek, virgülden sonrası yoksa f yazmana gerek yok
         * double 15-16 basamak
         * decimal 28-29 basm. sonuna m yazarsan
         * 
         * 
         * string
         * char
         * bool
         * const int
        */

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 15;
            string metin;
            metin = textBox1.Text;

            //textboxa int yazmak istersek alttaki gibi yapacağız
            //int.parse stringi inte dönüştürüyor
            //int.parse yerine convert.toint32 yazsak da aynısı olur
            //convert herkesi dönüştürüyor toint32 diyoruz çünkü int 32 bitlik bir veri türü, short olsasydı 16 olurdu, long olsa 64
            int sayi = int.Parse(textBox1.Text);
            label2.Text = sayi.ToString(); //ya da convert.tostring(sayi); yazabilirm

            //textboxa ne yazarsam göster butonuna basınca label2 de yazdığım çıkar

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181108SayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {//Klavyeden girilen sayıyı bilgisayardan tahmin ettirmeeye çalışan uygulama. Amaç girilen sayının uygulama tarafından kaçıncı denemesinde bulduğunu söylemek.
            Random rnd = new Random();// sayı tahmini için (sayı üretmek için) gerekli olan random sınıfının nesnesi
            Console.Write("Tahmin edilecek sayıyı girin: ");
            int sayi = int.Parse(Console.ReadLine());
            bool dongu = true;
            int sayac = 0, uretilenSayi;
            //do
            //{
            //    uretilenSayi = rnd.Next(0, 101);
            //    sayac++;
            //    if (uretilenSayi == sayi)
            //    {
            //        dongu = false;
            //    }

            //} while (dongu);// aşağıda daha pratiği var
            do
            {
                uretilenSayi = rnd.Next(0, 101);
                sayac++;
            } while (uretilenSayi!=sayi);


            Console.WriteLine($"{sayi} sayısı, {sayac}. denemede tahmin edildi.");
            Console.ReadKey();

        }
    }
}

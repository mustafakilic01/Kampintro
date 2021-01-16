using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Geliştirme Kampı";
            string kurs2 = "Programlamaya Giriş İçin Temel Kurs";
            string kurs3 = "Java";

            // arry -dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Geliştirme Kampı", "Programlamaya Giriş İçin Temel Kurs", "Java"
        };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");



        }
    }
}

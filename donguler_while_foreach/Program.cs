﻿
internal class Program
{
    private static void Main(string[] args)
    {
        
            // While
            // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalam hesaplayıp conosle a yazdıran program.
            //   Console.Write("Lütfen bir sayı giriniz: ");
            //   int sayi = int.Parse(Console.ReadLine());
            //   int sayac = 1;
            //   int toplam = 0;
            //   while (sayac <= sayi)
            //   {
            //       toplam += sayac;
            //       sayac ++;
            //
            //   }
            //   Console.WriteLine(toplam/sayi);

            // A dan Z ye kadar tüm harfleri console a yazdıralım.
            //  char character = 'a';
            //  while (character < 'z')
            //  {
            //      Console.Write(character);
            //      character ++;
            //  }

            Console.Write("***** Foreach *****");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        
    }
}
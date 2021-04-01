using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin=0;
            int sayac = 0;
            int hafiza;
            Random rastgele = new Random();
            hafiza = rastgele.Next(1, 100);
            while(tahmin != hafiza)
            {
                sayac++;
                Console.WriteLine("Sayi girin: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if(hafiza>tahmin)
                {
                    Console.WriteLine("Lütfen daha büyük sayi giriniz !!!\n");
                }
                else
                {
                    Console.WriteLine("Lütfen daha küçük sayi giriniz !!!\n");
                }
            }
            Console.WriteLine("Tebrikler...");
            Console.WriteLine("{0}.denemede buldunuz", sayac);
        }
    }
}

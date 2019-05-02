using System;

namespace algoritma2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];
            Random rnd = new Random();
            int diziToplami = 0, ortalamadanBuyuk = 0, ortalamadanKucuk = 0;
            double diziOrtalamasi = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 1000);
                diziToplami += dizi[i];
            }


            diziOrtalamasi = diziToplami / 20;
            foreach (var dizim in dizi)
            {
                if (dizim > diziOrtalamasi) ortalamadanBuyuk += 1;
                else ortalamadanKucuk += 1;
            }
            Console.WriteLine("ortalama = {0},ortalamadan buyuk eleman sayısı {1},ortalamadan kucuk eleman sayısı {2} ",diziOrtalamasi,ortalamadanBuyuk,ortalamadanKucuk);
            Console.ReadKey();
        }
    }
}

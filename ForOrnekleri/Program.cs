using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. kısım
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Kendime inanıyorum,ben bu yazılım işini hallederim!");

            }
            Console.WriteLine("--------------------------------------------------------");
            //2. kısım
            for (int i = 1; i < 20; i++)
            { Console.WriteLine(i); }

            Console.WriteLine("--------------------------------------------------------");
            //3. kısım
            for (int i = 2; i < 20; i += 2) // i yi 2 den başlatıp 2 arttırarak ekleme yaptım. if ile de yazılabilirdi. bu daha kolayıma geldiği için böyle tercih ettim
            { Console.WriteLine(i); }

            Console.WriteLine("--------------------------------------------------------");
            //4. kısım
            int sum = 0; // toplam değişkenini önden tanımladık

            for (int i = 50; i < 150; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            Console.WriteLine("--------------------------------------------------------");
            //5. kısım
            int evenSum = 0; //tek sayıların toplamını burada tutucaz
            int oddSum = 0; // çift sayıların toplamını burda tutucaz

            for (int i = 1; i < 120; i++)
            {
                if (i % 2 == 0) // if e girdik eğer sayı tekse evenSum değişkenine ekleyecek, çift ise oddSum değişkenine ekleyecek
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }
                Console.WriteLine("Çift sayıların toplamı: " + evenSum);
                Console.WriteLine("Tek sayıların toplamı : " + oddSum);
                Console.ReadKey();
            }
        }
    }


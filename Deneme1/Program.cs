using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme1
{
    class Program
    {
        static void Main()
        {
            Random rd = new Random();
            int []dizi = new int[20];
            int i = 0;
            int sayi,j;
            while (i < dizi.Length)
            {
                sayi = rd.Next(21);
                j = 0;
                while (j < dizi.Length)
                {
                    if (dizi[j] == sayi)
                    {
                        sayi = rd.Next(20);
                        j = -1;
                    }
                    j++;
                }
                    dizi[i] = sayi;
                    Console.Write($" {dizi[i]} ");
                    i++;
            }
            Console.ReadKey();
        }
    }
}

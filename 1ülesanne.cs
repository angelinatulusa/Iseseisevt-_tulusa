using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtöö_tulusa
{
    class _1ülesanne
    {
        static void Main(string[] args)
        {

            //Задано пять произвольных целых чисел (элементы массива). Определить, является ли их расположение в массиве упорядоченным (т.е. по возрастанию или по убыванию) или неупорядоченным.
            Random rnd = new Random();
            /*List<int> cisla = new List<int>(5);
            cisla.Add(rnd.Next(0, 20));*/
            int[] cisla = new int[5];
            int[] cisla2 = new int[5]; 
            cisla.CopyTo(cisla2);
            int p = 0;
            for (int i = 0; i < 5; i++)
            {
                if (cisla2[i]>cisla2[i-1])
                {
                    p = cisla2[i];
                    cisla2[i] = cisla2[i - 1];
                    cisla2[i - 1] = p;
                }
            }
            if (cisla==cisla2)
            {
                Console.Write("Elementi uporadoceni");
            }
            else
            {
                Console.Write("Elementi ne uporadoceni");
            }

        }

    }
}

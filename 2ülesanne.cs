using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtöö_tulusa
{
    class _2ülesanne
    {
        static void Main()
        {
            //Задан массив действительных чисел из N элементов (используйте генератор случайных чисел). Определить количество элементов, значения которых находятся вне диапазона от -10 до +10.
            int k = 0;
            int n = 0;
            int[] N_mass = new int[5];
            while (k!=5)
            {
                Console.WriteLine("vvedi cislo");
                n = int.Parse(Console.ReadLine());
                N_mass.Add(n);
                k++;
            }
            foreach (var item in N_mass)
            {
                for (int i = 0; i < length; i++)
                {

                }
            }


            /*int k = 0;
            for (int i = n; i < 5; i++)
            {
                N_mass[n] = i;
                k++;
            }
            foreach (var item in N_mass)
            {
                if (true)
                {

                }
            }*/

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtöö_tulusa
{
    class _2ülesanne
    {
        static void Main(string[] args)
        {
            //Задан массив действительных чисел из N элементов (используйте генератор случайных чисел). Определить количество элементов, значения которых находятся вне диапазона от -10 до +10.
            Random rnd = new Random();
            int s = 0;
            int kolvo = 0;
            Console.Write("Skolko znacenii v N? ");
            kolvo = int.Parse(Console.ReadLine());
            int[] N = new int[kolvo];

            for (var i = 0; i < kolvo; i++)
            {
                N[i] = rnd.Next(-20, 20);
                if (N[i] > -10 && N[i] < 10)
                {
                    s++;
                }
                
            }
            Console.WriteLine("Kol-vo elementov ot -10 do 10: {0}", s);
            Console.ReadKey();
            

        }
    }
}

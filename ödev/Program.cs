using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());

            int bolentoplam = 0;

            for (int i = 1; i < sayi; i++)
            {

                if (sayi % i == 0)
                {
                    bolentoplam = bolentoplam + i;
                }
               

            }
            if (bolentoplam == sayi)
            {
                Console.WriteLine(" Bu bir mükemmel sayıdır ");
            }
            else
            {
                Console.WriteLine(" Bu bir mükemmel sayı değildir ");
            }


        }
    }
}


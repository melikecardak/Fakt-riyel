using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktöriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sonuc = 1;

            Console.WriteLine("Bir sayı girin: ");
            number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= number; i++)
            {
                sonuc = sonuc * i;
            }

            Console.WriteLine("Girdiğiniz sayının faktöriyeli: " + sonuc);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwszy_plik
{
    class Program
    {
        static void Main(string[] args)
        {//string
            

            Console.WriteLine("program oblcizający pole prostokąta");
            Console.WriteLine("Podaj zmienną A");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj Zmienną B");

            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Pole prostokąta wynosi: " + a*b);



        
            Console.ReadKey();
        }


    }
}

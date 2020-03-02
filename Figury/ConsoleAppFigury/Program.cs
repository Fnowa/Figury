using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguryLibrary;

namespace ConsoleAppFigury
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat t1; //deklaracja zmiennej typu Trojkat
            t1 = new Trojkat();

            Trojkat t2 = new Trojkat(1, 2, 3);
            var t3 = new Trojkat(a: 1, b: 2, c: 2);

            Console.WriteLine(t1);           
            Console.WriteLine(t1.GetObwod());
            Console.WriteLine(t1.GetPole());

            Console.WriteLine(t2);
            Console.WriteLine(t2.GetObwod());
            Console.WriteLine(t2.GetPole());

            Console.WriteLine(t3);
            Console.WriteLine(t3.GetObwod());
            Console.WriteLine(t3.GetPole());
            

            
            
           

        }
    }
}

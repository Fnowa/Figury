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
        static void Main()
        {
            var t = new Triangle();
            Console.WriteLine(t);
            Console.WriteLine(t.Color);
            t.Print();

            var s = new Sphere(10);
            Console.WriteLine(s);
            Console.WriteLine(s.Surfice);
            //Console.WriteLine(s.Perimeter);

            var c = new Circle(1);
            var t1 = new Triangle(3, 4, 5);
            var s1 = new Sphere(2);

            List<Figure> lista;
            lista = new List<Figure>();
            lista.Add(t);
            lista.Add(s);
            lista.Add(c);
            lista.Add(t1);
            lista.Add(s1);
            lista.Add(new Circle(4));

            foreach( var f in lista)
            {
                Console.WriteLine(f);
            }
            
            var total = 0.0;
            foreach (var f in lista)
            {
                if(f is IMeasurable2D)
                {
                    total += ((IMeasurable2D)f).Surfice;
                    Console.WriteLine(f);
                }
                    
            }
            Console.WriteLine($"sumaryczne pole = {total}");
        }

        static void Main3()
        {
            Circle c = new Circle();
            Console.WriteLine(c);

            var c1 = new Circle(1.5);
            Console.WriteLine(c1);

            Console.WriteLine(c.Perimeter);
            Console.WriteLine(c1.Perimeter);
            Console.WriteLine(c.Surfice);
            Console.WriteLine(c1.Surfice);

            var t3 = c1.Scale(2);
            Console.WriteLine(t3);
        }


        static void Main2()
        {
            Triangle t = new Triangle();
            Console.WriteLine(t);

            var t1 = new Triangle(1.5, 1, 1);
            Console.WriteLine(t1);

            //var t2 = new Triangle(3);//reszta 1
            //Console.WriteLine(t2);

            var t3 = t1.Scale(2);
            Console.WriteLine(t3);
        }

        static void Main1(string[] args)
        {
            Trojkat t1; //deklaracja zmiennej typu Trojkat
            t1 = new Trojkat();

            Trojkat t2 = new Trojkat(2, 2, 3);
            var t3 = new Trojkat(3, 4, 5);

            Console.WriteLine(t1);           
            Console.WriteLine(t1.GetObwod());
            Console.WriteLine(t1.GetPole());

            Console.WriteLine(t2);
            Console.WriteLine(t2.GetObwod());
            Console.WriteLine(t2.Pole);

            Console.WriteLine(t3);
            Console.WriteLine(t3.GetObwod());
            Console.WriteLine(t3.GetPole());

            
            

            
            
           

        }


    }
}

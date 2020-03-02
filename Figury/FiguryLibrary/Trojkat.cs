using System;

namespace FiguryLibrary
{
    public class Trojkat
    {
        // dane obiektu - pola obiektu (fields)
        private double a; // this.a, this.b, this.c
        public double A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość musi być dodatnia");
                else
                    a = value;
                }
        }
        private double b;
        public double B
        {
            get => b;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość musi być dodatnia");
                else
                    b = value;
            }
        }
        private double c;
        public double C
        {
            get => c;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartość musi być dodatnia");
                else
                    c = value;
            }
        }
        // budow obiektu - konstruktor
        public Trojkat() // Trojkat() - konstruktor domyślny
        {
            a = b = c = 1.0;
        }
        public Trojkat(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            
        }

        //tekstowe reprezentacja obiektu
        public override string ToString()
        {
            return $"trójkąt(a: {a}, b: {b}, c: {c})";                      
        }

        //właściwości i metody

        public double GetObwod() // metoda zwracająca obwód tego trujkąta
        {
            return a + b + c;
        }

        public double Obwod => a + b + c; // property zwracająca obwód tego trujkąta

        public double GetPole()
        {
            var p = 0.5 * GetObwod(); // może być sam obwód
            var s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return s;
        }

        public double Pole
        {
            get
            {
                var p = 0.5 * Obwod;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
        }
            
    }
}

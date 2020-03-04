using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    /// <summary>
    /// Trókąt w wersji immutable
    /// </summary>
    public class Triangle : Figure
    {
        public double A { get; private set; } // A jest read-only
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a = 1, double b = 1, double c = 1)
        {
            if (a < 0 || b < 0 || c < 0 )
                throw new ArgumentOutOfRangeException("Boki mają być dodatnie");

            if (a + b <= c || b + c <= a || c + a <= b)
                throw new ArgumentException("Nie spełnia waruku trójkąta");
            A = a;
            B = b;
            C = c;
        }

        public override string ToString()
        {
            return $"Triangl({A},{B},{C})";
        }

        public double Perimeter => A + B + C;

        public Triangle Scale(double factor)
        {
            if (factor < 0)
                throw new ArgumentOutOfRangeException("Współczynnik musi być dodatni");

            return new Triangle(A * factor, B * factor, C * factor);
        }

        public override void Draw()
        {
            Console.WriteLine("rysowanie trójkąta");
        }
    }
}

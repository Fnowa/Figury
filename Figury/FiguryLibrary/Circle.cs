using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Circle : Figure, IMeasurable2D, IMeasurable1D 
    {
        public double R { get; private set; }

        public Circle(double r = 1)
        {
            if (r < 0)
                throw new ArgumentOutOfRangeException("Nie może być ujemne");
            R = r;
        }
        public override string ToString()
        {
            return $"circle({R})";
        }
        public virtual double Perimeter => 2 * R * Math.PI;

        public Circle Scale(double factor)
        {
            if (factor < 0)
                throw new ArgumentOutOfRangeException("Współczynnik musi być dodatni");

            return new Circle(R * factor);

        }

        public override void Draw()
        {
            Console.WriteLine("Rysowanie Kółka");
        }

        public virtual double Surfice => R * R * Math.PI;

        public double Lenght => Perimeter;
    }
}

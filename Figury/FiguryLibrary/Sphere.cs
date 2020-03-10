using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Sphere : Circle, IMeasurable2D
    {
        public Sphere(double r=1) : base(r) //nadpisuje r 
        {
            
        }

        public override string ToString()
        {
            return $"Sphere({R})";
        }

        public override double Surfice => 4 * base.Surfice;

        public new double Perimeter => throw new NotSupportedException("sfera nie ma obwodu");

        public new Sphere Scale(double factor)
        {
            if (factor < 0)
                throw new ArgumentOutOfRangeException("Współczynnik musi być dodatni");

            return new Sphere(R * factor);
        }
    }
}

using System;

namespace FiguryLibrary
{
    public class Trojkat
    {
        // dane obiektu - pola obiektu (fields)
        double a, b, c; // this.a, this.b, this.c

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
    }
}

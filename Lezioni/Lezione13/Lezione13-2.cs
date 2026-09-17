// qui tratto gli operators 

using System;

namespace Lezione13_2
{
    public class Frazione
    {
        public int Numeratore { get; set; }
        public int Denominatore { get; set; }

        public Frazione()
        {
            Numeratore = 0;
            Denominatore = 1;
        }

        public Frazione(int numeratore, int denominatore)
        {
            if (denominatore == 0)
                throw new ArgumentException("Il denominatore non può essere zero.");

            Numeratore = numeratore;
            Denominatore = denominatore;
        }

        public static bool operator ==(Frazione f1, Frazione f2)
        {
            // controllo se sono null
            if (f1 is null && f2 is null) return true;
            if (f1 is null || f2 is null) return false;

            return (f1.Numeratore == f2.Numeratore && f1.Denominatore == f2.Denominatore);
        }

        public static bool operator !=(Frazione f1, Frazione f2)
        {
            return !(f1 == f2);
        }

        public static Frazione operator +(Frazione f1, Frazione f2)
        {
            // regola: a/b + c/d = (a*d + c*b) / (b*d)
            return new Frazione(f1.Numeratore * f2.Denominatore + f1.Denominatore * f2.Numeratore, f1.Denominatore * f2.Denominatore);
        }

        public static Frazione operator -(Frazione f1, Frazione f2)
        {
            // // regola: a/b - c/d = (a*d - c*b) / (b*d)
            return new Frazione(f1.Numeratore*f2.Denominatore - f2.Numeratore * f1.Denominatore, f1.Denominatore*f2.Denominatore);
        }

        public static Frazione operator *(Frazione f1, Frazione f2)
        {
            return new Frazione(f1.Numeratore * f2.Numeratore, f1.Denominatore * f2.Denominatore);
        }

        public static Frazione operator /(Frazione f1, Frazione f2)
        {

            if (f2.Numeratore == 0)
            {
                throw new ArgumentException("Non puoi dividere per 0! (causa: denominatore di f2)");
            }
            return new Frazione(f1.Numeratore*f2.Denominatore, f1.Denominatore * f2.Numeratore);
        }

        public static bool operator <(Frazione a, Frazione b)
        {
             // a/b < c/d  equivale a  a*d < c*b  (quando i denominatori sono positivi)
            return a.Numeratore * b.Denominatore < b.Numeratore * a.Denominatore;
        }

        public static bool operator >(Frazione a, Frazione b)
        {
            return a.Numeratore * b.Denominatore > b.Numeratore * a.Denominatore;
        }

        public static bool operator <=(Frazione a, Frazione b)
        {
            return !(a > b);
            // potevo scrivere
            // return a.Numeratore * b.Denominatore <= b.Numeratore * a.Denominatore;
        }

        public static bool operator >=(Frazione a, Frazione b)
        {
            return !(a < b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Frazione f1 = new Frazione(1,2);
            Frazione f2 = new Frazione(1,2);

            System.Console.WriteLine(f1>f2);
        }
    }
}
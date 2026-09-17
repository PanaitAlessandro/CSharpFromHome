using System;

namespace Lezione13
{
    public class Frazione
    {
        public int Numeratore { get; set; }
        public int Denominatore { get; set; }

        public Frazione()
        {
            Numeratore = 0;
            Denominatore = 0;
        }

        public Frazione(int numeratore, int denominatore)
        {
            if (denominatore == 0)
                throw new ArgumentException("Il denominatore non può essere zero.");

            Numeratore = numeratore;
            Denominatore = denominatore;
        }

        public override string ToString()
        {
            return $"Numeratore: {Numeratore}, Denominatore: {Denominatore}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Frazione f = new Frazione()
            {
                Numeratore = 5,
                Denominatore = 4
            };

            System.Console.WriteLine(f);

            // ora trattiamo Equals 
            // la differenza da ==
            // == -> confronta il contenuto
            // Equals (ereditato da object) -> confronta l'identità

            Frazione f1 = new Frazione(1,2);
            Frazione f2 = new Frazione(1,2);
            System.Console.WriteLine(f1.Equals(f2)); // darà false

            // per confrontarli useremo l'operator ==  :D (creo una seconda lesson per evitare confusione)
        }
    }
}
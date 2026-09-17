// Cilindro -> punto e raggio (usiamo Has-A)

using System;
using System.Runtime.ConstrainedExecution;

namespace Esercizio2
{
    public class Cerchio
    {
        public double Bas {get; set;}

        public Cerchio() // defualt
        {
            Bas = 0.0;
        }

        public Cerchio(double bas)
        {
            Bas = bas;
        }
    }

    public class Cilindro
    {
        public Cerchio Bas {get; set;}
        public double Altezza {get; set;}

        public Cilindro()
        {
            Altezza = 0.0;
            Bas = new Cerchio(0.0);
        }

        public Cilindro(double altezza, Cerchio bas)
        {
            Altezza = altezza;
            Bas = bas;
        }

        public void Stampa()
        {
            System.Console.WriteLine($"Cerchio: {Bas.Bas}, Altezza: {Altezza}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            cilindro.Bas = new Cerchio(10.0);
            cilindro.Altezza=5.0;

            cilindro.Stampa();
        }
    }
}
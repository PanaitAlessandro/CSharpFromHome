using System;

namespace EsempioHasA
{
    public class Motore
    {
        public string Tipo { get; set; }

        public Motore()
        {
            Tipo = "";
        }

        public Motore(string tipo)
        {
            Tipo = tipo;
        }

        public void Avvia()
        {
            Console.WriteLine($"Il motore {Tipo} si è avviato. Vrum!");
        }
    }



    public class Automobile
    {
        public string Modello { get; set; }
        // Relazione HAS-A
        public Motore IlMotore { get; set; } 

        public Automobile()
        {
            Modello = "";
            IlMotore = new Motore();
        }

        public Automobile(string modello, string tipoMotore)
        {
            Modello = modello;
            IlMotore = new Motore(tipoMotore); 
        }

        public void Guida()
        {
            Console.WriteLine($"Guidando la {Modello}...");
            IlMotore.Avvia();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Automobile miaAuto = new Automobile("Tesla Model 3", "Elettrico");
            miaAuto.Guida();
        }
    }
}

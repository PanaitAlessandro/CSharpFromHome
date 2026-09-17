using System;

namespace Lezione10
{
    public class CMoto
    {
        public string Targa;
        public string Modello;
        public int Cilindrata;

        // default: costruttore

        public CMoto()
        {
            Targa = "";
            Modello = "";
            Cilindrata = 0;
        }

        public CMoto(string targa, string modello, int cilindrata)
        {
            Targa = targa;
            Modello = modello;
            Cilindrata = cilindrata;
        }
    }

            // esiste un secondo modo per i costruttori:

    public class Moto
    {
        public string Targa;
        public string Modello;
        public int Cilindrata;

        public Moto(string Targa, string Modello, int Cilindrata)
        {
            this.Targa = Targa;
            this.Modello = Modello;
            this.Cilindrata = Cilindrata;
        }

        public Moto() : this("", "", 0) {}
    }



    class Program
    {
        static void Main(string[] args)
        {
            CMoto moto = new CMoto();
            moto.Cilindrata = 50;
            moto.Modello = "Yamaha";
            moto.Targa = "ABC123US";


        }
    }
}
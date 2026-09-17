using System;

namespace Lezione12
{
    public class CMoto
    {
        private string _targa;
        private static int _numeromoto = 0;

        public string Targa
        {
            get => _targa;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il valore non è valido.");
                } 
                _targa = value;
            }
        }

        public static int numeroMoto
        {
            get => _numeromoto;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Il valore non può scendere sotto lo zero!");
                }
                _numeromoto = value;
            }
        }

        public CMoto()
        {
            Targa = "Sconosciuta";
            numeroMoto++;
        }

        public CMoto(string targa)
        {
            Targa = targa;
            numeroMoto++;
        }


    }


    class Program
    {
        // random fact: i really hate egocentric people, but I usually think I talk too much

        static void Main(string[] args)
        {
            CMoto moto = new CMoto();

            moto.Targa = "EGOCENTRIC";

            CMoto moto2 = new CMoto
            {
                Targa = "ABC!"
            };

            System.Console.WriteLine(CMoto.numeroMoto);
        }
    }
}
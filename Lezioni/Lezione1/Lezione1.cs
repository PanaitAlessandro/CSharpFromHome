using System;

namespace GestioneOfficina 
{

    class Program {

        static void Main(string[] args) {

            Console.WriteLine("Programma avviato");

            int eta = 18;
            double orario = 18.18;
            char lettera = 'A';
            string nome = "Alessandro";
            bool isValid = true;
            decimal prezzo = 195.87m; // usato per i SOLDI, molto preciso
            const double pi = 3.14;

            if (isValid && !(prezzo == 295.87m))
            {
                System.Console.WriteLine("Successo!");
            }

            System.Console.WriteLine("Inserisci il tuo nome");
            string input = Console.ReadLine();

            System.Console.WriteLine("Inserisci la tua eta");
            bool validazioneEta = int.TryParse(Console.ReadLine(), out int etaa);

            if(validazioneEta)
            {
                         Console.WriteLine($"Ciao {input}, hai {etaa} anni");   
            } else
            {
                System.Console.WriteLine("Eta non valida");
            }

            double dmdm = 9.99;

            int imim = (int)dmdm; 
            System.Console.WriteLine(imim); // 9

            int emem = (int)Math.Round(dmdm);
            System.Console.WriteLine(emem); // 10
        }

    }

}
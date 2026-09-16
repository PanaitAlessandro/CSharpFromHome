using System;

namespace Lezione2
{
    class Program
    {
        static void Main(string[] args)
        {
            int eta = 17;

            bool puoEntrare = (eta >=18) ? true : false;
            System.Console.WriteLine(puoEntrare);

                   // switch

        int giorno = 3;
        string giornata;

        switch(giorno)  {
            case 1:
                giornata = "Lunedi";
                break;
            case 2:
                giornata = "Martedi";
                break;
            case 3:
                giornata = "Mercoledi";
                break;
            default:
                giornata ="Non valida";
                break;
        
        }

        System.Console.WriteLine(giornata);

        for (int i = 0; i < giorno; i++)
            {
                System.Console.WriteLine(i);
            }

        // matrice con 2 for

        for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    System.Console.WriteLine($"{m},{n}");
                }
            }

        
            int contatore = 0;
            while(contatore < 5)
            {
                System.Console.WriteLine("Roberto e Sofia.");
                contatore++;
            }

            System.Console.WriteLine("Inserisci un numero: ");
            bool validaa = int.TryParse(Console.ReadLine(), out int num);
            while(!validaa || (num < 0 && num < 100))
            {
                System.Console.WriteLine("Inserisci un numero: ");
                validaa = int.TryParse(Console.ReadLine(), out num);
            }

            System.Console.WriteLine($"Numero: {num}");


            int scelta;
            do
            {
                System.Console.WriteLine("1. ORDINAZIONI\n2.SCELTA\n3.ESCI");
                System.Console.WriteLine("Seleziona Un'opzione");
                bool valid = int.TryParse(Console.ReadLine(), out scelta);
            } while (scelta != 3);

        }

    }
}
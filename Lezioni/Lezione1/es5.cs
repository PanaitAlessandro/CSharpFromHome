/*
Scrivi un'espressione che usa lo short-circuit di &&: due variabili bool, e dimostra (con un commento) perché in a && MetodoCheStampaQualcosa() 
il metodo non viene chiamato se a è false. Serve un metodo separato che stampa qualcosa quando chiamato, per provare che NON viene eseguito.
*/

using System;

namespace Esercizio5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = false;

            if (a && MetodoCheStampaQualcosa())
            {
                System.Console.WriteLine("OK!");
            } else
            {
                System.Console.WriteLine("Baco");
            }
        }

        static bool MetodoCheStampaQualcosa()
        {
            System.Console.WriteLine("Ciao!");
            return true;
        }
    }
}
/*

params: scrivi un metodo double Media(params double[] numeri) che calcola la media aritmetica.
 Deve gestire correttamente anche il caso di zero argomenti senza crashare (pensa a cosa succederebbe dividendo per zero elementi, 
 e gestiscilo esplicitamente).

*/

using System;

namespace Esercizio4
{
    class Program
    {

        static double Media(params double[] numeri)
        {
            double media = 0.0;

            if(numeri.Length == 0)
            {
                System.Console.WriteLine("Zero Numeri, Errore!");
                return 0.0;
            }    


            for(int i = 0; i < numeri.Length; i++)
            {
                media += numeri[i];
            }

            media /= numeri.Length;

            return media;
        }

        static void Main()
        {
            double[] numeri = {2.5, 4.0, 2.0, 10.0};
            double mediaVuota = Media();   // nessun argomento
        Console.WriteLine(mediaVuota);

            double media = Media(numeri);

            System.Console.WriteLine(media);
        }
    }
}
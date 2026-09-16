/*
break vs continue dimostrati insieme: scorri con un for i numeri da 1 a 50. Salta (con continue) tutti i multipli di 3. 
Fermati completamente (con break) appena incontri un numero maggiore di 30. Stampa ogni numero che non viene saltato né causa l'uscita. 
Commenta nel codice quale riga fa cosa.

*/

using System;

namespace Esercizio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // break

        for (int i = 1; i <= 50; i++)
{
    if (i > 30)
        break;              // esce definitivamente dal ciclo appena i supera 30

    if (i % 3 == 0)
        continue;           // salta la stampa per questo numero, va al successivo

    Console.WriteLine(i);   // stampa solo i numeri che sopravvivono a entrambi i controlli
}


        }
    }
}
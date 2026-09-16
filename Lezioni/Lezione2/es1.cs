/*
Voto in lettere: leggi un intero da input con TryParse (gestisci l'input non valido). 
Usa if/else if/else per stampare: "Ottimo" (≥9), "Buono" (7-8), "Sufficiente" (6), "Insufficiente" (<6).
 Attenzione all'ordine delle condizioni, spiegato in 2.1.
*/

using System;

namespace Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("numero: ");
            bool valido = int.TryParse(Console.ReadLine(), out int voto);

            while (!valido || (voto < 1 || voto > 10))
            {
                System.Console.WriteLine("numero: ");
                valido = int.TryParse(Console.ReadLine(), out voto);
            }

            if (voto >=9)
            {
                System.Console.WriteLine("Ottimo");
            } else if (voto >= 7 && voto <=8)
            {
                System.Console.WriteLine("Buono");
            } else if(voto == 6)
            {
                System.Console.WriteLine("Sufficiente");
            } else
            {
                System.Console.WriteLine("Insufficiente");
            }
            
        }
    }
}
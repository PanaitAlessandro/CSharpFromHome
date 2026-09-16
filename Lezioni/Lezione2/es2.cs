/*
Menu con switch espressione: leggi un carattere ('a', 'b', 'c') e usa uno switch expression (non lo statement classico) 
per assegnare a una stringa il nome di un'operazione ('a' → "Addizione", 'b' → "Sottrazione", 'c' → "Moltiplicazione", altro → "Operazione sconosciuta"). 
Stampa il risultato.
*/

using System;

namespace Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Inserisci carattere: ");
            bool valido = char.TryParse(Console.ReadLine(), out char carattere);

            while(!valido)
            {
              System.Console.WriteLine("Inserisci carattere: ");
              valido = char.TryParse(Console.ReadLine(), out carattere);  
            }
/*
            switch(carattere)
            {
                case 'a':
                    System.Console.WriteLine("Addizione");
                    break;
                case 'b':
                    System.Console.WriteLine("Sottrazione");
                    break;
                case 'c':
                    System.Console.WriteLine("Moltiplicazione");
                    break;
                default:
                    System.Console.WriteLine("Operazione sconosciuta");
                    break;
            }
            */

            string operazione = carattere switch
            {
                'a' => "Addizione",
                'b' => "Sottrazione",
                'c' => "Moltiplicazione",
                 _ => "Operazione non conosciuta"


            };

            System.Console.WriteLine(operazione);
        }
    }
}
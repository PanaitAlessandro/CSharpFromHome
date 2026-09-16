/*
Dichiara const double IVA = 0.22; e, dato un prezzo letto da input, calcola e stampa il prezzo finale con IVA inclusa.
*/

using System;

namespace Esercizio3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double IVA = 0.22;

            System.Console.WriteLine("Inserisci prezzo Finale del Prodotto: ");
            bool verificaPrezzo = decimal.TryParse(Console.ReadLine(), out decimal prezzo);

            if (verificaPrezzo)
            {
                decimal prezzoFinale = prezzo * (1 + (decimal)IVA);
                System.Console.WriteLine(prezzoFinale);
            }
        }
    }
}
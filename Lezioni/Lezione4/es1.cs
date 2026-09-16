/*
Array base: dichiara un array di 8 interi scritti a mano nel codice (a tua scelta, non ordinati). 
Stampali tutti con un for mostrando indice e valore ("Posizione 0: 15" ecc.), poi stampali di nuovo con un foreach mostrando solo i valori.
*/

using System;
using System.Net;

namespace Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = {12,5,10,2,5,1,0,1};

            for(int i = 0; i < numeri.Length; i++)
            {
                System.Console.WriteLine($"Posizione {i}: {numeri[i]}");
            }

            foreach (int numero in numeri)
            {
                System.Console.WriteLine(numero);
            }
        }
    }
}
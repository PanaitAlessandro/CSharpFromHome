/*
Ricorsione somma di un array: scrivi un metodo ricorsivo int SommaArray(int[] numeri, int indice) che somma 
tutti gli elementi di un array senza usare for/foreach, solo ricorsione (il parametro indice tiene traccia di dove sei arrivato, 
 il caso base è quando superi l'ultimo indice). Questo esercizio è ponte diretto verso gli algoritmi su vettori dell'Unità B — prendilo sul serio.
*/

using System;

namespace Esercizio7
{
    class Program
    {
        static int SommaArray(int[] numeri, int indice)
        {
            if(indice == numeri.Length) return 0;

            return numeri[indice] + SommaArray(numeri, indice+1);

        }

        static void Main(string[] args)
        {
            int[] numeri = {2,3,4};
            int indice = 0;

            int ris = SommaArray(numeri, indice);
            System.Console.WriteLine(ris);
        }
    }
}
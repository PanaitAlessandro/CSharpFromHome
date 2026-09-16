/*
Ricerca binaria, implementala tu: scrivi int RicercaBinaria(int[] array, int valore)
 su un array ordinato di almeno 10 elementi scritto a mano. Testala su tre casi: valore all'inizio dell'array, valore alla fine, valore assente.
*/

using System;

namespace Esercizio3
{
    class Program
    {
        static int RicercaBinaria(int[] array, int valore)
        {
            int sx = 0;
            int dx = array.Length-1;

            while(sx <= dx)
            {
                int centro = (sx+dx) / 2;

                if (array[centro] == valore)
                {
                    return centro;
                }

                if (array[centro] < valore)
                {
                    sx = centro+1;
                }

                if (array[centro] > valore)
                {
                    dx = centro-1;
                }
            }
            return -1;
        }
    }
}
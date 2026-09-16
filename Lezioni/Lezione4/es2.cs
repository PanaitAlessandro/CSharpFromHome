/*
Ricerca sequenziale, implementala tu: scrivi int RicercaSequenziale(int[] array, int valore) da zero 
(non copiare dalla lezione, riscrivila capendo ogni riga). Testala su un array con un valore presente e uno assente, 
stampando i due risultati (uno deve dare un indice valido, l'altro -1).
*/

using System;
using System.Reflection.Metadata.Ecma335;

namespace Esercizio2
{
    class Program
    {
        static int RicercaSequenziale(int[] array, int valore)
        {
            if (array[i] == valore)
            {
                return array[i];
            }
            return -1;
        }
    }
}
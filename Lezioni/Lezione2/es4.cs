/*
Matrice di asterischi (nested for): chiedi due interi righe e colonne, stampa un rettangolo di * con quelle dimensioni usando due for annidati
(un Console.Write("*") nel ciclo interno, un Console.WriteLine() dopo il ciclo interno per andare a capo).

*/

using System;

namespace Esercizio4
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Numero righe: ");
            bool valida = int.TryParse(Console.ReadLine(), out int righe);
            System.Console.WriteLine("Numero colonne: ");
            bool valida2 = int.TryParse(Console.ReadLine(), out int colonne);

            while (!valida || !valida2 || righe < 1 || colonne < 1)
            {
                System.Console.WriteLine("Numero righe: ");
                  valida = int.TryParse(Console.ReadLine(), out  righe);
                 System.Console.WriteLine("Numero colonne: ");
                  valida2 = int.TryParse(Console.ReadLine(), out  colonne);
            }
/* metodo inefficiente:
            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    if(j >= colonne-1) {
                    System.Console.Write("*\n");
                    } else
                    {
                        System.Console.Write("*");
                    }
                }
            }
            */

            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    System.Console.Write("*");
                }

                System.Console.WriteLine();
            }
        }
    }
}
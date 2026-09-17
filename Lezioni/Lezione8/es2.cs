using System;

namespace Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somma tra due matrici (elemento per elemento) 
            // mettiamo su supposizione che le due matrici abbiano la stessa forma (numeri di righe e colonne)

            int[,] matrice1 =
            {
                {1,2},
                {5,6}
            };

            int[,] matrice2 =
            {
                {1,2},
                {5,6}
            };

            int[,] elemento = new int[matrice1.GetLength(0), matrice2.GetLength(1)];

            for (int i = 0; i < matrice1.GetLength(0); i++)
            {
                for (int j = 0; j < matrice2.GetLength(1); j++)
                {
                    elemento[i,j] = (matrice1[i,j]+matrice2[i,j]);
                }
            }

            for (int i = 0; i < elemento.GetLength(0); i++)
            {
                for (int j = 0; j < elemento.GetLength(1); j++)
                {
                    System.Console.Write($"{elemento[i,j]} ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
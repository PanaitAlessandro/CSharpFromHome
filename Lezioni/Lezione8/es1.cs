using System;

namespace Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //somma di tutti gli elementi 

            int[,] matrice =
            {
                {1,2},
                {5,6}
            };

            int somma = 0;

            for(int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    somma += matrice[i,j];
                }
            }
            System.Console.WriteLine(somma);
        }
    }
}
using System;

namespace Lezione8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrice = new int[3,3];

            matrice[1,2] = 2;
            matrice[0,0] = 99;

            // array di array: jagged

            int[][] jagged = new int[4][];

            jagged[0] = new int[4]; // 4 colonne alla riga 0
            jagged[1] = new int[2]; // 2 colonne alla riga 1

            jagged[0][0] = 99;

            int righe = matrice.GetLength(0); // righe
            int colonne = matrice.GetLength(1); // colonne

            int righe1 = jagged.Length;
            int colonne1 = jagged[0].Length;
            System.Console.WriteLine(colonne1);

            // scorriamo una matrice

            for (int riga = 0; riga < matrice.GetLength(0); riga++)
            {
                for (int colonna = 0; colonna < matrice.GetLength(1); colonna++)
                {
                    System.Console.Write($"{matrice[riga, colonna]} ");
                }
            }

            bool[,] matbool =
            {{ true,true,true},
            {false,false,false},
            {true,false,true}
            };

            
        }
    }
}
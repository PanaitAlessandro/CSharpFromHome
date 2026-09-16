/*
Tabellina: chiedi un numero n da input, stampa la tabellina di n da 1 a 10 usando un for (n x 1 = ... fino a n x 10 = ...).
*/

using System;

namespace Esercizio3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Insersci un numero n: ");
            bool valido = int.TryParse(Console.ReadLine(), out int num);

            while(!valido || num < 0)
            {
                System.Console.WriteLine("Insersci un numero n: ");
             valido = int.TryParse(Console.ReadLine(), out  num);
            }

            for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} x {i} = {num * i}");
                }
        }
    }
}
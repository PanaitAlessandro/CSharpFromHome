/*
Overload: scrivi tre versioni di un metodo Massimo, una per due int, una per tre int, una per due double. 
Chiamale tutte da Main con valori diversi e stampa i risultati.
*/

using System;

namespace Esercizio1
{

    class Program {
    
    static int Massimo(int a, int b)
        {
            if (a>b)
            {
                return a;
            } else if(b>a)
            {
                return b;
            } else
            {
                return a; // uguali
            }
        }

        static int Massimo(int a, int b, int c)
        {
            int[] array = {a,b,c};
            int max = a;

            for(int i = 1; i < 3; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static double Massimo(double a, double b)
        {
            if (a>b)
            {
                return a;
            } else if(b>a)
            {
                return b;
            } else
            {
                return a; //uguali
            }
        }


        static void Main(string[] args)
        {
            int m1 = Massimo(2,3);
            int m2 = Massimo(2,3,4);
            double m3 = Massimo(2.0, 3.0);

            System.Console.WriteLine($"{m1}, {m2}, {m3}");
        }

 }
}
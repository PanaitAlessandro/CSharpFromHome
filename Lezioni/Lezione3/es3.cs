/*
out multiplo: scrivi un metodo void StatisticheArray(int[] numeri, out int somma, out int massimo, out int minimo) che calcola le tre statistiche in un solo scorrimento
 (un solo foreach o for, non tre separati). 
 Prova con un array di almeno 5 numeri scritti a mano nel codice (int[] numeri = {12, 4, 56, 8, 23};).
*/

using System;

namespace Esercizio3
{
    class Program
    {
        static void StatisticheArray(int[] numeri, out int somma, out int massimo, out int minimo)
        {
            massimo = numeri[0];
            minimo = numeri[0];
            somma = 0;
            for (int i = 0; i < numeri.Length; i++)
            {
                somma += numeri[i];

                if(numeri[i] > massimo)
                {
                    massimo = numeri[i];
                }

                if (numeri[i] < minimo)
                {
                    minimo = numeri[i];
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numeri = {2,3,4,5,6};
            int somma = 0;
            int massimo = 0;
            int minimo = 0;

            StatisticheArray(numeri, out somma, out massimo, out minimo);
            System.Console.WriteLine($"{somma}, {massimo}, {minimo}");
        }
    }
}
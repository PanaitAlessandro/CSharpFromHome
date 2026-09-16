/*
Ricorsione potenza: scrivi un metodo ricorsivo int Potenza(int base_, int esponente) che calcola base_ elevato a esponente senza usare Math.Pow, solo ricorsione. 
Identifica tu il caso base (indizio: cosa vale qualsiasi numero elevato a 0?) e il caso ricorsivo. Commenta nel codice qual è il caso base e qual è quello ricorsivo.
*/

using System;
namespace Esercizio6
{
    class Program
    {
        static int Potenza(int base_, int esponente)
        {
            if(esponente == 0) return 1; // caso base

            return base_ * Potenza(base_, esponente-1); // caso esponente
        }

        static void Main(string[] args)
        {
            int bas = 5;
            int esponente = 2;

            int ris = Potenza(bas, esponente);
            System.Console.WriteLine(ris);
        }
    }
}
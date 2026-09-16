using System;
using System.IO;

namespace Esercizio1
{
    class Program
    {
        // salvare e ricaricare un array di numeri

        static void Salva(int[] numeri)
        {
            using (StreamWriter scrittore = new StreamWriter("numeri.txt")) {

            for (int i = 0; i < numeri.Length; i++)
            {
                scrittore.WriteLine(numeri[i]);
            }
          }
        }

        static int[] Ricarica()
        {
            string[] righeTesto = File.ReadAllLines("numeri.txt");
            int[] numeriCaricati = new int[righeTesto.Length];

            for (int i = 0; i < numeriCaricati.Length; i++)
            {
                numeriCaricati[i] = int.Parse(righeTesto[i]);
            }

            return numeriCaricati;
        }
    }
}
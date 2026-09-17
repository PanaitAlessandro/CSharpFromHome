using System;
using System.IO;

namespace Esercizio3
{
    class Program
    {

        static void Scrivi(int numeroNomi)
        {

            string[] nomi = new string[numeroNomi];

            for (int i = 0; i < numeroNomi; i++)
            {
                System.Console.WriteLine($"Inserisci nome {i}: ");
                nomi[i] = Console.ReadLine();
            }

            File.WriteAllLines("studenti.txt", nomi);
            

        // scrivi un programma che prende i nomi di studenti, inseriscili in studenti.txt

        }

        static void ScriviOttimizzato(int numeroNomi)
        {

            using (StreamWriter sw = new StreamWriter("studenti.txt"))
            {
                

                for (int i = 0; i < numeroNomi; i++)
                {
                    System.Console.WriteLine($"Inserisci nome {i}: ");
                    string nome = Console.ReadLine();
                    sw.WriteLine(nome);
                }
            }
        }

        static void Main(string[] args)
        {
            

            // Scrivi(10);
            ScriviOttimizzato(5);


        }


    }
}
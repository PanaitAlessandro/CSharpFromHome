/*
Scrivi un programma che chiede all'utente 5 nomi (uno alla volta da tastiera),
 li salva in un file nomi.txt con File.WriteAllLines, poi rilegge il file e li ristampa a schermo.
*/

using System;
using System.IO;

namespace Esercizio2
{
    class Program
    {
        static void Inserisci()
        {

            string[] nomi = new string[5];
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Inserisci nome: ");
                nomi[i] = Console.ReadLine();
            }


            File.WriteAllLines("es2.txt", nomi);
        }

        static void Stampa()
        {
            
            string[] tutto = File.ReadAllLines("es2.txt");

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(tutto[i]);
            }
        }

        static void Main(string[] args)
        {
            Inserisci();
            Stampa();
        }


    }
}
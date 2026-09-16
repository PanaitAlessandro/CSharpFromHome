/*
Chiede all'utente nome e cognome (due ReadLine separate), stampa "Benvenuto, {nome} {cognome}." con string interpolation.
*/

using System;

namespace Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Inserisci nome: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Inserisci Cognome: ");
            string cognome = Console.ReadLine();

            System.Console.WriteLine($"Benvento, {nome} {cognome}.");
        }
    }
}
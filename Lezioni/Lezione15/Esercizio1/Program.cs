/*
Scrivi Veicolo, Moto, Auto, AutoElettrica
*/
using System;

namespace Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            CAutoElettrica tesla = new CAutoElettrica(100,"Tesla model y", "Tesla","ABCED",200,4000); // devo mettere: int autonomia, string modello, string marca, string targa, int cilindrata, int chilometraggio

            System.Console.WriteLine(tesla);
        }
    }
}
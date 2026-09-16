/*
Validazione con do-while: chiedi ripetutamente all'utente un numero finché non inserisce un valore tra 1 e 100 incluso.
 Usa do-while, non while. Alla fine stampa il valore accettato.
*/

using System;

namespace Esercizio5
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            do
            {
                System.Console.WriteLine("Inserisci un valore tra 1 e 100");
                bool verifica = int.TryParse(Console.ReadLine(), out numero);
            } while (numero < 1 || numero > 100);

            System.Console.WriteLine($"Numero: {numero}");
        }

        

    }
}
// Dimostra con codice la differenza tra x++ e ++x stampando i valori intermedi, con commenti che spiegano ogni riga.

using System;

namespace Esercizio4;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        System.Console.WriteLine(x);

        System.Console.WriteLine($"Incremento: {x++}");
        System.Console.WriteLine($"Incrementato ora: {x}");

         // ora è a 1
        System.Console.WriteLine($"Subito: {++x}"); // 2
    }
}
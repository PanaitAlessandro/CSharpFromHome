/*
ref reale: scrivi un metodo void Scambia(ref int a, ref int b) che scambia i valori di due variabili
 (serviti di una terza variabile temporanea dentro il metodo). Dimostra da Main che dopo 
 la chiamata i valori sono davvero scambiati fuori dal metodo.
*/

using System;

namespace Esercizio2;

class Program
{
    static void Scambia(ref int a, ref int b)
    {
        System.Console.WriteLine($"PRIMA... {a}, {b}");
        int temp = a;
        a = b;
        b = temp;
        System.Console.WriteLine($"{a}, {b}");
    }

    static void Main(string[] args)
    {
        int a = 5;
        int b = 4;
        Scambia(ref a,ref b);
        System.Console.WriteLine($"... {a}, {b}");
    }
}
using System;

namespace Esercizio3
{
    class Program
    {
        static int Somma(int a, int b)
        {
            return a+b;
        }

        static void Saluto(string stringa)
        {
            System.Console.WriteLine(stringa);
        }

        static void Incrementa(int x)
        {
            x++;
            System.Console.WriteLine($"Dentro il mondo delle meraviglie: {x}");
        }

        static void refIncrementa(ref int y)
        {
            y++;
            System.Console.WriteLine(y);
        }

        static int Somm(int a, int b, out int som, out int dif)
        {
            dif = a-b;
            som = a+b;

            return a*b;
        }

        static int SommaTutti(params int[] numeri)
        {

            int totale = 0;
            for (int i = 0; i < numeri.Length; i++)
            {
                totale += numeri[i];
            }

            return totale;
        }

        static void Informazioni(int eta, string nome = "Sconosciuto")
        {
            System.Console.WriteLine($"Hai {eta} e ti chiami {nome}");
        }

        // overloading

        static int sum(int a, int b) => a+b;

        static int Fattoriale(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Fattoriale(n-1);
        }

        static int Fibonacci(int n)
        {
            if (n == 0) return 0;   // CASO BASE 1
            if (n == 1) return 1;   // CASO BASE 2
            
        return Fibonacci(n - 1) + Fibonacci(n - 2);   // CASO RICORSIVO
        }


        // MAIN MAIN MAIN
        static void Main(string[] args)
        {
        int programma = Somma(2,5);
        System.Console.WriteLine(programma);

        Saluto("Ciao");

        int x = 5;
        Incrementa(x);

        System.Console.WriteLine($"fuori dal mondo delle meraviglie: {x}");

        int y = 1;
        refIncrementa(ref y);
        System.Console.WriteLine(y);

        int outouto = Somm(1,3, out int som, out int dif);
        System.Console.WriteLine($"Prodotto: {outouto}, Somma: {som}, Differenza: {dif}");


        int sommatuttilgiorno = SommaTutti(1,2,3);

        System.Console.WriteLine(sommatuttilgiorno);

        Informazioni(18);
        Informazioni(18, "Ale");

        int so = sum(1,2);
        System.Console.WriteLine(so);


        }

    }
}
using System;

namespace Lezione6
{
    class Program
    {
        

        static int[] Massimo(int[] numeri)
        {
            if (numeri.Length == 0)
            {
                throw new ArgumentException("Non hai nessun valore, Impossibile calcolare il massimo");
            }

            int massimo = numeri[0];

            for (int i = 1; i < numeri.Length; i++)
            {
                if (numeri[i] > massimo)
                {
                    massimo = numeri[i];
                }
            }
            return massimo;
        }

        // la stessa viene fatta con minimo,somma..

        static int[] Media(int[] numeri)
        {

            int somma = 0;
            double media = 0.0;
            if (numeri.Length == 0)
            {
                throw new ArgumentException("Non hai nessun valore, Impossibile calcolare la media");
            }

            for (int i = 0; i < numeri.Length; i++)
            {
                somma += numeri[i];
            }

            media = (double)somma / numeri.Length;
            return media;
        }


        // splitting: 
        // esempio, dividiamo da un array numeri pari e dispari, li mettiamo su due nuovi array

        static void SplitPariDispari(int[] numeri, out int[] pari, out int[] dispari)
        {
            int contaPari = 0;
            int contaDispari = 0;

            for (int i = 0; i < numeri.Length; i++)
            {
                if (numeri[i] % 2 == 0)
                {
                    contaPari++;
                } else
                {
                    contaDispari++;
                }
            }

            pari = new int[contaPari];
            dispari = new int[contaDispari];

            int indicePari = 0;
            int indiceDispari = 0;

            for (int i = 0; i < numeri.Length; i++)
            {
                if (numeri[i] % 2 == 0)
                {
                    pari[indicePari] = numeri[i];
                    indicePari++;
                } else
                {
                    dispari[indiceDispari] = numeri[i];
                    indiceDispari;
                }
            }
        }
    }
}
using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Lezione5
{
    class Program
    {
        
        static void SelectionSort(int[] numeri)
        {
            
            for (int i = 0; i < numeri.Length-1; i++)
            {
                
                int indiceMinimo = i;

                for (int j = i+1; j < numeri.Length; j++)
                {
                    if (numeri[j] < numeri[indiceMinimo])
                    {
                        indiceMinimo = j;
                    }
                }

                int temp = numeri[i];
                numeri[i] = numeri[indiceMinimo];
                numeri[indiceMinimo] = temp;


            }
        }

        static void BubbleSort(int[] numeri)
        {
            
            for (int i = 0; i < numeri.Length-1; i++)
            {
                for (int j = 0; j < numeri.Length-1-i; j++)
                {
                    
                    if (numeri[j] > numeri[j+1])
                    {
                        
                        int temp = numeri[j];
                        numeri[j] = numeri[j+1];
                        numeri[j+1] = temp;

                    }
                }
            }

        }


        static void BubbleSortOttimizzato(int[] numeri)
        {
            for (int i = 0; i < numeri.Length-1; i++)
            {
                bool scambiato = false;

                for (int j = 0; j < numeri.Length-1-i; j++)
                {
                    
                    if (numeri[j] > numeri[j+1])
                    {                        
                        int temp = numeri[j];
                        numeri[j] = numeri[j+1];
                        numeri[j+1] = temp;

                        scambiato = true;
                    }
                }

                if (!scambiato) break;
            }
        }

        // merge sort.. temuto

        static int[] Merge(int[] sinistra, int[] destra)
        {
            int[] risultato = new int[sinistra.Length+destra.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < sinistra.Length && j < destra.Length)
            {
                if (sinistra[i] <= destra[j])
                {
                    risultato[k++] = sinistra[i++];
                } else
                {
                    risultato[k++] = destra[j++];
                }
            }

            while (i < sinistra.Length)
            {
                risultato[k++] = sinistra[i++];
            }

            while (j < destra.Length)
            {
                risultato[k++] = destra[j++];
            }

            return risultato;
        }

        static int[] MergeSort(int[] array)
        {
            
            if (array.Length <= 1) return array;

            int meta = array.Length/2;

            int[] sinistra = new int[meta];
            int[] destra = new int[array.Length-meta]; // in caso sia dispari

            Array.Copy(array, 0, sinistra, 0, meta);
            Array.Copy(array, meta, destra, 0, array.Length - meta);

            sinistra = MergeSort(sinistra);
            destra = MergeSort(destra);

            return Merge(sinistra, destra);
        }
    }
}



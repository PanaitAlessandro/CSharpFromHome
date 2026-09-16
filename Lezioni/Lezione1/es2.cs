/*
Chiede due numeri interi con TryParse (gestione errore inclusa, se l'input non è valido stampa "Input non valido." e termina senza crashare). 
Se validi, stampa somma, differenza, prodotto, e divisione come double con almeno 2 decimali (cerca tu come formattare {valore:F2} . è indizio, non soluzione).
*/

using System;

namespace Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Inserisci il primo numero: ");
            bool validazione1 = int.TryParse(Console.ReadLine(), out int n1);

            System.Console.WriteLine("Inserisci il secondo numero: ");
            bool validazione2 = int.TryParse(Console.ReadLine(), out int n2);

            if(validazione1 && validazione2) 
            {

            int somma = n1+n2;
            int differenza = n1-n2; // vogliamo negativi o reali? se non reali, allora nessun controllo per il maggiore
            int prodotto= n1*n2;
            if (n2 == 0) {
                             System.Console.WriteLine("N2 non può essere zero.");
         
            } else
            {
                 double divisione = (double)(n1/n2);
                System.Console.WriteLine($"Somma: {somma}, Differenza: {differenza}, Prodotto: {prodotto}, Divisione: {divisione:F2}");
            }
            }
                
            else {
                System.Console.WriteLine("valori non validi!");
            }

     }
  }
}

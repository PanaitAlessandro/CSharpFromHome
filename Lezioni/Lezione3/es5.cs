/*
Parametri opzionali + nominati: scrivi un metodo void StampaScontrino(string prodotto, double prezzo, int quantita = 1, double sconto = 0.0) 
che stampa il totale (prezzo * quantita, meno lo sconto percentuale se presente). 
*/

using System;

namespace Esercizio5
{
    class Program
    {
static void StampaScontrino(string prodotto, double prezzo, int quantita = 1, double sconto = 0.0)
{
    double totale = (prezzo * quantita) - sconto;
    Console.WriteLine($"{prodotto}: {totale}");
}

static void Main(string[] args)
{
    StampaScontrino("Spazzolino", 50.0, 2, 5.0);        // tutti i parametri
    StampaScontrino("Dentifricio", 8.0);                 // quantita e sconto sui default
    StampaScontrino("Sapone", 3.0, sconto: 1.0);          // quantita sul default, sconto nominato, salta quantita
}
    }
}
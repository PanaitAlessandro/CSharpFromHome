using System;

namespace Lezione19
{
    //Lezione19: sealed e static su una classe intera, e il pattern Singleton

    public sealed class CVeicolo // in questa classe nessuno può ereditarla (IS-A :)
 {
    private string _targa;

    public string Targa
    {
        get
        {
            return _targa;
        }
        private set
        {
            _targa = value;
        }
    }

    public CVeicolo(string targa)
    {
        Targa = targa;
    }

    public static class Controlli // questa invece non posso istanziarla Controlli c = new Controlli()
{
    public static string NonVuota(string valore, string nomeCampo)
    {
        if (string.IsNullOrWhiteSpace(valore))
        {
            throw new ArgumentException($"Il campo '{nomeCampo}' non può essere vuoto.");
        }

        return valore;
    }
}


    // pattern singleton:

    // il problema attuale è che noi possiamo creare più classi (facciamo l'esempio di un garage).. e da utenti senza accorgecene ne creiamo due per la stessa azienda...
    // per questo dobbiamo utilizzare il pattern singleton, ossia UNA e SOLO UNA classe.

    public class CGaragePrincipale // singleton
{
    private static CGaragePrincipale _istanza;

    private int _numeroVeicoli;

    public int NumeroVeicoli
    {
        get { return _numeroVeicoli; }
        private set { _numeroVeicoli = value; }
    }

    private CGaragePrincipale()
    {
        NumeroVeicoli = 0;
        Console.WriteLine("Ho creato un NUOVO CGaragePrincipale (deve succedere una volta sola)");
    }

    public static CGaragePrincipale Istanza
    {
        get
        {
            if (_istanza == null)
            {
                _istanza = new CGaragePrincipale();
            }

            return _istanza;
        }
    }

    public void AggiungiVeicolo()
    {
        NumeroVeicoli = NumeroVeicoli + 1;
    }
}
}
}
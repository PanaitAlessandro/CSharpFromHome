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
}
}
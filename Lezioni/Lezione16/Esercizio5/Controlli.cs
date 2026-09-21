using System;

namespace Esercizio5
{
    public static class Controlli
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

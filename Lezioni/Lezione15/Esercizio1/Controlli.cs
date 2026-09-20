using System;

namespace Esercizio1
{
    public class Controlli
    {
        public static string NonVuota(string valore, string campo)
        {
            if(string.IsNullOrWhiteSpace(valore))
            {
                throw new ArgumentException($"Il campo '{campo}' non può essere vuoto.");
            }
            return valore;
        }
    }
}
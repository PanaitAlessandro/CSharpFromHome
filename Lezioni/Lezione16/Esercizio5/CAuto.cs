using System;

namespace Esercizio5
{
    public class CAuto : CVeicolo
    {
        private int _numeroPorte;

        public int NumeroPorte
        {
            get { return _numeroPorte; }
            private set
            {
                if (value < 2 || value > 5)
                {
                    throw new ArgumentException($"Le porte devono essere tra 2 e 5 (valore ricevuto: {value}).");
                }

                _numeroPorte = value;
            }
        }

        public CAuto() : this("SCONOSCIUTA", "SCONOSCIUTA", "SCONOSCIUTO", 0, 4)
        {
        }

        public CAuto(string targa, string marca, string modello, int chilometraggio, int numeroPorte)
            : base(targa, marca, modello, chilometraggio)
        {
            NumeroPorte = numeroPorte;
        }

        public override string ToString()
        {
            return base.ToString() + $", {NumeroPorte} porte";
        }
    }
}

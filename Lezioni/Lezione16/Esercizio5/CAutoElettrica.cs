using System;

namespace Esercizio5
{
    public class CAutoElettrica : CAuto
    {
        private int _autonomia;

        public int Autonomia
        {
            get { return _autonomia; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"L'autonomia deve essere positiva (valore ricevuto: {value}).");
                }

                _autonomia = value;
            }
        }

        public CAutoElettrica() : this("SCONOSCIUTA", "SCONOSCIUTA", "SCONOSCIUTO", 0, 4, 300)
        {
        }

        public CAutoElettrica(string targa, string marca, string modello, int chilometraggio, int numeroPorte, int autonomia)
            : base(targa, marca, modello, chilometraggio, numeroPorte)
        {
            Autonomia = autonomia;
        }

        public override int CalcolaCostoTagliando()
        {
            return base.CalcolaCostoTagliando() + Autonomia / 3;
        }

        public override string ToString()
        {
            return base.ToString() + $", autonomia {Autonomia} km";
        }
    }
}

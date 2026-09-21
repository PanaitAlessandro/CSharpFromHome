using System;

namespace Esercizio5
{
    public class CMoto : CVeicolo
    {
        private int _cilindrata;

        public int Cilindrata
        {
            get { return _cilindrata; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"La cilindrata deve essere positiva (valore ricevuto: {value}).");
                }

                _cilindrata = value;
            }
        }

        public CMoto() : this("SCONOSCIUTA", "SCONOSCIUTA", "SCONOSCIUTO", 0, 125)
        {
        }

        public CMoto(string targa, string marca, string modello, int chilometraggio, int cilindrata)
            : base(targa, marca, modello, chilometraggio)
        {
            Cilindrata = cilindrata;
        }

        public override string ToString()
        {
            return base.ToString() + $", {Cilindrata} cc";
        }
    }
}

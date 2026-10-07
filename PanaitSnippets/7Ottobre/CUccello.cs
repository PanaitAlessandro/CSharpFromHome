using System;

namespace AnimaliInterfacce
{
    public class CUccello : CAnimale, IVerso
    {
        private int _altezzaVolo;

        public int AltezzaVolo
        {
            get { return _altezzaVolo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HEY! L'altezza di volo non può essere negativa");
                }
                _altezzaVolo = value;
            }
        }

        public CUccello() : this(0)
        {
        }

        public CUccello(int altezzaVolo) : base("Uccello", 1)
        {
            AltezzaVolo = altezzaVolo;
        }

        public CUccello(string nome, int eta, int altezzaVolo) : base(nome, eta)
        {
            AltezzaVolo = altezzaVolo;
        }

        public string Verso()
        {
            return "ora cip cip";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, vola fino a {AltezzaVolo} m, Verso: {Verso()}";
        }
    }
}

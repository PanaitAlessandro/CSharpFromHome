using System;

namespace Animali
{
    public class CGatto : CAnimale
    {
        private bool _viveDentro;

        public bool ViveDentro
        {
            get { return _viveDentro; }
            set { _viveDentro = value; }
        }

        public CGatto() : this(false)
        {
        }

        public CGatto(bool viveDentro) : base("Gatto", 1)
        {
            _viveDentro = viveDentro;
        }

        public CGatto(string nome, int eta, bool viveDentro) : base(nome, eta)
        {
            _viveDentro = viveDentro;
        }

        public override string Verso()
        {
            return "ora miagolo";
        }

        public override string ToString()
        {
        return $"[Vive Dentro casa: {_viveDentro}] {base.ToString()}";
        }
    }
}

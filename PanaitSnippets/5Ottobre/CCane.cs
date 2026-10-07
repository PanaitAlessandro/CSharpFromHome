using System;

namespace Animali
{
    public class CCane : CAnimale
    {
        private string _razza;

        public string Razza
        {
            get { return _razza; }
            set { _razza = value; }
        }

        public CCane() : this("Sconosciuta")
        {
        }

        public CCane(string razza) : base("Cane", 1)
        {
            _razza = razza;
        }

        public CCane(string nome, int eta, string razza) : base(nome, eta)
        {
            _razza = razza;
        }

        public override string Verso()
        {
            return "abbaio";
        }

        public override string ToString()
        {
            return $"[{Razza}] {base.ToString()}";
        }
    }
}

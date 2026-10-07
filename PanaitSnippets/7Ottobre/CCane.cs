using System;

namespace AnimaliInterfacce
{
    public class CCane : CAnimale, IVerso
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

        public string Verso()
        {
            return "abbaio";
        }

        public override string ToString()
        {
            return $"[{Razza}] {base.ToString()}, Verso: {Verso()}";
        }
    }
}

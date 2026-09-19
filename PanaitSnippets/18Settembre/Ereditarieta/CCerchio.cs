using System;

namespace CerchioEreditarieta
{

    public class CCerchio : CPunto // uso i due punti perch è è la convenzione per la ISA
    {
        private double _raggio;

        // dato che siamo sotto forma ISA (eredità); non devo mettere un campo 'private CPunto centro;'

        public double Raggio
        {
            get {return _raggio;}
            set
            {
                if(value <=0)
                {
                    throw new ArgumentException("il raggio non può essere minore di zero!");
                }
                _raggio = value;
            }
        }

        public CCerchio()
        {
            Raggio = 1;
        }

        public CCerchio(double raggio, int x,int y) : base(x, y) // base() in questo caso richiama il costruttore di CPunto e gli da i parametri
        {
            Raggio = raggio;
        }

        public override string ToString()
        {
            return $"Raggio: {Raggio}, Centro: {base.ToString()}";
        }

    }
    
}
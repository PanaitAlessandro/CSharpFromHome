using System;

namespace CerchioEreditarieta
{
    public class CCilindro : CCerchio
    {
        private double _altezza;

        public double Altezza
        {
            get { return _altezza; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("HEY! L'altezza non può avere valori <= 0");
                }
                _altezza = value;
            }
        }

        public CCilindro()
        {
            Altezza = 1;
        }

        public CCilindro(double altezza, double raggio, int x, int y) : base(raggio, x, y)
        {
            Altezza = altezza;
        }

        public override string ToString()
        {
            return $"Altezza: {Altezza}, Base: {base.ToString()}";
        } 
    }
}
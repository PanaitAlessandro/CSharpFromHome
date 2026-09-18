using System;

namespace CerchioComposizione
{
    public class CCilindro
    {
        private CCerchio _base;
        private double _altezza;

        /*
        public CCerchio BaseCilindro {
            get {return _base;}
            set { _base = value;}
        }

        public double Altezza
        {
            get => _altezza;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("L'altezza non può essere minore di Zero");
                }
                _altezza = value;
            }
        }
        */

        public CCilindro()
        {
            _base = new CCerchio();
            _altezza = 1;
        }

        public CCilindro(double altezza, double raggio, int x, int y)
        {

            if (altezza <= 0)
            {
                throw new ArgumentException("L'altezza non può essere minore di Zero");
            }
            _altezza = altezza;
            _base = new CCerchio(raggio,x,y);
        }

        public override string ToString()
        {
            return $"Altezza: {_altezza}, Base: [{_base.ToString()}]";
        }

    }
}
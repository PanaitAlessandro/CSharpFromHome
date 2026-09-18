using System;

namespace CerchioComposizione
{
    public class CCilindro
    {
        private CCerchio _base;
        private double _altezza;

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

        public CCilindro()
        {
            BaseCilindro = new CCerchio();
            Altezza = 1;
        }

        public CCilindro(double altezza, double raggio, int x, int y)
        {
            Altezza = altezza;
            BaseCilindro = new CCerchio(raggio,x,y);
        }
    }
}
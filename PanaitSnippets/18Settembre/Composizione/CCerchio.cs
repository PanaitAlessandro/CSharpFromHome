using System;

namespace CerchioComposizione
{
    public class CCerchio
    {
        private double _raggio;
        private CPunto _centro; 

       /* public double Raggio
        {
            get { return _raggio;}
            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Il raggio non può essere zero o negativo");
                }

                _raggio = value;
            }
        }

        public CPunto Centro
        {
            get { return _centro; }
            set { _centro = value; }
        }
        */

        public CCerchio()
        {
            _raggio = 1;
            _centro = new CPunto();
        }

        public CCerchio(double raggio, int x, int y)
        {
            if (raggio <= 0)
            {
                throw new ArgumentException("Il raggio non può essere zero o negativo");
            }
            _raggio = raggio;
            _centro = new CPunto(x,y);
        }

        public override string ToString()
        {
            return $"Raggio: {_raggio}, Centro: [{_centro.ToString()}]";
        }

    }
}

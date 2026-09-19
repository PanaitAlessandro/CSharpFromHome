using System;

namespace CerchioEreditarieta
{
    public class CPunto
    {
        private int _x;
        private int _y;

        /* come richiesta dalla consegna, rimuovo le proprierty, e chiamo col ToString() ogni classe
        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
            }
        }
        */


        public CPunto()
        {
            _x = 0;
            _y = 0;
        }

        public CPunto(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"X: {_x}, Y: {_y}";
        }
    }
}

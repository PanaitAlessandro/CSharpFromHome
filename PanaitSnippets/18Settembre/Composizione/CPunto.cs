using System;

namespace CerchioComposizione
{
    public class CPunto
    {
        private int _x;
        private int _y;

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


        public CPunto()
        {
            X = 0;
            Y = 0;
        }

        public CPunto(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

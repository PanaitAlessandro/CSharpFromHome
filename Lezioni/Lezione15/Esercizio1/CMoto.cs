using System;

namespace Esercizio1
{
    public class CMoto : CVeicolo
    {
        // anche qui voglio passare il marchio (Yamaha per esempio)

        private string _marca;

        public string Marca
        {
            get { return _marca; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La marca non può essere null");
                }
                _marca = value;
            }
        }

        
    }
}
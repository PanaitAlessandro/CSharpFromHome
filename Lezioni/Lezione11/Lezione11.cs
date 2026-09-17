using System;
using System.Linq.Expressions;

namespace Lezione11
{
    public class CMoto
    {
        private int _cilindrata;
        private string _targa;

        public int Cilindrata
        {
            get
            {
                return _cilindrata;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Il valore deve essere maggiore a Zero.");
                }
                _cilindrata = value;
            }
        }

        public string Targa
        {
            get
            {
                return _targa;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException ("Valore non puà essere vuoto o nullo");
                }
                _targa = value;
            }
        }
    }
}
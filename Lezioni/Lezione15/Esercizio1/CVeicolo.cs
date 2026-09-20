using System;

namespace Esercizio1
{
    public class CVeicolo
    {
        // facciamo targa, cilindrata, chilometraggio

        private string _targa;
        private int _cilindrata;
        private int _chilometraggio;

        public string Targa
        {
            get { return _targa; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("la targa non può essere null");
                }

                _targa = value;
            }
        }
        public int Cilindrata
        {
            get { return _cilindrata; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("la cilindrata non può essere minore o uguale a zero");
                }

                _cilindrata = value;
            }
        }

        public int Chilometraggio
        {
            get { return _chilometraggio; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Il chilometraggio non può scendere sotto lo zero (altro che KM zero)");
                }

                _chilometraggio = value;
            }
        }

        public CVeicolo() : this("SCONOSCIUTA", 1,0)
        {
            
        }

        public CVeicolo(string targa, int cilindrata, int chilometraggio)
        {
            Targa = targa;
            Cilindrata = cilindrata;
            Chilometraggio = chilometraggio;
        }

        public override string ToString()
        {
            return $"Targa: {Targa}, Cilindrata: {Cilindrata}, Chilometraggio: {Chilometraggio}";
        }
    }
}
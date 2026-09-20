using System;

namespace Esercizio1
{
    public class CAuto : CVeicolo
    {
        // per l'auto direi di aggiungerci solo la marca

        private string _marca;

        public string Marca
        {
            get { return _marca ;}
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La marca non può essere null");
                }
                _marca = value;
            }
        }

        public CAuto() : this("Sconosciuta", "Sconosciuta", 1,0)
        {
        }

        public CAuto(string marca, string targa, int cilindrata,int chilometraggio) : base(targa,cilindrata,chilometraggio)
        {
            Marca = marca;
        }
    }
}
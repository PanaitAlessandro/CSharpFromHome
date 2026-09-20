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

        public CMoto() : this("Sconosciuta", "Sconosciuta", 1, 0)
        {
        }

        public CMoto(string marca, string targa, int cilindrata,int chilometraggio) : base(targa,cilindrata,chilometraggio)
        {
            Marca = marca;
        }

        public override string ToString()
        {
            return $"Marca: {Marca}, [Veicolo: {base.ToString()}]";
        }

    }
}
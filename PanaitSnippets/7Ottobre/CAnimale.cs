using System;

namespace AnimaliInterfacce
{
    public abstract class CAnimale
    {
        private string _nome;
        private int _eta;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("HEY! Il nome non può essere vuoto");
                }
                _nome = value;
            }
        }

        public int Eta
        {
            get { return _eta; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HEY! L'età non può essere negativa");
                }
                _eta = value;
            }
        }

        public CAnimale() : this("Sconosciuto", 0)
        {
        }

        public CAnimale(string nome, int eta)
        {
            Nome = nome;
            Eta = eta;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Età: {Eta}";
        }
    }
}

using System;

namespace Esercizio5
{
    public class CVeicolo
    {
        private string _targa;
        private string _marca;
        private string _modello;
        private int _chilometraggio;

        public string Targa
        {
            get { return _targa; }
            private set
            {
                _targa = Controlli.NonVuota(value, "targa");
            }
        }

        public string Marca
        {
            get { return _marca; }
            private set
            {
                _marca = Controlli.NonVuota(value, "marca");
            }
        }

        public string Modello
        {
            get { return _modello; }
            private set
            {
                _modello = Controlli.NonVuota(value, "modello");
            }
        }

        public int Chilometraggio
        {
            get { return _chilometraggio; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Il chilometraggio non può essere negativo (valore ricevuto: {value}).");
                }

                _chilometraggio = value;
            }
        }

        public CVeicolo() : this("SCONOSCIUTA", "SCONOSCIUTA", "SCONOSCIUTO", 0)
        {
        }

        public CVeicolo(string targa, string marca, string modello, int chilometraggio)
        {
            Targa = targa;
            Marca = marca;
            Modello = modello;
            Chilometraggio = chilometraggio;
        }

        public void AggiornaChilometraggio(int kmPercorsi)
        {
            if (kmPercorsi < 0)
            {
                throw new ArgumentException("I km percorsi non possono essere negativi.");
            }

            Chilometraggio += kmPercorsi;
        }

        public override string ToString()
        {
            return $"{Targa} ({Marca} {Modello}), {Chilometraggio} km";
        }
    }
}

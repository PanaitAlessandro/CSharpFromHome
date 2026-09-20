using System;

namespace Esercizio1
{
    public class CAutoElettrica : CAuto
    {
        
        // per l'auto elettrico direi di mettere autonomia e modello (tipo Tesla model y)

        private int _autonomia;
        private string _modello;

        public int Autonomia
        {
            get {return _autonomia;}
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("L'autonomia non può essere zero o minore");
                }
                _autonomia = value;
            }
        }

        public string Modello
        {
            get {return _modello;}
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("è la sesta volta che faccio questo controllo. IL MODELLO NON PUO ESSERE NULL");
                }
                _modello = value;
            }
        }

        public CAutoElettrica() : this(1, "SCONOSCIUTO", "Sconosciuta", "Sconosciuta", 1,0)
        {
            
        }

        public CAutoElettrica(int autonomia, string modello, string marca, string targa, int cilindrata, int chilometraggio) : base(marca,targa,cilindrata,chilometraggio)
        {
            Autonomia = autonomia;
            Modello = modello;
        } // da aggiungere: string marca, string targa, int cilindrata,int chilometraggio
        public override string ToString()
        {
            return $"Autonomia: {Autonomia}, Modello: {Modello}, [Auto: {base.ToString()}]";
        }
    }
}
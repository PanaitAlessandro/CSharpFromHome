/*
Stanza: Nome (string), Larghezza e Lunghezza (int, con get e set pubblici), proprietà calcolata Superficie (Larghezza * Lunghezza), costruttore con i tre parametri.
Casa: Indirizzo; il costruttore crea da solo tre stanze in un array private readonly: Salotto 5×4, Cucina 3×3, Camera 4×4. Metodi SuperficieTotale() e StampaPlanimetria().
Vincoli: in Main non compare nessun new Stanza, e nessun metodo di Casa restituisce o accetta una Stanza.
*/

using System;

namespace Esercizio1
{
    public class Stanza
    {
        private string _nome;
        public int Larghezza;
        public int Lunghezza;

        public string Nome
        {
            get {return _nome;}
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    _nome = value;
                }
            }
        }

        public int Superficie
        {
            get {return Lunghezza*Larghezza;}
        }

        public Stanza()
        {
            Nome = "SCONOSCIUTO";
            Lunghezza = 0;
            Larghezza = 0;
        }

        public Stanza(string nome, int lunghezza, int larghezza)
        {
            Nome = nome;
            Lunghezza = lunghezza;
            Larghezza = larghezza;
        }
    }

    public class Casa
    {
        public string Indirizzo { get; set; }

        private readonly Stanza[] _stanze;


        public Casa(string indirizzo)
        {
            Indirizzo = indirizzo;

            _stanze = new Stanza[]
            {
                new Stanza("Salotto", 5, 4),
                new Stanza("Cucina", 3, 3),
                new Stanza("Camera", 4, 4)

            };


        }

        public int SuperficieTotale()        
        {
            int somma = 0;
            for(int i = 0; i < _stanze.Length; i++)
            {
                somma += _stanze[i].Superficie;
            }
            return somma;
        }


        public void StampaPlanimetria()
        {
            Console.WriteLine($"Planimetria della casa in: {Indirizzo}");

            for (int i = 0; i < _stanze.Length; i++)
            {
                Stanza s = _stanze[i];
                Console.WriteLine($" {s.Nome}: {s.Larghezza}x{s.Lunghezza} (Superficie: {s.Superficie} mq)");
            }
            Console.WriteLine($"Superficie Totale della Casa: {SuperficieTotale()} mq");
        }
    }
}
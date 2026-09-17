// Has-A (composizine di oggetti)
// ISA (un oggetto è un altro oggetto + qualche altro cosa)

using System;

namespace EsempioIsASemplice
{
    // Classe Padre
    public class Automobile
    {
        public string Modello { get; set; }

        public void Guida()
        {
            Console.WriteLine($"Guidando la {Modello}...");
        }
    }

    // Classe Figlia -> relazione IS-A (L'AutoElettrica è UN'Automobile)
    public class AutoElettrica : Automobile
    {
        // "Qualche altra cosa": aggiungiamo una nuova proprietà
        public int Batteria { get; set; }

        // "Qualche altra cosa": aggiungiamo un nuovo metodo
        public void Ricarica()
        {
            Console.WriteLine($"Ricarica della {Modello} al {Batteria}% avviata!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creiamo l'auto elettrica
            AutoElettrica miaTesla = new AutoElettrica();
            
            // Possiamo usare Modello perché lo eredita dal padre
            miaTesla.Modello = "Tesla Model 3"; 
            miaTesla.Batteria = 80;

            // Usiamo i metodi
            miaTesla.Guida();    // Metodo ereditato dal padre
            miaTesla.Ricarica(); // Metodo esclusivo della figlia
        }
    }
}

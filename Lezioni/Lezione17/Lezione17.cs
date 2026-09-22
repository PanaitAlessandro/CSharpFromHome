using System;

namespace  Lezione17 
{
    // Ieri CVeicolo.CalcolaCostoTagliando() ritornava 100. Numero inventato.. un veicolo generico non esiste, quindi quel valore non significa niente.
    // Peggio: niente vietava new CVeicolo(...) con quel costo finto.

    // soluzione:
    // dire al compilatore "questo metodo DEVE essere riscritto da ogni figlia, e la base non si può creare da sola"

    public abstract class CVeicolo // classe astratta: non pyò venir istanziata
{
    private string _targa;

    public string Targa
    {
        get
        {
            return _targa;
        }
        private set
        {
           // _targa = Controlli.NonVuota(value, "Targa"); // controlli è un metodo esterno
           _targa = value;
        }
    }

    public abstract int CalcolaCostoTagliando(); // un metodo può essere astratto ma non avrà nessun contenuto {}
}

    public class CAuto : CVeicolo
    {
        // errore ch è comjne: non chiamare il metodo CalcolaCostoTagliando()

        // ora lo chiamiamo:

        public override int CalcolaCostoTagliando()
        {
            return 100;
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            CAuto a = new CAuto();
            System.Console.WriteLine(a.CalcolaCostoTagliando());
        }
    }
}
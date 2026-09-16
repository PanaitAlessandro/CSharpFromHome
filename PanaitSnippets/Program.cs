using System;

namespace gestioneMoto
{
    public class CMoto
    { // proprieta
        public string Targa { get; set; }
        public string Marca { get; set; }
        public string Modello { get; set; }
        public double PrezzoBase { get; set; }
        public int Chilometraggio { get; set; }
        public int Cilindrata { get; set; }
        public int Serbatoio { get; set; }

        // costruttore di default
        public CMoto()
        {
            Targa = "";
            Marca = "";
            Modello = "";
            PrezzoBase = 0.0;
            Chilometraggio = 0;
            Cilindrata = 0;
            Serbatoio = 0;
        }

        // costruttore con parametri
        public CMoto(string targa, string marca, string modello, double prezzoBase, int chilometraggio, int cilindrata, int serbatoio)
        {
            Targa = targa;
            Marca = marca;
            Modello = modello;
            PrezzoBase = prezzoBase;
            Chilometraggio = chilometraggio;
            Cilindrata = cilindrata;
            Serbatoio = serbatoio;
        }

        public override string ToString() // to string 
        {
            return "Targa: " + Targa + ", Marca " + Marca + ", Modello: " + Modello + ", PrezzoBase: " + PrezzoBase + ", Chilometraggio: " + Chilometraggio + ", Cilindrata: " + Cilindrata + ", Serbatoio: " + Serbatoio;
        }

        public void AggiornaChilometraggio(int kmPercorsi)
        {

            Chilometraggio = Chilometraggio + kmPercorsi;
        } //

    }




    // 1 classe conclusa







    public class COfficina
    { // proprierty
        public string Nome { get; set; }
        public string Indirizzo { get; set; }

        private CMoto[] elencoMoto = new CMoto[100];
        private int numeroMoto = 0;

        //  default
        public COfficina()
        {
            Nome = "";
            Indirizzo = "";
        }

        // parametri
        public COfficina(string nome, string indirizzo)
        {
            Nome = nome;
            Indirizzo = indirizzo;
        }

        public override string ToString() // to string
        {
            return "Officina: " + Nome + ", Indirizzo: " + Indirizzo + ", Moto presenti: " + numeroMoto;
        }

        // Aggiunge una moto nell'array
        public void MotoDaRiparare(CMoto moto)
        {
            if (numeroMoto < 100)
            {
                elencoMoto[numeroMoto] = moto;
                numeroMoto++;
            }
        }

        // Calcola il costo e toglie la moto dall'array
        public double CalcolaCostoRiparazione(CMoto moto, double percentualeSconto)
        {

            double costoDiRiparazione = 50.0;
            costoDiRiparazione += (moto.Chilometraggio / 1000) * 2;
            costoDiRiparazione += (moto.Cilindrata * 0.2);

            if (moto.Modello.Contains("Yamaha"))
            {
                costoDiRiparazione += 200;
            }

            double prezzoFinale = ProvaCalcoloSconto(costoDiRiparazione, percentualeSconto);

            for (int i = 0; i < numeroMoto; i++)
            {
                if (elencoMoto[i] == moto) // i = 0; numeroMoto = 1; elencoMoto[0] = moto; quindi entra nell if
                {
                    for (int j = i; j < numeroMoto - 1; j++) // j = 0; j < 0; quindi non entra nel for
                    {
                        elencoMoto[j] = elencoMoto[j + 1]; // Sposta ogni moto indietro di una posizione
                    }
                    elencoMoto[numeroMoto - 1] = null;
                    numeroMoto--;
                    break;
                }
            }

            return prezzoFinale;
        }

        //controll che la percentuaqle sia tra 5 e 20
        public double ProvaCalcoloSconto(double prezzoIntero, double percentuale)
        {
            if (percentuale >= 5 && percentuale <= 20)
            {
                double sconto = (prezzoIntero * percentuale) / 100;
                return prezzoIntero - sconto;
            }
            return prezzoIntero;
        }
    } // 

    class Program
    {
        static void Main(string[] args)
        {
            CMoto moto = new CMoto("YAMMEBELL", "Yamaha", "Yamaha", 500, 500, 500, 50);
            COfficina officina = new COfficina("Officina Rossi", "Via Roma 10");

            moto.AggiornaChilometraggio(100);
            officina.MotoDaRiparare(moto);

            double spesa = officina.CalcolaCostoRiparazione(moto, 10);

            Console.WriteLine(moto.ToString());
            Console.WriteLine(officina.ToString());
            Console.WriteLine("Spesa per la riparazione: " + spesa);

        }
    }
}
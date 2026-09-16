using System;



namespace Settembre
{
    public class CMoto
    {
        public string Modello {get; set;}
        public string Targa { get; set;}

        public double Cilindrata {get; set;}
        public int Chilometraggio {get; set;}

        public string Marca {get; set;}
        public decimal prezzoBase {get; set;}

        public int Serbatoio {get; set;}

        public CMoto()
        {
            Modello = "";
            Targa = "";
            Cilindrata = 0.0;
            Chilometraggio = 0;
            Marca = "";
            prezzoBase = 0.0m;
            Serbatoio = 0;
        }

        public CMoto(string modello, string targa, double cilindrata, int chilometraggio, string marca, decimal prezzobase, int serbatoio)
        {
            Modello = modello;
            Targa = targa;
            Cilindrata = cilindrata;
            Chilometraggio = chilometraggio;
            Marca = marca;
            prezzoBase = prezzobase;
            Serbatoio = serbatoio;
        }

        public override string ToString()
        {
            return $"Modello: {Modello}, Targa: {Targa}, Cilindrata: {Cilindrata}, Chilometraggio: {Chilometraggio}, Marca: {Marca}, prezzoBase = {prezzoBase}, Serbatoio: {Serbatoio}";
        }

        public void AggiornaChilometraggio(int kmPercorsi)
        {
            Chilometraggio += kmPercorsi;
        }
    }

    public class COfficina
    {
        private string _nome {get; set;}
        private string _indirizzo {get; set;}

        private CMoto[] elencoMoto = new CMoto[100];
        private int numeroMoto = 0;

        public COfficina()
        {
            _nome = "";
            _indirizzo = "";
        }

        public COfficina(string Nome, string Indirizzo)
        {
            Nome = _nome;
            Indirizzo = _indirizzo;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Indirizzo: {Indirizzo}";
        }

        public void MotoDaRiparare(CMoto moto)
        {
            if (numeroMoto < 100)
            {
                elencoMoto[numeroMoto] = moto;
                numeroMoto++;
            }
        }

        public double CalcolaCostoRiparazione(CMoto moto, double percentualeSconto)
        {
            decimal costoDiRiparazione = 50.0m;

            // cilindrata e chilometraggio
            costoDiRiparazione += (moto.Cilindrata / 100.0m) * 2m;
            costoDiRiparazione += (moto.Chilometraggio / 1000m) * 0.5m;

            if(moto.Modello.Contains("Yamaha"))
            {
                costoDiRiparazione += 200m;
            }

            decimal prezzoFinale = ProvaCalcoloSconto(percentualeSconto, costoDiRiparazione);

            for (int i = 0; i < numeroMoto; i++)
            {
                if (elencoMoto[i] == moto) 
                {
                    for (int j = i; j < numeroMoto - 1; j++) // j = 0; j < 0; quindi non entra nel for
                    {
                        elencoMoto[j] = elencoMoto[j + 1];
                    }
                    elencoMoto[numeroMoto - 1] = null;
                    numeroMoto--;
                    break;
                }
            }
        }



        public double ProvaCalcoloSconto(double percentuale, decimal costoFinale)
        {
            if (percentuale >= 5 && percentuale <=20)
            {
                costoFinale = (costoFinale * (decimal)percentuale) / 100m;
            } else
            {
                System.Console.WriteLine("percentuale non valida");
            }

            return costoFinale;
        }

    }
}


/*


class CCherchio {

    public float Raggio {get; set;}
    public CPunto Centro {get; set;}
    public CPunto (float R, int x, int y)
}
*/
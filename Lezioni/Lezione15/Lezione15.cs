using System;

namespace Lezione15
{
    class Veicolo
    {
        private string targa;
        private string marca;
        private int chilometraggio;

        public string Targa
        {
            get { return targa; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La targa non puo' essere vuota.");
                targa = value;
            }
        }

        public string Marca
        {
            get { return marca; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La marca non puo' essere vuota.");
                marca = value;
            }
        }

        public int Chilometraggio
        {
            get { return chilometraggio; }
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Il chilometraggio non puo' essere negativo.");
                chilometraggio = value;
            }
        }

        public Veicolo() : this("SCONOSCIUTA", "N/D", 0)
        {
        }

        public Veicolo(string targa, string marca, int chilometraggio)
        {
            Targa = targa;
            Marca = marca;
            Chilometraggio = chilometraggio;
        }

        public void AggiornaChilometraggio(int kmPercorsi)
        {
            if (kmPercorsi < 0)
                throw new ArgumentException("I km percorsi non possono essere negativi.");
            Chilometraggio = Chilometraggio + kmPercorsi;
        }

        public override string ToString()
        {
            return $"{Targa} ({Marca}), {Chilometraggio} km";
        }
    }

    class Moto : Veicolo
    {
        private int cilindrata;

        public int Cilindrata
        {
            get { return cilindrata; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La cilindrata deve essere positiva.");
                cilindrata = value;
            }
        }

        public Moto() : base()
        {
            Cilindrata = 125;
        }

        public Moto(string targa, string marca, int chilometraggio, int cilindrata)
            : base(targa, marca, chilometraggio)
        {
            Cilindrata = cilindrata;
        }

        public void SostituisciContachilometri(int nuoviKm)
        {
            Chilometraggio = nuoviKm;
        }

        public override string ToString()
        {
            return base.ToString() + $", {Cilindrata} cc";
        }
    }

    class Auto : Veicolo
    {
        private int numeroPorte;

        public int NumeroPorte
        {
            get { return numeroPorte; }
            set
            {
                if (value < 2 || value > 5)
                    throw new ArgumentException("Le porte devono essere tra 2 e 5.");
                numeroPorte = value;
            }
        }

        public Auto() : base()
        {
            NumeroPorte = 4;
        }

        public Auto(string targa, string marca, int chilometraggio, int numeroPorte)
            : base(targa, marca, chilometraggio)
        {
            NumeroPorte = numeroPorte;
        }

        public override string ToString()
        {
            return base.ToString() + $", {NumeroPorte} porte";
        }
    }

    class AutoElettrica : Auto
    {
        private int capacitaBatteriaKwh;

        public int CapacitaBatteriaKwh
        {
            get { return capacitaBatteriaKwh; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La capacita' deve essere positiva.");
                capacitaBatteriaKwh = value;
            }
        }

        public AutoElettrica() : base()
        {
            CapacitaBatteriaKwh = 50;
        }

        public AutoElettrica(string targa, string marca, int chilometraggio, int numeroPorte, int capacitaBatteriaKwh)
            : base(targa, marca, chilometraggio, numeroPorte)
        {
            CapacitaBatteriaKwh = capacitaBatteriaKwh;
        }

        public override string ToString()
        {
            return base.ToString() + $", batteria {CapacitaBatteriaKwh} kWh";
        }
    }

    class Program
    {
static void Main(string[] args)
{
    Console.WriteLine("1) Metodi e proprieta' EREDITATI");
    Moto m = new Moto("AB123CD", "Yamaha", 12000, 600);
    m.AggiornaChilometraggio(150);
    Console.WriteLine("   " + m);

    AutoElettrica e = new AutoElettrica("EV001XY", "Tesla", 8000, 4, 75);
    e.AggiornaChilometraggio(50);
    Console.WriteLine("   " + e);

    Console.WriteLine("2) Costruttori di default");
    Console.WriteLine("   " + new Veicolo());
    Console.WriteLine("   " + new Moto());
    Console.WriteLine("   " + new AutoElettrica());

    Console.WriteLine("3) Il setter protected, usato da una classe derivata");
    m.SostituisciContachilometri(0);
    Console.WriteLine("   " + m);
}
    }
}
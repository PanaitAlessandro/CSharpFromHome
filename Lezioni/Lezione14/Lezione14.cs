using System;

class Motore
{
    public int Cilindrata { get; }
    public int PotenzaKw { get; }

    public Motore(int cilindrata, int potenzaKw)
    {
        Cilindrata = cilindrata;
        PotenzaKw = potenzaKw;
    }
}

class Meccanico
{
    public string Nome { get; set; }

    public Meccanico()
    {
        Nome = "";
    }

    public Meccanico(string nome)
    {
        Nome = nome;
    }
}

class Moto
{
    public string Targa {get; set;}
    public int Chilometraggio {get;}

    public Moto()
    {
        Targa = "";
        Chilometraggio = 0;
    }

    public Moto(string targa, int chilometraggio)
    {
        Targa = targa;
        Chilometraggio = chilometraggio;
    }

    public void Ripara(Meccanico meccanico)
    {
        System.Console.WriteLine($"{meccanico.Nome} sta riparando la moto di Targa: {Targa}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Meccanico meccanico = new Meccanico();
        meccanico.Nome = "Carlo";

        Moto moto = new Moto();
        moto.Targa = "ARTIE5IVE";

        moto.Ripara(meccanico);
    }
}
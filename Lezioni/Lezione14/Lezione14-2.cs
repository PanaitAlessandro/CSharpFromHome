using System;

class Persona
{
    public string Nome { get; }
    public Persona() { Nome = ""; }
    public Persona(string nome) { Nome = nome; }
}

class Meccanico
{
    public string Nome { get; }
    public Meccanico() { Nome = ""; }
    public Meccanico(string nome) { Nome = nome; }
}

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

class Moto
{
    public string Targa { get; }
    public Persona Proprietario { get; set; } 
    
    public Motore Motore { get; set; } 

    public Moto()
    {
        Targa = "";
        Motore = new Motore(0, 0); 
    }

    public Moto(string targa, int cilindrata, int potenzaKw)
    {
        Targa = targa;
        Motore = new Motore(cilindrata, potenzaKw);
    }

    public int Cilindrata
    {
    get 
    {
        return Motore.Cilindrata;
    }
    }


    public void Ripara(Meccanico meccanico)  
    {
        Console.WriteLine($"{meccanico.Nome} ripara la moto {Targa}.");
    }
}

class Officina
{
    public string Nome { get; }
    
    public Meccanico[] Meccanici { get; set; } = new Meccanico[20];
    
    public int NumeroMeccanici { get; private set; } = 0;

    public Officina(string nome) { Nome = nome; }

    public void Assumi(Meccanico meccanico)
    {
        if (NumeroMeccanici >= Meccanici.Length)
            throw new InvalidOperationException("Officina al completo.");
        
        Meccanici[NumeroMeccanici++] = meccanico;
    }
}

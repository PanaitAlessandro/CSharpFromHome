using System;
using System.Net.Mail;
public class CVeicolo
{
    public virtual string Rumore()
    {
        return "...";
    }
}

public class CMoto : CVeicolo
{
    public override string Rumore()
    {
        return "Vroom";
    }
}

public class CAuto : CVeicolo
{
    public override string Rumore()
    {
        return "Brum";
    }
}

public class CAutoElettrica : CAuto
{
    public override string Rumore()
    {
        return "Ssss";
    }
}

class Program
{
    static void Main(string[] args)
    {
        CVeicolo[] v = 
        {
            new CMoto(),
            new CAuto(),
            new CAutoElettrica()
        };

        foreach (CVeicolo veicolo in v)
        {
            System.Console.WriteLine(veicolo.Rumore());
        }
    }
}
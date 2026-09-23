using System;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

class CPunto
{
    public virtual int Area()
    {
        return 10;
    }
}

class CCerchio : CPunto
{
    public override int Area()
    {
        return 100;
    }
}

class CCilindro : CCerchio
{

    public override int Area()
    {
        return 1000;
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        CPunto[] Forme =
        {
            new CPunto(),
            new CPunto(),
            new CCerchio(),
            new CCilindro(),
            new CCerchio()
        };
        System.Console.WriteLine("Inizio");

        foreach (CPunto o in Forme)
        {
            System.Console.WriteLine(o.Area());
        }
    }
} 
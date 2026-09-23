using System;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

class CPunto
{
    
}

class CCerchio
{
    public int Area()
    {
        return 100;
    }
}

class CCilindro
{
    
}

class Program
{
    static void Main(string[] args)
    {
        object[] Forme =
        {
            new CPunto(),
            new CPunto(),
            new CCerchio(),
            new CCilindro(),
            new CCerchio()
        };
        System.Console.WriteLine("Inizio");

        foreach (object o in Forme)
        {
            if (o is CCerchio cerchio) {
             System.Console.WriteLine(cerchio.Area());
            }
        }
    }
}
// esercizio: Persona, Impiegato, Età 

using System;

namespace Esercizio1
{
    
    public class Persona // padre
    {

        public string Nome {get; set;}

        public Persona()
        {
            Nome = "";
        }

        public Persona(string nome)
        {

            Nome = nome;
        }

        public void Saluta()
        {
            System.Console.WriteLine($"Nome: {Nome}");
        }

        
    }


    public class Impiego : Persona
    {
        public int Eta {get; set;}

        public Impiego()
        {
            Eta = 0;
        }

        public Impiego(int eta)
        {
            Eta = eta;
        }

        public void StampaEta()
        {
            System.Console.WriteLine($"Eta: {Eta}");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Impiego tipo = new Impiego();

            tipo.Nome="Alessandro";
            tipo.Eta = 17;

            tipo.Saluta();
            tipo.StampaEta();
        }
    }
}
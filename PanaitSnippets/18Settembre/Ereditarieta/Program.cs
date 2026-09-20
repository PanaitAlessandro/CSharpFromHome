using System;

namespace CerchioEreditarieta
{
    class Program
    {
        static void Main(string[] args)
        {
            CCilindro cilindro = new CCilindro(5.0, 2.0,1,2); // devo mettere double altezza, double raggio, int x, int y
            System.Console.WriteLine(cilindro);
        }
    }
}
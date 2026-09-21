using System;

namespace CerchioComposizione
{
    class Program
    {
        static void Main(string[] args)
        {
            CCerchio cerchio = new CCerchio(2.0, 1, 2); // devo mettere double raggio, int x, int y
            CCilindro cilindro = new CCilindro(5.0, cerchio); // devo mettere double altezza, double raggio, int x, int y
            System.Console.WriteLine(cilindro);
        }
    }
}
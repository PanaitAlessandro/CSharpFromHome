using System;

namespace Esercizio5
{
    class Program
    {
        static void Main(string[] args)
        {
            CVeicolo[] parco =
            {
                new CMoto("AB123CD", "Yamaha", "MT-07", 12000, 600),
                new CMoto("XY999ZZ", "Honda", "CBR", 5000, 900),
                new CAuto("FG456HJ", "Fiat", "Panda", 60000, 5),
                new CAutoElettrica("ABCED", "Tesla", "Model Y", 4000, 5, 450),
                new CScooter()
            };

            int somma = 0;

            foreach (CVeicolo v in parco)
            {
                int costo = v.CalcolaCostoTagliando();
                System.Console.WriteLine($"{v.GetType().Name}: {costo} euro ");
                somma += costo;
            }

            System.Console.WriteLine($"Totale: {somma} euro");
        }
    }
}

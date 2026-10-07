using System;

namespace Animali
{
    class Program
    {
        static void Main(string[] args)
        {
            CAnimale[] zoo = new CAnimale[]
            {
                new CCane("Rex", 5, "Pastore Tedesco"),
                new CGatto("Tom", 3, true),
                new CUccello("Cip Chop", 2, 15)
            };

            foreach (CAnimale a in zoo)
            {
                Console.WriteLine($"{a.GetType().Name} . {a.Verso()}");
                Console.WriteLine(a);
                Console.WriteLine();
            }

            CCane cane = new CCane();
            cane.Nome = "Bau";
            cane.Eta = 4;
            Console.WriteLine(cane);

        }
    }
}

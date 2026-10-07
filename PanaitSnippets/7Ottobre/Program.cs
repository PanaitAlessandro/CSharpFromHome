using System;

namespace AnimaliInterfacce
{
    class Program
    {
        static void Main(string[] args)
        {
            IVerso[] zoo = new IVerso[]
            {
                new CCane("Rex", 5, "Pastore Tedesco"),
                new CGatto("Tom", 3, true),
                new CUccello("Cip Chop", 2, 15)
            };

            foreach (IVerso a in zoo)
            {
                Console.WriteLine(a);
                Console.WriteLine($"Verso: {a.Verso()}");
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace Lezione4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[2]; // [0, 0]
            numeri[0] = 10; // [10 , 0]
            numeri[1] = 1; // [10, 1]

            int[] voti = {6,7,8,9,10};

            bool[] isFamous = new bool[3]; // [false,false,false]

            for (int i = 0; i < voti.Length; i++)
            {
                System.Console.WriteLine($"Voto: {voti[i]}");
            }

            foreach (int voto in voti)
            {
                System.Console.WriteLine(voto);
            }

            int valoreCercato = 8;

            for (int i = 0; i < voti.Length; i++)
            {

                if(voti[i] == valoreCercato)
                {
                    System.Console.WriteLine("TROVATO!");
                } 
            }

            System.Console.WriteLine("non trovato");


            int sinistra = 0;
            int destra = voti.Length-1;

            while(sinistra <= destra)
            {
                
                int centro = (sinistra + destra) / 2;

                if (voti[centro] == valoreCercato)
                {
                    System.Console.WriteLine("TROVATO!"); // return centro
                }

                if (voti[centro] < valoreCercato)
                {
                    sinistra = centro +1;
                }

                if (voti[centro] > valoreCercato)
                {
                    destra = centro-1;
                }
               
            }
             // return -1

            
            

        }
    }
}
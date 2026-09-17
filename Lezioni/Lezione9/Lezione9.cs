using System;

namespace Lezione9
{
    public class Moto
    {
        public int eta;

        public void CambiaEta(Moto moto)
        {
            moto.eta = 99;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto();
            moto.eta=4;

            Moto moto2 = moto; // non la sto creando, ma bensi la sto collegando

            moto2.eta = 9;

            System.Console.WriteLine(moto.eta); // stamperà 9, NON 4

            Moto moto3 = new Moto();
            moto3.eta = moto.eta;

            System.Console.WriteLine(moto3.eta); // 9

            moto3.CambiaEta(moto3);

            System.Console.WriteLine(moto3.eta); // 9




        }
    }
}
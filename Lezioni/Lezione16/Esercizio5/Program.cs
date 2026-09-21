/*
Esercizio 5: il tagliando.

Regole (tariffe di esempio, in euro interi):
- ogni veicolo:             80 euro base
- moto:                     + Cilindrata / 10
- auto:                     + 10 euro per ogni porta
- auto elettrica:           60 euro fissi (non chiama base)
- scooter (facoltativo):    70 + Cilindrata / 20

Da fare (tocca a te):
1. In CVeicolo: metodo virtual CalcolaCostoTagliando()
2. Nelle figlie: override
3. Qui sotto: il ciclo foreach che stampa tipo e costo, e il totale

Output atteso per il parco di 4 veicoli:
CMoto: 140 euro
CMoto: 170 euro
CAuto: 130 euro
CAutoElettrica: 60 euro
totale: 500 euro

Con lo scooter aggiunto (facoltativo): CScooter: 76 euro, totale: 576 euro
*/
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
                new CAutoElettrica("ABCED", "Tesla", "Model Y", 4000, 5, 450)
            };

            // TODO: il ciclo foreach con il costo di ogni veicolo e il totale
        }
    }
}

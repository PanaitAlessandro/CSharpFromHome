using System;

namespace Esercizio5
{
    // FACOLTATIVA: serve solo per provare lo scooter (100 + 50 perchè è uno scooter).
    public class CScooter : CMoto
    {
        public CScooter() : base()
        {
        }

        public CScooter(string targa, string marca, string modello, int chilometraggio, int cilindrata)
            : base(targa, marca, modello, chilometraggio, cilindrata)
        {
        }

        public override int CalcolaCostoTagliando()
        {
            return base.CalcolaCostoTagliando() + 50;
        }
    }
}

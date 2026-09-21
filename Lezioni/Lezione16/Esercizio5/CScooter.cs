using System;

namespace Esercizio5
{
    // FACOLTATIVA: serve solo per provare lo scooter (100 + Cilindrata ).
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
            return base.CalcolaCostoTagliando() + Cilindrata;
        }
    }
}

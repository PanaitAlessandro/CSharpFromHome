using System;

namespace Esercizio5
{
    // FACOLTATIVA: serve solo se vuoi provare lo scooter (70 + Cilindrata / 20).
    // Qui c'è solo il costruttore: l'override lo scrivi tu.
    public class CScooter : CMoto
    {
        public CScooter() : base()
        {
        }

        public CScooter(string targa, string marca, string modello, int chilometraggio, int cilindrata)
            : base(targa, marca, modello, chilometraggio, cilindrata)
        {
        }
    }
}

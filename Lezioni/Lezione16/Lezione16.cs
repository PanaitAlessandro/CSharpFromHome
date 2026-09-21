using System;

namespace Lezione16
{
    // CVeicolo v = new CMoto(); -> poliformismo, ossia: creo un veicolo che è una MOTO.
    // il poliformismo si fa con IS-A

    // ora facciamo finta di chiamare un metodo v.Rumore(), deve far partire quello di CVeicolo o di CMoto?
    // per questo virtual e override servono, per definire questi casi

public class CVeicolo2
{
    public virtual string Rumore()
    {
        return "...";
    }
}

public class CMoto2 : CVeicolo2
{
    public override string Rumore()
    {
        return "Vroom";
    }
}

public class CAuto2 : CVeicolo2
{
    public override string Rumore()
    {
        return "Brum";
    }
}

// quindi: essenzialmente la classe padre fornisce alle figlie il suo metodo, e poi, se le figlie hanno un metodo che fa la stessa cosa, possono sovrascriverla
}
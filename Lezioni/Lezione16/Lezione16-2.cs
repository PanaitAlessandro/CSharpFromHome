using System;
using System.Net.Mail;
public class CVeicolo
{
    public virtual string Rumore()
    {
        return "...";
    }
}

public class CMoto : CVeicolo
{
    public override string Rumore()
    {
        return "Vroom";
    }
}

public class CAuto : CVeicolo
{
    public override string Rumore()
    {
        return "Brum";
    }
}

public class CAutoElettrica : CAuto
{
    public override string Rumore()
    {
        return "Ssss";
    }
}

public class CScooter : CMoto
{
    public override string Rumore()
    {
        return "Ring " + base.Rumore();
    }
}

class Program
{
    static void Main(string[] args)
    {
        CVeicolo[] v = 
        {
            new CMoto(),
            new CAuto(),
            new CAutoElettrica(),
            new CScooter()
        };

        foreach (CVeicolo veicolo in v)
        {
            System.Console.WriteLine(veicolo.Rumore());
        }
    }
}
    /*
    new CMoto() crea l'oggetto in memoria. L'oggetto sa di essere una moto.
    v tiene in mano quell'oggetto. La sua etichetta dice CVeicolo.
    Alla chiamata v.Rumore(), il computer vede che Rumore è virtual. Non decide subito.
    Mentre il programma gira, guarda l'oggetto vero (CMoto) e chiede: "hai una tua versione di Rumore?" Sì ->esegue quella -> "Vroom".
}
*/
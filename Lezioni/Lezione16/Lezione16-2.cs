using System;
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
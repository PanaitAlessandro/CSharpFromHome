public class CTargaNonValidaException : Exception
{
    public CTargaNonValidaException(string messaggio) : base(messaggio)
    {
    }
}

public class Esempio
{
    static void ControllaTarga(string targa)
{
    if (targa.Length != 7)
    {
        throw new CTargaNonValidaException($"Targa '{targa}' non valida: deve avere 7 caratteri.");
    }

    Console.WriteLine($"Targa {targa} valida.");
}
}

class Program
{
    static void Main(string[] args)
    {
        // uso:
        try
        {
         ControllaTarga("AB12CD");
        }
        catch (CTargaNonValidaException e)
        {
             Console.WriteLine("Errore: " + e.Message);
        }
    }
}
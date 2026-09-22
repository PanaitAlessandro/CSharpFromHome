using System;

namespace Lezione18
{
    /*
    Vocabolario
Eccezione: oggetto che rappresenta "qualcosa è andato storto", lanciato a runtime. È una classe come le altre, deriva sempre (diretta o indiretta) da Exception.
throw: lancia l'eccezione. Interrompe subito il metodo, risale la catena di chi ha chiamato chi, finché qualcuno la cattura o il programma crasha.
try: blocco "prova a fare questo, potrebbe fallire".
catch (TipoEccezione e): blocco "se succede questo tipo di errore, gestiscilo qui". e è l'oggetto eccezione, e.Message il testo.
finally: blocco che gira SEMPRE, che l'eccezione sia scattata o no. Per pulizia (chiudere file, connessioni).
Eccezione custom: classe tua che deriva da Exception, per errori specifici del tuo dominio invece di usare sempre le generiche del framework.
*/
}

public interface IStampabile
{
    string Descrizione();
}

public interface ILoggabile
{
    string Descrizione();
}

public class CVeicoloTest : IStampabile, ILoggabile
{
    public string IStampabile.Descrizione() // nel main non posso passare CVeicoloTest v = new ... e poi v.Descrizione()
    {
        return "Descrizione per il cliente";
    }

    public string ILoggabile.Descrizione()
    {
        return "Descrizione per il log tecnico"; // idem qui
    }
}
using System;

namespace  Lezione17 
{
    // Ieri CVeicolo.CalcolaCostoTagliando() ritornava 100. Numero inventato.. un veicolo generico non esiste, quindi quel valore non significa niente.
    // Peggio: niente vietava new CVeicolo(...) con quel costo finto.

    // soluzione:
    // dire al compilatore "questo metodo DEVE essere riscritto da ogni figlia, e la base non si può creare da sola"
}
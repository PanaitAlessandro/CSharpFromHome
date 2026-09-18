# Introduzione alla Ereditarietà

Implementare nella stessa soluzione 2 progetti: ComposizioneHasA e ComposizioneIsA.
Sviluppare le classi Punto(int x, int y), Cerchio(Punto centro, int raggio) e Cilindro(Cerchio base, int altezza).
In questa fase, definire gli attributi come privati.
Per ogni classe, definire il metodo ToString() per ottenere tutte le informazioni di un oggetto. Esaminare come si comporta il costruttore: utilizzare la chiamata base() alla classe padre dove necessario.

---

## Struttura della Soluzione

La soluzione è divisa in due progetti distinti con logiche opposte:

### 1. ComposizioneHasA (Completato nella parte logica)
* Logica: Un oggetto più grande contiene ed è responsabile degli oggetti più piccoli.
* Relazione: Il Cilindro ha un Cerchio di base; il Cerchio ha un Punto come centro.
* Flusso dati: I costruttori accettano i parametri grezzi e istanziano internamente le classi figlie a cascata tramite l'operatore new.

### 2. ComposizioneIsA (Da avviare)
* Logica: Una classe estende le funzionalità di un'altra riutilizzandone la struttura.
* Relazione: Il Cerchio è un Punto (con un raggio in più); il Cilindro è un Cerchio (con un'altezza in più).
* Flusso dati: I costruttori non usano la new interna per i componenti, ma passano i dati verso l'alto alla classe padre usando la parola chiave base().

---

## Check-list delle Cose da Fare

Usa questa lista per tracciare cosa manca prima della consegna del progetto.

### Parte 1: Progetto ComposizioneHasA
- [x] Dichiarare gli attributi privati nelle tre classi.
- [x] Implementare Proprietà (Getter/Setter) con validazione dei dati (Raggio e Altezza maggiori di zero).
- [x] Definire i costruttori di default senza parametri.
- [x] Definire i costruttori con parametri a cascata (passaggio dati da Cilindro a Cerchio a Punto).
- [ ] Implementare il metodo override string ToString() per CPunto.
- [ ] Implementare il metodo override string ToString() per CCerchio.
- [ ] Implementare il metodo override string ToString() per CCilindro.

### Parte 2: Progetto ComposizioneIsA
- [ ] Creare il secondo progetto all'interno della stessa soluzione di Visual Studio.
- [ ] Modificare la classe CCerchio in modo che erediti da CPunto.
- [ ] Modificare la classe CCilindro in modo che erediti da CCerchio.
- [ ] Riscrivere i costruttori parametrizzati usando la sintassi : base() per passare i dati alla classe padre.
- [ ] Implementare i metodi ToString() specifici per l'ereditarietà sfruttando base.ToString().

### Parte 3: Test e Consegna
- [ ] Scrivere un metodo Main di prova per verificare la stampa a schermo dei dati su entrambi i progetti.
- [ ] Verificare che i controlli sulle eccezioni (valori minori o uguali a zero) blocchino correttamente l'esecuzione.


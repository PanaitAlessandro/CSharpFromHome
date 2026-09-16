using System;
using System.IO;

namespace Lezione7
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("dati.txt", "Ciao sono Alessandro!\n");

            string contenuto = File.ReadAllText("dati.txt");
            System.Console.WriteLine(contenuto);

            // righe

            string[] nomi = {"Turing", "ShakeSpeare", "Viggi"};
            File.WriteAllLines("righe.txt", nomi);

            // leggiamo le righe
            string[] righeLette = File.ReadAllLines("righe.txt");
            foreach (string riga in righeLette)
            {
                System.Console.WriteLine(riga);
            }

            // aggiungiamo contenuto
            File.AppendAllText("dati.txt", "Sono un developer di Padova\n");

            // streamwriter

            using (StreamWriter scrittore = new StreamWriter("dati.txt"))
            {
                scrittore.WriteLine("Frequento l'ITIS ROSSI");
                scrittore.WriteLine("E punto al massimo.");
            }

            //streamreader

            using (StreamReader lettore = new StreamReader("dati.txt"))
            {
                string riga;
                while ((riga = lettore.ReadLine()) != null)
                {
                    System.Console.WriteLine(riga);
                }
            }

            try
            {
                string content = File.ReadAllText("dati.txt");
                System.Console.WriteLine(content);
            } catch (FileNotFoundException)
            {
                System.Console.WriteLine("Il file non esiste");
            } catch (IOException)
            {
                System.Console.WriteLine($"Problema: {e.Message}");
            }

            if(File.Exists("dati.txt"))
            {
                string cont = File.ReadAllText("dati.txt");
            } else
            {
                System.Console.WriteLine("File non trovato");
            }

        }
    }
}
using System;

namespace GestioneBiblioteca
{
    class Biblioteca
    {
        //La classe biblioteca rapprenseterà il Program dell'applicazione contenente il metodo Main
        static void Main(string[] args)
        {
            Console.WriteLine("--- Benvenuto in 'Gestione Biblioteca' ---");
            Console.WriteLine("Premi Invio per continuare...");
            Console.ReadLine();

            //creo utenti
            Utente utenteUno = creaUtente();
            Utente utenteDue = creaUtente();

            Libro libroUno = new Libro("libAbc", "Pirati dei Caraibi", "Gino Pilotino");
            libroUno.Descrizione();

            //presto il libro all'utente uno
            libroUno.Prestito(utenteUno);
            Console.WriteLine("Premi Invio per continuare...");
            Console.ReadLine();

            //deve dare errore perché già in prestito
            libroUno.Prestito(utenteDue);
            Console.WriteLine("Premi Invio per continuare...");
            Console.ReadLine();

            //restituisco il libro
            libroUno.Restituizione();
            Console.WriteLine("Premi Invio per continuare...");
            Console.ReadLine();

            //presto il libro al secondo utente
            libroUno.Prestito(utenteDue);
            Console.WriteLine("Premi Invio per continuare...");
            Console.ReadLine();

            Console.WriteLine("Termino l'esecuzione del programma, premi Invio...");
            Console.ReadLine();
        }



        public static Utente creaUtente()
        {
            Console.Write("Scrivi il nome dell'utente e premi invio: ");
            string nomeUt = Console.ReadLine();

            Console.Write("Scrivi il cognome dell'utente e premi invio: ");
            string cognomeUt = Console.ReadLine();

            Console.Write("Scrivi l'anno di iscrizione dell'utente e premi invio (solo numeri): ");
            string numeroAnno = Console.ReadLine();

            int annoIscrizioneUt;
            bool res = int.TryParse(numeroAnno, out annoIscrizioneUt);

            //finché res non è true e quindi è un numero
            while (res == false)
            {
                Console.WriteLine("Devi inserire un numero!");
                Console.Write("Scrivi l'anno di iscrizione dell'utente e premi invio (solo numeri): ");
                numeroAnno = Console.ReadLine();

                res = int.TryParse(numeroAnno, out annoIscrizioneUt);
                //Se "numeroAnno" è un numero, ok, vado avanti. Break
                //break; // success!                    
            }

            //Creo l'utente
            Utente utente = new Utente("abc1", nomeUt, cognomeUt, annoIscrizioneUt);

            return utente;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneBibliotecaEreditarieta
{
    public class Libro
    {
        //attributi, ossia campi classe. Impostati in private per garantire incapsulamento, ossia information hiding
        private string id;
        private string titolo;
        private string autore;
        private Utente utente;

        //costruttore Libro
        public Libro(string id, string titolo, string autore)
        {
            //usato this come riferimento all'istanza corrente di Libro, quindi agli attributi sopra elencati
            this.id = id;
            this.titolo = titolo;
            this.autore = autore;
            this.utente = null;
        }

        //metodi
        public string Descrizione()
        {
            return this.titolo + " di " + this.autore; 
        }

        public void Prestito(Utente utenteRichiedente)
        {
            //se l'istanza del libro attuale non è associata ad alcun utente, allora la posso prestare
            if(this.utente == null)
            {
                //associo il libro all'utente
                this.utente = utenteRichiedente;

                //commentato perché metodo Denominazione sostituito con property della classe utente Descrizione
                //Console.WriteLine("Il libro " + this.titolo + " ora è in prestito a " + this.utente.Denominazione());

                Console.WriteLine("Il libro " + this.titolo + " ora è in prestito a " + utente.Descrizione);
            }
            else {
                //commentato perché metodo Denominazione sostituito con property della classe utente Descrizione
                //Console.WriteLine("Il libro " + this.titolo + " è già in prestito a " + this.utente.Denominazione());

                Console.WriteLine("Il libro " + this.titolo + " è già in prestito a " + utente.Descrizione);
            }
        }

        public void Restituizione()
        {
            if(this.utente != null)
            {
                Console.WriteLine("Stai restituendo il libro " + this.titolo + " dell'autore " + this.autore);
                //rimuovi l'associazione del libro all'utente 
                this.utente = null;
            }
            else
            {
                Console.WriteLine("Il libro è già disponibile, non deve essere restituito");
            }
        }

    }
}

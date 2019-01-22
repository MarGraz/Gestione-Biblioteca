using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Biblioteca_Interfacce
{
    class Biblioteca
    {
        //array di interfacce IUtente
        static IUtente[] utenti;

        //metodo stampa utenti
        static void StampaUtenti()
        {        
            //esempio di polimorfismo, qui vengono ciclati "utenti" diversi, come "Persone" e "Organizzazioni", oggetti di classi differenti. Il tutto grazie all'uso dell'interfaccia
            foreach (var ut in utenti)
            {
                Console.WriteLine(ut.Denominazione);
            }
        }

        static void Main(string[] args)
        {
            Persona unaPersona = new Persona();
            unaPersona.Id = "UTN01";
            unaPersona.Nome = "Mario";
            unaPersona.Cognome = "Rossi";
            unaPersona.AnnoIscrizione = 2010;

            Organizzazione unaOrganizzazione = new Organizzazione();
            unaOrganizzazione.Id = "ORG01";
            unaOrganizzazione.RagioneSociale = "Prima Org SRL";          
            unaOrganizzazione.AnnoIscrizione = 2010;

            //riesco a passare "unaPersona" ed "unaOrganizzazione" all'array di IUtente, perché sia la classe "Persona" che "Organizzazione" implementano "IUtente"
            utenti = new IUtente[] { unaPersona, unaOrganizzazione };

            //stampo utenti
            StampaUtenti();

        }

       

    }
}

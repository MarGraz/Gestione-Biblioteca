using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneBiblioteca
{
    public class Utente
    {
        #region old definizione campi classe, sostituiti con property
        //attributi, ossia campi classe. Impostati in private per garantire incapsulamento, ossia information hiding        
        //private string id;
        //private string nome;
        //private string cognome;
        //private int annoIscrizione;
        #endregion

        //sostituisco i campi della classe con le property
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoIscrizione { get; set; }
        //conversione metodo Denominazione() in una property chiamata Descrizione e valorizzata a runtime
        public string Descrizione { get { return Nome + " " + Cognome; } }

        //costruttore Utente
        public Utente(string id, string nome, string cognome, int annoIscrizione)
        {
            #region old costruttore per uso con campi
            //usato this come riferimento all'istanza corrente di Utente, quindi agli attributi sopra elencati
            //this.id = id;
            //this.nome = nome;
            //this.cognome = cognome;
            //this.annoIscrizione = annoIscrizione;
            #endregion

            Id = id;
            Nome = nome;
            Cognome = cognome;
            AnnoIscrizione = annoIscrizione;
        }

        #region old metodo sostituito da propert descrizione

        //metodo ritorna nome e cognome
        //public string Denominazione()
        //{
        //    return this.nome + " " + this.cognome;
        //}

        #endregion

    }
}

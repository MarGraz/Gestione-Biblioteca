using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneBibliotecaEreditarieta
{
    /// <summary>
    /// classe derivata
    /// </summary>
    public class Utente : Persona
    {       
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }

        //costruttore Utente che implementa necessariamente anche il costruttore della classe base "Persona". Se persona avesse avuto un costruttore vuoto non sarebbe stato necessario usare ":base" e relativi argomenti
        public Utente(string id, string nome, string cognome, int annoIscrizione) : base (nome, cognome)
        {
            Id = id;
            AnnoIscrizione = annoIscrizione;
        }
        
    }
}

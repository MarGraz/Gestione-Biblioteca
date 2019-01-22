﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneBibliotecaEreditarietàPolimorfismo
{
    /// <summary>
    /// classe derivata
    /// </summary>
    public class Utente : Persona
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }

        //override della proprietà Descrizione presente nella classe base "Persona"
        public override string Descrizione { get { return Id + " " + Nome + " " + Cognome; } }

        //costruttore Utente che implementa necessariamente anche il costruttore della classe base "Persona". 
        //Se persona avesse avuto un costruttore vuoto non sarebbe stato necessario usare ":base" e relativi argomenti
        public Utente(string id, string nome, string cognome, int annoIscrizione) : base (nome, cognome)
        {
            Id = id;
            AnnoIscrizione = annoIscrizione;
        }
        
    }
}

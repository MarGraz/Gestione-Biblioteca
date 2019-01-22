using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneBibliotecaEreditarietàPolimorfismo
{
    /// <summary>
    /// classe di base
    /// </summary>
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        //virtual perché in classe derivata "Utente" viene eseguito override di Descrizione
        public virtual string Descrizione { get { return Nome + " " + Cognome; } }

        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

    }
}

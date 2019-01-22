using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneBibliotecaEreditarieta
{
    /// <summary>
    /// classe di base
    /// </summary>
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string Descrizione { get { return Nome + " " + Cognome; } }

        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

    }
}

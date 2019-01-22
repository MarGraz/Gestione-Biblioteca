using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Biblioteca_Interfacce
{
    public class Persona : IUtente
    {
        public string Id { get; set; } //presente in IUtente ed obbliogatorio implementarlo in classe che lo eredita
        public int AnnoIscrizione { get; set; } //presente in IUtente ed obbliogatorio implementarlo in classe che lo eredita
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Denominazione { get { return Id + " " + Nome + " " + Cognome; } } //presente in IUtente ed obbliogatorio implementarlo in classe che lo eredita
    }
}

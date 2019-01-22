using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Biblioteca_Interfacce
{
    public interface IUtente
    {
        // 1 - metodi e proprietà di una interface sono sempre public per definizione. Non si usano modificatori di accesso
        // 2 - non si fornisce alcuna implementazione dei metodi
        // 3 - non è necessario usare la parola chiave "abstract" davanti i nomi dei metodi. Una interface è già un'abstract
        // 4 - non possono essere dichiarati metodi statici, sono tutti metodi di istanza quelli definiti in una interface, quindi necessitano dell'inizializzazione di un oggetto
        // 5 - come per gli abstract, le classi che erediteranno l'interfaccia dovranno implementare tutte le proprietà ed i metodi definiti nell'interfaccia

        //proprietà
        string Id { get; set; } 
        int AnnoIscrizione { get; set; }
        string Denominazione { get; }
    }
}

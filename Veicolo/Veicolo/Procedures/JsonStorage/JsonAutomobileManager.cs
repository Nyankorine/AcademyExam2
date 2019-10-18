using System;
using System.Collections.Generic;
using System.Text;
using Veicolo.Entities;
using Veicolo.Procedures.JsonStorage.Abstract;

namespace Veicolo.Procedures.JsonStorage
{
    public class JsonAutomobileManager:JsonBaseManager<Automobile>
    {
            protected override void RemapNuoviValoriSuEntityInLista(Automobile entitySorgente, Automobile entityDestinazione)
            {
                entityDestinazione.ID = entitySorgente.ID;
                entityDestinazione.Modello = entitySorgente.Modello;
                entityDestinazione.Marca = entitySorgente.Marca;
                entityDestinazione.NumeroCavalli = entitySorgente.NumeroCavalli;
                entityDestinazione.IsDiesel = entitySorgente.IsDiesel;
            }
    }
}

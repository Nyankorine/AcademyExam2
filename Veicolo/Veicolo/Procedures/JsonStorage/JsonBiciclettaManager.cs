using System;
using System.Collections.Generic;
using System.Text;
using Veicolo.Entities;
using Veicolo.Procedures.JsonStorage.Abstract;

namespace Veicolo.Procedures.JsonStorage
{
    public class JsonBiciclettaManager:JsonBaseManager<Bicicletta>
    {
        protected override void RemapNuoviValoriSuEntityInLista(Bicicletta entitySorgente, Bicicletta entityDestinazione)
        {
            entityDestinazione.ID = entitySorgente.ID;
            entityDestinazione.Modello = entitySorgente.Modello;
            entityDestinazione.Marca = entitySorgente.Marca;
            entityDestinazione.NumeroTelaio = entitySorgente.NumeroTelaio;
            entityDestinazione.IsElettrica = entitySorgente.IsElettrica;
        }
    }
}

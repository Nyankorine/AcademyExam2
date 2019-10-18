using System;
using System.Collections.Generic;
using System.Text;
using Veicolo.Entities.Interface;
using System.IO;
using Veicolo.Procedures.Manager;
using Newtonsoft.Json;

namespace Veicolo.Procedures.JsonStorage.Abstract
{
    public abstract class JsonBaseManager<TEntity> : IManager<TEntity>
        where TEntity : class, ICatalogoGenerico
    {
        protected abstract void RemapNuoviValoriSuEntityInLista(TEntity targetEntity, TEntity sourceEntity);

        public IList<TEntity> Carica()
        {
            //1) Percorso del file che contiene il json
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jsons");
            var path = Path.Combine(basePath, $"{typeof(TEntity).Name}.json");

            //Se il file non esiste, ritorno lista vuota
            if (!File.Exists(path))
                return new List<TEntity>();

            //2) Lettura di tutto il file e non delle singole righe
            string json = File.ReadAllText(path);

            //3) De-serializzazione della stringa in oggetti strutturati
            List<TEntity> dati = JsonConvert.DeserializeObject<List<TEntity>>(json);
            return dati;
        }

        public void Crea(TEntity entityDaCreare)
        {
            // Validazione dell'input
            if (entityDaCreare == null)
                throw new ArgumentNullException(nameof(entityDaCreare));

            //Se ho già un "Id", eccezione
            if (entityDaCreare.ID > 0)
                throw new InvalidOperationException("Attenzione! L'oggetto " +
                    $"ha già il campo 'Id' impostato al valore {entityDaCreare.ID}!");

            //Contiamo quanti record ci sono nel database esistente
            //(ci serve per sapere quale "Id" dare al nuovo elemento
            //=> Carico tutti gli elementi in archivio
            IList<TEntity> tutti = Carica();
            var count = tutti.Count;

            //Prossimo "Id" => count + 1
            var prossimoId = count + 1;

            //Assegnazione Id al nuovo elemento
            entityDaCreare.ID = prossimoId;

            //Aggiungo nuovo elemento a lista esistente
            tutti.Add(entityDaCreare);

            //Salva tutta la lista insieme
            Salva(tutti);
        }

        private void Salva(IList<TEntity> allData)
        {
            //Validazione input
            if (allData == null)
                throw new ArgumentNullException(nameof(allData));

            //1) Percorso del file che contiene il json
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jsons");
            var path = Path.Combine(basePath, $"{typeof(TEntity).Name}.json");
            
                //Serializzazione della lista in JSON
                string json = JsonConvert.SerializeObject(allData, Formatting.Indented);

                //Scrivo tutto il json nel file target
                File.WriteAllText(path, json);
           
                
        }
    }
}

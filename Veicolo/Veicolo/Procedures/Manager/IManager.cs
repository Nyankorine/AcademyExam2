using System;
using System.Collections.Generic;
using System.Text;
using Veicolo.Entities.Interface;

namespace Veicolo.Procedures.Manager
{
        /// <summary>
        /// Interfaccia per tutti gli oggetti che si occupano
        /// di fare CRUD su uno specifico sistema di storage
        /// /(es. filesystem, database SQL, file xml, ecc)
        /// </summary>
        /// <typeparam name="TEntity">Tipo di entità trattata</typeparam>
        public interface IManager<TEntity>
            where TEntity : class, ICatalogoGenerico
        {
        /// <summary>
        /// Crea l'entità passata sullo storage
        /// </summary>
        /// <param name="entityDaCreare">Entità da creare</param>
        void Crea(TEntity entityDaCreare);

            /// <summary>
            /// Carica tutte le entità nello storage
            /// </summary>
            /// <returns>Ritorna la lista di entità presenti</returns>
            IList<TEntity> Carica();
        }
    }

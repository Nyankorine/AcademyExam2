using System;
using System.Collections.Generic;
using System.Text;
using Veicolo.Entities.Interface;

namespace Veicolo.Entities.Abstract
{
    public abstract class CatalogoGenerico: ICatalogoGenerico
    {
        public int ID { get; set; }
        public string Modello { get; set; }
        public string Marca { get; set; }
    }
}

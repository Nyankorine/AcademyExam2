using System;
using System.Collections.Generic;
using System.Text;

namespace Veicolo.Entities.Interface
{
    public interface ICatalogoGenerico
    {
        public int ID { get; set; }
        public string Modello { get; set; }
        public string Marca { get; set; }
    }
}

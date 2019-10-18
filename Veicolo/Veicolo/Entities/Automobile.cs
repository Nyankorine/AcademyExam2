using System;
using System.Collections.Generic;
using System.Text;
using Veicolo.Entities.Abstract;

namespace Veicolo.Entities
{
    public class Automobile:CatalogoGenerico
    {
        //L’automobile è definita da  “Modello”, “Marca”, “NumeroCavalli”, “IsDiesel” e “DataImmatricolazione”.
        public int NumeroCavalli { get; set; }
        public bool IsDiesel { get; set; }
        public DateTime DataImmatricolazione { get; set; }
    }
}

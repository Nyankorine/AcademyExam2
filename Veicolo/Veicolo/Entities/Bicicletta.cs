using System;
using System.Collections.Generic;
using System.Text;
using Veicolo.Entities.Abstract;

namespace Veicolo.Entities
{
    public class Bicicletta: CatalogoGenerico
    {
        //La bicicletta è definita dal campo “Modello”, “Marca”, “NumeroTelaio” e “IsElettrica”; 

        public int NumeroTelaio { get; set; }
        public bool IsElettrica { get; set; }
    }
}

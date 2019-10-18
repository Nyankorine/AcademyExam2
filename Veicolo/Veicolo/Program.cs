using System;
using Veicolo.Utils;
using Veicolo.Procedures;

namespace Veicolo
{
    class Program
    {
        static void Main(string[] args)
        {

            /*10.	Esercitazione pratica. Si chiede di creare un app console in .NET Framework che, in fase di esecuzione, permetta di inserire e 
            visualizzare un catalogo di automobili e biciclette (entrambe le entità avranno le medesime funzioni). 
        	Quando l’applicazione viene avviata permette di selezione se si vuole lavorare sul catalogo delle biciclette (selezione da menu “A”) o quello 
            delle automobili (selezione da menu “B”).
            Dovrà essere possibile inserire una bicicletta (o un’automobile) e salvarla su un “database” realizzato con un file di json
            Dovrà essere possibile visualizzare il contenuto intero del database dell’oggetto di riferimento
        	Dovrà essere possibile visualizzare solo gli elementi che corrispondono al criterio di ricerca sul campo “Modello”. 
        	La bicicletta è definita dal campo “Modello”, “Marca”, “NumeroTelaio” e “IsElettrica”; 
            L’automobile è definita da  “Modello”, “Marca”, “NumeroCavalli”, “IsDiesel” e “DataImmatricolazione”.
        	Ogni entità è caratterizzata da un campo “Id” numerico che deve essere univoco nella stessa tipologia di oggetti
        	Dovrà essere presente una funzione che permette di eseguire la creazione dei mezzi di locomozione di una famiglia (N biciclette e 1 automobile), 
            passando le quantità e i valori come parametri alla funzione CreaMezziDellaFamiglia(int numeroDiBiciclette, string string marcaBiciclette, 
            string[] modelliBiciclette, string marcaAutomobile, string modelloAutomobile)*/
            //Visualizzo menu e richiedo selezione
            Console.WriteLine("*******************************");
            Console.WriteLine("*             MENU            *");
            Console.WriteLine("*******************************");
            Console.WriteLine("Seleziona un catalogo");
            Console.WriteLine("A - Catalogo Biciclette");
            Console.WriteLine("B - Catalogo Automobili");
            Console.Write("Selezione: ");
            string selezione = Console.ReadLine();

            //Selezione dell'opzione
            switch (selezione)
            {
                case "A":
                    BiciclettaWorkflow.CreaBicicletta();
                    break;
                case "B":
                    AutomobileWorkflow.CreaAutomobile();
                    break;
                default:
                    Console.WriteLine("Opzione non valida!");
                    break;
            }

            //Richiedo conferma di uscita
            ConsoleUtils.ConfermaUscita();
        }
    }
}

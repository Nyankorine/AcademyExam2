using System;
using System.Collections.Generic;
using System.Text;
using Veicolo.Entities;
using Veicolo.Procedures.Manager;
using Veicolo.Procedures.JsonStorage;

namespace Veicolo.Procedures
{
    public static class BiciclettaWorkflow
    {
        public static void CreaBicicletta()
        {
            //Istanzio il manager dei libri
            Console.WriteLine("*****************************************");
            Console.WriteLine("* ESECUZIONE DEL WORKFLOW BICICLETTA... *");
            Console.WriteLine("*****************************************");
            IManager<Bicicletta> manager = new JsonBiciclettaManager();

            var bici = new Bicicletta();
            //Console.Write("Inserisci ID: ");
            //bici.ID = int.Parse(Console.ReadLine());
            Console.Write("Inserisci Modello: ");
            bici.Modello = Console.ReadLine();
            Console.Write("Inserisci Marca: ");
            bici.Marca = Console.ReadLine();
            Console.Write("Inserisci Numero Telaio: ");
            bici.NumeroTelaio = int.Parse(Console.ReadLine());
            Console.Write("Inserisci se è elettrica [1] = SI, [0] = NO: ");
            string sel = Console.ReadLine();
            switch (sel)
            {
                case "0":
                    bici.IsElettrica = false;
                    break;
                case "1":
                    bici.IsElettrica = true;
                    break;
                default:
                    Console.WriteLine("Opzione non valida!");
                    break;
            }

            manager.Crea(bici);
            Console.WriteLine();
            Console.WriteLine("VISUALIZZAZIONE ELEMENTO BICICLETTA CREATO...");
            Console.WriteLine($"ID: {bici.ID}");
            Console.WriteLine($"Modello: {bici.Modello}");
            Console.WriteLine($"Marca: {bici.Marca}");
            Console.WriteLine($"Numero Telaio: {bici.NumeroTelaio}");
            if (bici.IsElettrica)
                Console.WriteLine("La bici è Elettrica");
            else
                Console.WriteLine("La bici non è Elettrica");
            
            Console.WriteLine();
            Console.WriteLine("LETTURA DEL FILE JSON...");
            var tutteBici = manager.Carica();
            Console.WriteLine($"Numero bici trovate: {tutteBici.Count}");
            foreach (var currentTutteBici in tutteBici)
                Console.WriteLine($"Lettura bici: {currentTutteBici.Modello} - {currentTutteBici.Marca} (ID:{currentTutteBici.ID})");

            Console.WriteLine();
            Console.WriteLine("ESEGUO LA RICERCA...");
            Console.Write("Inserisci il modello da trovare: ");
            string mod = Console.ReadLine();
            foreach (var currentTutteBici in tutteBici)
            { 
                if(mod == currentTutteBici.Modello)
                    Console.WriteLine($"Lettura bici: {currentTutteBici.Modello} - {currentTutteBici.Marca} (ID:{currentTutteBici.ID})");
            }
            Console.WriteLine();
            Console.WriteLine("Premere invio per proseguire...");
            Console.ReadLine();
        }
    }
}

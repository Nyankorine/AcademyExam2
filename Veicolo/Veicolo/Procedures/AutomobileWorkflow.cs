using System;
using System.Collections.Generic;
using System.Text;
using Veicolo.Entities;
using Veicolo.Procedures.Manager;
using Veicolo.Procedures.JsonStorage;

namespace Veicolo.Procedures
{
    public static class AutomobileWorkflow
    {
        public static void CreaAutomobile()
        {
            //Istanzio il manager dei libri
            Console.WriteLine("*****************************************");
            Console.WriteLine("* ESECUZIONE DEL WORKFLOW AUTOMOBILE... *");
            Console.WriteLine("*****************************************");
            IManager<Automobile> manager = new JsonAutomobileManager();

            var auto = new Automobile();
            //Console.Write("Inserisci ID: ");
            //auto.ID = int.Parse(Console.ReadLine());
            Console.Write("Inserisci Modello: ");
            auto.Modello = Console.ReadLine();
            Console.Write("Inserisci Marca: ");
            auto.Marca = Console.ReadLine();
            Console.Write("Inserisci Numero Cavalli: ");
            auto.NumeroCavalli = int.Parse(Console.ReadLine());
            Console.Write("Inserisci se è Diesel [1] = SI, [0] = NO: ");
            string sel = Console.ReadLine();
            switch (sel)
            {
                case "0":
                    auto.IsDiesel = false;
                    break;
                case "1":
                    auto.IsDiesel = true;
                    break;
                default:
                    Console.WriteLine("Opzione non valida!");
                    break;
            }
            manager.Crea(auto);

            Console.WriteLine();
            Console.WriteLine("VISUALIZZAZIONE ELEMENTO AUTOMOBILE CREATO...");
            Console.WriteLine($"ID: {auto.ID}");
            Console.WriteLine($"Modello: {auto.Modello}");
            Console.WriteLine($"Marca: {auto.Marca}");
            Console.WriteLine($"Numero Telaio: {auto.NumeroCavalli}");
            if(auto.IsDiesel)
                Console.WriteLine ("L'auto è Diesel");
            else
                Console.WriteLine("L'auto non è Diesel");

            Console.WriteLine();
            Console.WriteLine("LETTURA DEL FILE JSON...");
            var tutteAuto = manager.Carica();
            Console.WriteLine($"Numero auto trovate: {tutteAuto.Count}");
            foreach (var currentTutteAuto in tutteAuto)
                Console.WriteLine($"Lettura auto: {currentTutteAuto.Modello} - {currentTutteAuto.Marca} (ID:{currentTutteAuto.ID})");

            Console.WriteLine();
            Console.WriteLine("ESEGUO LA RICERCA...");
            Console.Write("Inserisci il modello da trovare: ");
            string mod = Console.ReadLine();
            foreach (var currentTutteAuto in tutteAuto)
            {
                if (mod == currentTutteAuto.Modello)
                    Console.WriteLine($"Lettura bici: {currentTutteAuto.Modello} - {currentTutteAuto.Marca} (ID:{currentTutteAuto.ID})");
            }
            Console.WriteLine();
            Console.WriteLine("Premere invio per proseguire...");
            Console.ReadLine();
        }
    }
}

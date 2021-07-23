using System;
namespace SquadraCalcio.Utilities
{
    public class Selection
    {
        public static Categoria SelezionaRuolo()
        {
            int sceltaRuolo = 0;

            Console.WriteLine($"{(int)Categoria.Portiere} - {Categoria.Portiere}");
            Console.WriteLine($"{(int)Categoria.Difensore} - {Categoria.Difensore}");
            Console.WriteLine($"{(int)Categoria.Centrocampista} - {Categoria.Centrocampista}");
            Console.WriteLine($"{(int)Categoria.Attaccante} - {Categoria.Attaccante}");

            sceltaRuolo = Utilities.Check.InteroSceltaRuolo();

            return (Categoria)sceltaRuolo;
        }

        //public static Calciatore AssegnaRuolo(Categoria ruolo, Calciatore giocatore)
        //{
        //    switch (ruolo)
        //    {
        //        case Categoria.Portiere:
        //            giocatore = new Portiere(giocatore.NumeroMaglia, giocatore.Nome, giocatore.DataDiNascita, giocatore.Ruolo);
        //            return giocatore;
        //            break;
        //        case Categoria.Difensore:
        //            giocatore = new Difensore(giocatore.NumeroMaglia, giocatore.Nome, giocatore.DataDiNascita, giocatore.Ruolo);
        //            return giocatore;
        //        case Categoria.Centrocampista:
        //            giocatore = new Centrocampista(giocatore.NumeroMaglia, giocatore.Nome, giocatore.DataDiNascita, giocatore.Ruolo);
        //            return giocatore;
        //        case Categoria.Attaccante:
        //            giocatore = new Attaccante(giocatore.NumeroMaglia, giocatore.Nome, giocatore.DataDiNascita, giocatore.Ruolo);
        //            return giocatore;
        //    }
        //    return giocatore;
        //}

        public static void ConvertiCalciatoreInRuolo(Calciatore giocatore)
        {
            Portiere p = giocatore as Portiere;

            Difensore d = giocatore as Difensore;

            Centrocampista c = giocatore as Centrocampista;

            Attaccante a = giocatore as Attaccante;
        }
    }
}

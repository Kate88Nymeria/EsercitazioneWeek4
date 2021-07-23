using System;
using System.Collections.Generic;

namespace SquadraCalcio
{
    public class SquadraManager
    {
        //public static List<Calciatore> riserve;
        //public static List<Calciatore> squadraTitolare;
        public static List<Calciatore> squadraTitolare = DataFile.team.Rosa;
        public static List<Calciatore> riserve = DataFile.team.Rosa;

        public static void AggiungiGiocatore()
        {
            Console.WriteLine("------ INSERIMENTO NUOVO GIOCATORE ------");
            Console.WriteLine();
            

            Console.WriteLine("Scegli il ruolo del giocatore:");
            Categoria ruolo = Utilities.Selection.SelezionaRuolo();
            Console.WriteLine();

            switch (ruolo)
            {
                case Categoria.Portiere:
                    Portiere p = new Portiere();
                    Console.WriteLine("Inserisci il Numero di Maglia:");
                    p.NumeroMaglia = Utilities.Check.MagliaInseritaGiaEsistente(DataFile.team.Rosa);

                    Console.WriteLine("Inserisci il Nome del Giocatore:");
                    p.Nome = Console.ReadLine();

                    Console.WriteLine("Inserisci la Data di Nascita del Giocatore (gg/mm/aaaa):");
                    p.DataDiNascita = Utilities.Check.DataNascitaValida();

                    Console.WriteLine("Inserisci il numero di Goal Subiti:");
                    p.NumeroGoalSubiti = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
                    Console.WriteLine("Inserisci il numero di Rigori Parati:");
                    p.NumeroRigoriParati = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
                    DataFile.team.Rosa.Add(p);
                    break;
                case Categoria.Difensore:
                    Difensore d = new Difensore();
                    Console.WriteLine("Inserisci il Numero di Maglia:");
                    d.NumeroMaglia = Utilities.Check.MagliaInseritaGiaEsistente(DataFile.team.Rosa);

                    Console.WriteLine("Inserisci il Nome del Giocatore:");
                    d.Nome = Console.ReadLine();

                    Console.WriteLine("Inserisci la Data di Nascita del Giocatore (gg/mm/aaaa):");
                    d.DataDiNascita = Utilities.Check.DataNascitaValida();

                    Console.WriteLine("Inserisci il numero di Contrasti Riusciti:");
                    d.NumeroContrastiRiusciti = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
                    DataFile.team.Rosa.Add(d);
                    break;
                case Categoria.Centrocampista:
                    Centrocampista c = new Centrocampista();
                    Console.WriteLine("Inserisci il Numero di Maglia:");
                    c.NumeroMaglia = Utilities.Check.MagliaInseritaGiaEsistente(DataFile.team.Rosa);

                    Console.WriteLine("Inserisci il Nome del Giocatore:");
                    c.Nome = Console.ReadLine();

                    Console.WriteLine("Inserisci la Data di Nascita del Giocatore (gg/mm/aaaa):");
                    c.DataDiNascita = Utilities.Check.DataNascitaValida();

                    Console.WriteLine("Inserisci il numero di Passaggi Tentati:");
                    c.NumeroPassaggiTentati = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
                    Console.WriteLine("Inserisci il numero di Passaggi Riusciti:");
                    c.NumeroPassaggiRiusciti = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
                    DataFile.team.Rosa.Add(c);
                    break;
                case Categoria.Attaccante:
                    Attaccante a = new Attaccante();
                    Console.WriteLine("Inserisci il Numero di Maglia:");
                    a.NumeroMaglia = Utilities.Check.MagliaInseritaGiaEsistente(DataFile.team.Rosa);

                    Console.WriteLine("Inserisci il Nome del Giocatore:");
                    a.Nome = Console.ReadLine();

                    Console.WriteLine("Inserisci la Data di Nascita del Giocatore (gg/mm/aaaa):");
                    a.DataDiNascita = Utilities.Check.DataNascitaValida();
                    Console.WriteLine("Inserisci il numero di Goal Realizzati:");
                    a.NumeroGoalRealizzati = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
                    DataFile.team.Rosa.Add(a);
                    break;
            }                
        } //eccezione, rivedere

        //public static void AggiungiGiocatore()
        //{
        //    Console.WriteLine("------ INSERIMENTO NUOVO GIOCATORE ------");
        //    Console.WriteLine();

        //    Calciatore calc = new Calciatore();
        //    Console.WriteLine("Inserisci il Numero di Maglia:");
        //    calc.NumeroMaglia = Utilities.Check.MagliaInseritaGiaEsistente(DataFile.team.Rosa);

        //    Console.WriteLine("Inserisci il Nome del Giocatore:");
        //    calc.Nome = Console.ReadLine();

        //    Console.WriteLine("Inserisci la Data di Nascita del Giocatore (gg/mm/aaaa):");
        //    calc.DataDiNascita = Utilities.Check.DataNascitaValida();

        //    Console.WriteLine("Scegli il ruolo del giocatore:");
        //    calc.Ruolo = Utilities.Selection.SelezionaRuolo();
        //    calc = Utilities.Selection.AssegnaRuolo(calc.Ruolo, calc);

        //    if(calc is Portiere)
        //    {
        //        Portiere p = (Portiere)calc;
        //        Console.WriteLine("Inserisci il numero di Goal Subiti:");
        //        p.NumeroGoalSubiti = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
        //        Console.WriteLine("Inserisci il numero di Rigori Parati:");
        //        p.NumeroRigoriParati = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
        //        DataFile.team.Rosa.Add(calc);
        //    }
        //    else if(calc is Difensore)
        //    {
        //        Difensore d = (Difensore)calc;
        //        Console.WriteLine("Inserisci il numero di Contrasti Riusciti:");
        //        d.NumeroContrastiRiusciti = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
        //        DataFile.team.Rosa.Add(d);
        //    }
        //    else if(calc is Centrocampista)
        //    {
        //        Centrocampista c = (Centrocampista)calc;
        //        Console.WriteLine("Inserisci il numero di Passaggi Tentati:");
        //        c.NumeroPassaggiTentati = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
        //        Console.WriteLine("Inserisci il numero di Passaggi Riusciti:");
        //        c.NumeroPassaggiRiusciti = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
        //        DataFile.team.Rosa.Add(c);
        //    }
        //    else
        //    {
        //        Attaccante a = (Attaccante)calc;
        //        Console.WriteLine("Inserisci il numero di Goal Realizzati:");
        //        a.NumeroGoalRealizzati = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();
        //        DataFile.team.Rosa.Add(a);
        //    }
        //}

        public static void VendiGiocatore()
        {
            Console.WriteLine("------ VENDI GIOCATORE IN RISERVA ------");
            Console.WriteLine();

            StampaGiocatoriRiserva();
            Console.WriteLine();
            Console.WriteLine("Inserisci il numero della maglia del giocatore da vendere:");
            Calciatore calciatoreDaVendere = Utilities.Selection.ScegliMaglia(DataFile.team.Rosa);

            Console.WriteLine($"Hai venduto {calciatoreDaVendere.Nome}");
            Console.WriteLine($"Premi un tasto per continuare");
            Console.ReadKey();
            Console.Clear();
            DataFile.team.Rosa.Remove(calciatoreDaVendere);
        }

        public static void StampaGiocatoriRiserva()
        {
            string stringaGiocatori = "";

            Console.WriteLine("{0,-10}{1,-30}{2,-20}{3,-20}{4,15}{5, 15}{6, 20}{7,20}{8,20}{9,20}", "Maglia", "Nome", "Ruolo", "Data di Nascita", "Goal Subiti", "Rigori Parati",
                "Tackle Riusciti", "Passaggi Tentati", "Passaggi Riusciti", "Goal Realizzati");
            Console.WriteLine(new string('-', 200));

            foreach (Calciatore c in riserve)
            {
                stringaGiocatori += (c + Environment.NewLine);
            }
            Console.WriteLine(stringaGiocatori);
        } //cancellare public static List<Calciatore> riserve = DataFile.team.Rosa; in alto

        public static void StampaGiocatoriTitolari()
        {
            Console.WriteLine("------ SQUADRA TITOLARE ------");

            Console.WriteLine();
            Console.WriteLine("------ PORTIERE ------");
            Console.WriteLine("{0,-10}{1,-30}{2,-20}{3,-20}{4,15}{5, 15}{6, 20}{7,20}{8,20}{9,20}", "Maglia", "Nome", "Ruolo", "Data di Nascita", "Goal Subiti", "Rigori Parati",
               "Tackle Riusciti", "Passaggi Tentati", "Passaggi Riusciti", "Goal Realizzati");
            Console.WriteLine(new string('-', 200));

            foreach (Calciatore giocatore in squadraTitolare)
            {
                if(giocatore is Portiere)
                    Console.WriteLine(giocatore);
            }

            Console.WriteLine();
            Console.WriteLine("------ DIFENSORI ------");
            Console.WriteLine("{0,-10}{1,-30}{2,-20}{3,-20}{4,15}{5, 15}{6, 20}{7,20}{8,20}{9,20}", "Maglia", "Nome", "Ruolo", "Data di Nascita", "Goal Subiti", "Rigori Parati",
               "Tackle Riusciti", "Passaggi Tentati", "Passaggi Riusciti", "Goal Realizzati");
            Console.WriteLine(new string('-', 200));

            foreach (Calciatore giocatore in squadraTitolare)
            {
                if (giocatore is Difensore)
                    Console.WriteLine(giocatore);
            }

            Console.WriteLine();
            Console.WriteLine("------ CENTROCAMPISTI ------");
            Console.WriteLine("{0,-10}{1,-30}{2,-20}{3,-20}{4,15}{5, 15}{6, 20}{7,20}{8,20}{9,20}", "Maglia", "Nome", "Ruolo", "Data di Nascita", "Goal Subiti", "Rigori Parati",
               "Tackle Riusciti", "Passaggi Tentati", "Passaggi Riusciti", "Goal Realizzati");
            Console.WriteLine(new string('-', 200));

            foreach (Calciatore giocatore in squadraTitolare)
            {
                if (giocatore is Centrocampista)
                    Console.WriteLine(giocatore);
            }

            Console.WriteLine();
            Console.WriteLine("------ ATTACCANTI ------");
            Console.WriteLine("{0,-10}{1,-30}{2,-20}{3,-20}{4,15}{5, 15}{6, 20}{7,20}{8,20}{9,20}", "Maglia", "Nome", "Ruolo", "Data di Nascita", "Goal Subiti", "Rigori Parati",
               "Tackle Riusciti", "Passaggi Tentati", "Passaggi Riusciti", "Goal Realizzati");
            Console.WriteLine(new string('-', 200));

            foreach (Calciatore giocatore in squadraTitolare)
            {
                if (giocatore is Attaccante)
                    Console.WriteLine(giocatore);
            }

            Console.WriteLine();
        } //cancellare public static List<Calciatore> squadraTitolare = DataFile.team.Rosa; in alto

        //public static void GestisciSquadraTitolare()
        //{
        //    Console.WriteLine("------ GESTISCI SQUADRA TITOLARE ------");
        //    Console.WriteLine();

        //    StampaGiocatoriRiserva();
        //    List<Calciatore> squadraTit = new List<Calciatore>();
        //    int contaPortieri = 0;
        //    int contaDifensori = 0;
        //    int contaCentrocampisti = 0;
        //    int contaAttaccanti = 0;

        //    for (int i = 0; i < 11; i++)
        //    {
        //        Console.WriteLine("Inserisci il numero della maglia del giocatore da vendere:");
        //        int maglia = Utilities.Check.InteroNumeroMaglia();

        //        foreach (Calciatore c in squadraTit)
        //        {
        //            if (c is Portiere)
        //                contaPortieri++;
        //            else if (c is Difensore)
        //                contaDifensori++;
        //            else if (c is Centrocampista)
        //                contaCentrocampisti++;
        //            else
        //                contaAttaccanti++;
        //        }

        //        int conta = 0;
        //        bool numeroCorretto = false;

        //        do
        //        {
        //            foreach (Calciatore c in DataFile.team.Rosa)
        //            {
        //                if (maglia == c.NumeroMaglia)
        //                {
        //                    numeroCorretto = true;
        //                }
        //                else
        //                {
        //                    conta++;
        //                }
        //            }

        //            if (conta == DataFile.team.Rosa.Count)
        //            {
        //                Console.WriteLine("Errore: Il numero di maglia inserito non è presente nella squadra. Riprova:");
        //            }
        //        } while (!numeroCorretto);

        //        foreach (Calciatore c in DataFile.team.Rosa)
        //        {
        //            if (maglia == c.NumeroMaglia)
        //            {
        //                if (c is Portiere && contaPortieri == 0)
        //                    squadraTit.Add(c);
        //                else if (c is Difensore && contaDifensori < 5)
        //                    squadraTit.Add(c);
        //                else if (c is Centrocampista && contaCentrocampisti < 5)
        //                    squadraTit.Add(c);
        //                else if (contaAttaccanti < 3)
        //                    squadraTit.Add(c);
        //            }

        //            Console.WriteLine($"Hai inserito {c.Nome} nel ruolo di {c.Ruolo}");
        //        }
        //    }

        //    squadraTitolare = squadraTit;
        //} //correggere, gestire liste riserve e squadraTitolare
    }
}

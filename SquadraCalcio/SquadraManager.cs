using System;
using System.Collections.Generic;

namespace SquadraCalcio
{
    public class SquadraManager
    {
        public static List<Calciatore> squadraTitolare;

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
        }

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
            Console.WriteLine("------ VENDI GIOCATORE ------");
            Console.WriteLine();

            StampaGiocatori();
            Console.WriteLine();
            Console.WriteLine("Inserisci il numero della maglia del giocatore da vendere:");
            int maglia = Utilities.Check.InteroNumeroMaglia();
            int conta = 0;
            bool numeroCorretto = false;

            do
            {
                foreach (Calciatore c in DataFile.team.Rosa)
                {
                    if (maglia == c.NumeroMaglia)
                    {
                        Console.WriteLine($"Hai venduto {c.Nome}");
                        DataFile.team.Rosa.Remove(c);
                        numeroCorretto = true;
                    }
                    else
                    {
                        conta++;
                    }
                }

                if (conta == DataFile.team.Rosa.Count)
                {
                    Console.WriteLine("Errore: Il numero di maglia inserito non è presente nella squadra. Riprova:");
                }
            } while (!numeroCorretto);
        }

        public static void StampaGiocatori()
        {
            Console.WriteLine($"{0,-10}{1,-30}{2,-20}{3,-20}", "Numero Maglia", "Nome", "Ruolo", "Data di Nascita");
            Console.WriteLine("-", 150);

            foreach (Calciatore c in DataFile.team.Rosa)
            {
                Console.WriteLine(c);
            }
        }

        public static void GestisciSquadraTitolare()
        {
            Console.WriteLine("------ GESTISCI SQUADRA TITOLARE ------");
            Console.WriteLine();

            StampaGiocatori();
            List<Calciatore> squadraTit= new List<Calciatore>();
            int contaPortieri = 0;
            int contaDifensori = 0;
            int contaCentrocampisti = 0;
            int contaAttaccanti = 0;

            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine("Inserisci il numero della maglia del giocatore da vendere:");
                int maglia = Utilities.Check.InteroNumeroMaglia();

                foreach (Calciatore c in squadraTit)
                {
                    if (c is Portiere)
                        contaPortieri++;
                    else if (c is Difensore)
                        contaDifensori++;
                    else if (c is Centrocampista)
                        contaCentrocampisti++;
                    else
                        contaAttaccanti++;
                }

                int conta = 0;
                bool numeroCorretto = false;

                do
                {
                    foreach (Calciatore c in DataFile.team.Rosa)
                    {
                        if (maglia == c.NumeroMaglia)
                        {
                            numeroCorretto = true;
                        }
                        else
                        {
                            conta++;
                        }
                    }

                    if (conta == DataFile.team.Rosa.Count)
                    {
                        Console.WriteLine("Errore: Il numero di maglia inserito non è presente nella squadra. Riprova:");
                    }
                } while (!numeroCorretto);

                foreach (Calciatore c in DataFile.team.Rosa)
                {
                    if(maglia == c.NumeroMaglia)
                    {
                        if (c is Portiere && contaPortieri == 0)
                            squadraTit.Add(c);
                        else if (c is Difensore && contaDifensori < 5)
                            squadraTit.Add(c);
                        else if (c is Centrocampista && contaCentrocampisti < 5)
                            squadraTit.Add(c);
                        else if (contaAttaccanti < 3)
                            squadraTit.Add(c);
                    }

                    Console.WriteLine($"Hai inserito {c.Nome} nel ruolo di {c.Ruolo}");
                }
            }

            squadraTitolare = squadraTit;
        }

        public static void StampaSquadraTitolare()
        {
            Console.WriteLine("------ SQUADRA TITOLARE ------");
            Console.WriteLine();

            if(squadraTitolare.Count == 0)
            {
                Console.WriteLine("Attenzione. La squadra titolare è vuota.");
            }
            else
            {
                Console.WriteLine("------ PORTIERI ------");
                Console.WriteLine();
                Console.WriteLine($"{0,-10}{1,-30}{2,-20}{3,-20}{4,-20}", "Numero Maglia", "Nome", "Data di Nascita", "Goal Subiti", "Rigori Parati");
                Console.WriteLine("-", 150);
                foreach (Portiere p in squadraTitolare)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();

                Console.WriteLine("------ DIFENSORI ------");
                Console.WriteLine();
                Console.WriteLine($"{0,-10}{1,-30}{2,-20}{3,-20}", "Numero Maglia", "Nome", "Data di Nascita", "Contrasti Riusciti");
                Console.WriteLine("-", 150);
                foreach (Difensore d in squadraTitolare)
                {
                    Console.WriteLine(d);
                }
                Console.WriteLine();

                Console.WriteLine("------ CENTROCAMPISTI ------");
                Console.WriteLine();
                Console.WriteLine($"{0,-10}{1,-30}{2,-20}{3,-20}{4,-20}", "Numero Maglia", "Nome", "Data di Nascita", "Passaggi Tentati", "Passaggi Riusciti");
                Console.WriteLine("-", 150);
                foreach (Centrocampista c in squadraTitolare)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine();

                Console.WriteLine("------ ATTACCANTI ------");
                Console.WriteLine();
                Console.WriteLine($"{0,-10}{1,-30}{2,-20}{3,-20}", "Numero Maglia", "Nome", "Data di Nascita", "Goal Realizzati");
                Console.WriteLine("-", 150);
                foreach (Attaccante a in squadraTitolare)
                {
                    Console.WriteLine(a);
                }
            }
            
        }

    }
}

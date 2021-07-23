using System;
namespace SquadraCalcio
{
    public class SquadraTitolareManager
    {
        public static void GestisciSquadraTitolare()
        {
            Console.WriteLine("------ GESTISCI SQUADRA TITOLARE ------");
            Console.WriteLine();

            bool continua = true;
            int scelta = 0;

            do
            {
                Console.WriteLine("Scegli il numero di un'azione da eseguire");
                Console.WriteLine("1 - Aggiungi giocatore alla Squadra Titolare");
                Console.WriteLine("2 - Rimuovi giocatore dalla Squadra Titolare");
                Console.WriteLine("3 - Visualizza tutti i giocatori");
                Console.WriteLine("0 - Torna al Menù principale");

                scelta = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();

                switch (scelta)
                {
                    case 1:
                        Console.Clear();
                        InserisciGiocatore();
                        break;
                    case 2:
                        Console.Clear();
                        RimuoviGiocatore();
                        break;
                    case 3:
                        Console.Clear();
                        SquadraManager.StampaGiocatoriTitolari();
                        Console.WriteLine();

                        Console.WriteLine("------ RISERVE SQUADRA------");

                        Console.WriteLine();
                        SquadraManager.StampaGiocatoriRiserva();
                        Console.WriteLine("Premi un tasto per uscire");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Errore: Scelta non ammessa.");
                        break;
                }

            } while (continua);

            Console.Clear();
        }

        public static void InserisciGiocatore() 
        {
            if (SquadraManager.riserve.Count == 11)
            {
                Console.WriteLine("La Squadra è già completa, non puoi inserire altri elementi");
            }
            else
            {
                int contaPortieri = 0;
                int contaDifensori = 0;
                int contaCentrocampisti = 0;
                int contaAttaccanti = 0;

                foreach (Calciatore c in SquadraManager.squadraTitolare)
                {
                    if (c is Portiere)
                    {
                        contaPortieri++;
                    }
                    else if (c is Difensore)
                    {
                        contaDifensori++;
                    }
                    else if (c is Centrocampista)
                    {
                        contaCentrocampisti++;
                    }
                    else
                        contaAttaccanti++;
                }

                Console.WriteLine("------ GIOCATORI IN RISERVA ------");
                Console.WriteLine();

                SquadraManager.StampaGiocatoriRiserva();
                Console.WriteLine();
                Console.WriteLine("Inserisci il numero della maglia del giocatore da inserire nella squadra titolare:");
                Calciatore calciatoreDaInserire = Utilities.Selection.ScegliMaglia(SquadraManager.riserve);


                if (calciatoreDaInserire is Portiere && contaPortieri == 0)
                    SquadraManager.squadraTitolare.Add(calciatoreDaInserire);
                else if (calciatoreDaInserire is Difensore && contaDifensori < 5)
                    SquadraManager.squadraTitolare.Add(calciatoreDaInserire);
                else if (calciatoreDaInserire is Centrocampista && contaCentrocampisti < 5)
                    SquadraManager.squadraTitolare.Add(calciatoreDaInserire);
                else if (contaAttaccanti < 3)
                    SquadraManager.squadraTitolare.Add(calciatoreDaInserire);

                Console.WriteLine($"Hai inserito {calciatoreDaInserire.Nome} nel ruolo di {calciatoreDaInserire.Ruolo}");
            }
        }

        public static void RimuoviGiocatore()
        {
            SquadraManager.StampaGiocatoriTitolari();

            Console.WriteLine("Inserisci il numero della maglia del giocatore da rimuovere dalla squadra titolare:");
            Calciatore calciatoreDaRimuovere = Utilities.Selection.ScegliMaglia(SquadraManager.squadraTitolare);

            Console.WriteLine();
            Console.WriteLine($"Hai rimosso {calciatoreDaRimuovere.Nome} dalla squadra titolare");
            Console.WriteLine();
            Console.WriteLine($"Premi un tasto per continuare");
            Console.ReadKey();
            Console.Clear();
            SquadraManager.squadraTitolare.Remove(calciatoreDaRimuovere);
        }
    }
}
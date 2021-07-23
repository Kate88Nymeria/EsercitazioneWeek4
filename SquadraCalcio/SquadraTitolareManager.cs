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

        public static void InserisciGiocatore() //implementare
        {

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



        #region
//        StampaGiocatoriRiserva();
//        List<Calciatore> squadraTit = new List<Calciatore>();
//        int contaPortieri = 0;
//        int contaDifensori = 0;
//        int contaCentrocampisti = 0;
//        int contaAttaccanti = 0;

//            for (int i = 0; i< 11; i++)
//            {
//                Console.WriteLine("Inserisci il numero della maglia del giocatore da vendere:");
//                int maglia = Utilities.Check.InteroNumeroMaglia();

//                foreach (Calciatore c in squadraTit)
//                {
//                    if (c is Portiere)
//                        contaPortieri++;
//                    else if (c is Difensore)
//                        contaDifensori++;
//                    else if (c is Centrocampista)
//                        contaCentrocampisti++;
//                    else
//                        contaAttaccanti++;
//                }

//    int conta = 0;
//    bool numeroCorretto = false;

//                do
//                {
//                    foreach (Calciatore c in DataFile.team.Rosa)
//                    {
//                        if (maglia == c.NumeroMaglia)
//                        {
//                            numeroCorretto = true;
//                        }
//                        else
//{
//    conta++;
//}
//                    }

//                    if (conta == DataFile.team.Rosa.Count)
//{
//    Console.WriteLine("Errore: Il numero di maglia inserito non è presente nella squadra. Riprova:");
//}
//                } while (!numeroCorretto) ;

//foreach (Calciatore c in DataFile.team.Rosa)
//{
//    if (maglia == c.NumeroMaglia)
//    {
//        if (c is Portiere && contaPortieri == 0)
//            squadraTit.Add(c);
//        else if (c is Difensore && contaDifensori < 5)
//            squadraTit.Add(c);
//        else if (c is Centrocampista && contaCentrocampisti < 5)
//            squadraTit.Add(c);
//        else if (contaAttaccanti < 3)
//            squadraTit.Add(c);
//    }

//    Console.WriteLine($"Hai inserito {c.Nome} nel ruolo di {c.Ruolo}");
//}
//            }

//            squadraTitolare = squadraTit;
//        } //correggere, gestire liste riserve e squadraTitolare
        #endregion
    }
}

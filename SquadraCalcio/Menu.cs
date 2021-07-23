using System;
namespace SquadraCalcio
{
    public class Menu
    {
        public static void Start()
        {
            bool continua = true;
            int scelta = 0;

            Console.WriteLine();

            do
            {
                Console.WriteLine("Scegli il numero di un'azione da eseguire");
                Console.WriteLine("1 - Aggiungi giocatore alla Rosa");
                Console.WriteLine("2 - Vendi Giocatore");
                Console.WriteLine("3 - Gestisci Squadra Titolare");
                Console.WriteLine("4 - Stampa le statistiche della Squadra Titolare");
                Console.WriteLine("0 - Esci dal Programma");

                scelta = Utilities.Check.InteroMaggioreOUgualeAZeroLetto();

                switch (scelta)
                {
                    case 1:
                        Console.Clear();
                        SquadraManager.AggiungiGiocatore();
                        break;
                    case 2:
                        Console.Clear();
                        SquadraManager.VendiGiocatore();
                        break;
                    case 3:
                        Console.Clear();
                        SquadraTitolareManager.GestisciSquadraTitolare();
                        break;
                    case 4:
                        Console.Clear();
                        SquadraManager.StampaGiocatoriTitolari();
                        Console.WriteLine("Premi un tasto per uscire");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        Console.Clear();
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Errore: Scelta non ammessa.");
                        break;
                }
            }while(continua);
        }
    }
}

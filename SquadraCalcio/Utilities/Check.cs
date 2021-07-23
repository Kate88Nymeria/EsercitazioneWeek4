using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace SquadraCalcio.Utilities
{
    public class Check
    {
        public static int InteroNumeroMaglia()
        {
            bool isInt = false;
            int numeroIntero = 0;

            do
            {
                isInt = int.TryParse(Console.ReadLine(), out numeroIntero);

                if (!isInt || numeroIntero <= 0 || numeroIntero >= 100)
                {
                    Console.WriteLine("Errore: non hai inserito un numero intero compreso tra 1 e 99. Riprova:");
                }
            } while (!isInt || numeroIntero <= 0 || numeroIntero >= 100);

            return numeroIntero;
        }

        public static int InteroSceltaRuolo()
        {
            bool isInt = false;
            int numeroIntero = 0;

            do
            {
                isInt = int.TryParse(Console.ReadLine(), out numeroIntero);

                if (!isInt || numeroIntero < 0 || numeroIntero > 3)
                {
                    Console.WriteLine("Errore: non hai inserito un numero intero compreso tra 0 e 3. Riprova:");
                }
            } while (!isInt || numeroIntero < 0 || numeroIntero > 3);

            return numeroIntero;
        }

        public static int InteroMaggioreOUgualeAZeroLetto()
        {
            bool isInt = false;
            int numeroIntero = 0;

            do
            {
                isInt = int.TryParse(Console.ReadLine(), out numeroIntero);

                if (!isInt || numeroIntero < 0)
                {
                    Console.WriteLine("Errore: inserisci un numero intero maggiore o uguale a zero:");
                }
            } while (!isInt || numeroIntero < 0);

            return numeroIntero;
        }

        public static int MagliaInseritaGiaEsistente(List<Calciatore> calciatori)
        {
            calciatori = new List<Calciatore>();
            bool numeroCorretto = false;
            int numeroInserito = 0;

            do
            {
                numeroInserito = InteroNumeroMaglia();

                if (calciatori.Count != 0)
                {
                    foreach (Calciatore c in calciatori)
                    {
                        if (numeroInserito == c.NumeroMaglia)
                        {
                            Console.Write("Errore: Questo Numero di Maglia è già presente nella Squadra. Riprova:");
                        }
                        else
                        {
                            numeroCorretto = true;
                        }
                    }
                }
                else
                    numeroCorretto = true;
            } while (!numeroCorretto);
            
            return numeroInserito;
        }

        public static DateTime DataNascitaValida()
        {
            bool isDate = false;
            DateTime data = new DateTime();

            do
            {
                isDate = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data);
                //devo usare questo sistema anzichè il TryParse classico perchè il mio pc ha un utc particolare impostato e mi scambia il mese col giorno

                if(!isDate || data >= DateTime.Now)
                {
                    Console.WriteLine("Errore: non hai inserito una data valida. Riprova:");
                }
            } while (!isDate);

            return data;
        }

        public static string StampaData(DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
        }
    }
}

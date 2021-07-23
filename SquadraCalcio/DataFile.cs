using System;
namespace SquadraCalcio
{
    public class DataFile
    {
        public static Squadra team = new Squadra()
        {
            Nome = "Topolinia",
            NomeAllenatore = "Pippo",
            NomePresidente = "Zio Paperone",
            DataFondazione = DateTime.Parse("12 / 09 / 1971"),
            CampionatoDisputato = "Champions League 2112",
        };
    }
}

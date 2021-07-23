using System;
namespace SquadraCalcio
{
    public class Attaccante : Calciatore
    {
        public int NumeroGoalRealizzati { get; set; }

        public override string ToString()
        {
            string stampa = $"{NumeroMaglia,-10}{Nome,-30}{Ruolo,-20}{Utilities.Check.StampaData(DataDiNascita),-20}{"-",15}{"-",15}{"-",20}" +
                $"{"-",20}{"-",20}{NumeroGoalRealizzati,20}";
            return stampa;
        }

        
    }
}

using System;
namespace SquadraCalcio
{
    public class Portiere : Calciatore
    {
        public int NumeroGoalSubiti { get; set; }
        public int NumeroRigoriParati { get; set; }


        public override string ToString()
        {
            string stampa = $"{NumeroMaglia,-10}{Nome,-30}{Ruolo,-20}{Utilities.Check.StampaData(DataDiNascita),-20}{NumeroGoalSubiti,15}{NumeroRigoriParati,15}{"-",20}" +
                $"{"-",20}{"-",20}{"-",20}";
            return stampa;
        }

    }
}

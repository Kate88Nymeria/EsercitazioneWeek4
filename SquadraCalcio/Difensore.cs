using System;
namespace SquadraCalcio
{
    public class Difensore : Calciatore
    {
        public int NumeroContrastiRiusciti { get; set; }


        public override string ToString()
        {
            string stampa = $"{NumeroMaglia,-10}{Nome,-30}{Ruolo,-20}{Utilities.Check.StampaData(DataDiNascita),-20}{"-",15}{"-", 15}{NumeroContrastiRiusciti,20}" +
                $"{"-",20}{"-",20}{"-",20}";
            return stampa;
        }
    }
}

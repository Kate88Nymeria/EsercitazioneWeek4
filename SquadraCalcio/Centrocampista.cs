using System;
namespace SquadraCalcio
{
    public class Centrocampista : Calciatore
    {
        public int NumeroPassaggiTentati { get; set; }
        public int NumeroPassaggiRiusciti { get; set; }

        public override string ToString()
        {
            string stampa = $"{NumeroMaglia,-10}{Nome,-30}{Ruolo,-20}{Utilities.Check.StampaData(DataDiNascita), -20}{"-", 15}{"-",15}{"-",20}" +
                $"{NumeroPassaggiTentati,20}{NumeroPassaggiRiusciti,20}{"-",20}";
            return stampa;
        }
    }
}

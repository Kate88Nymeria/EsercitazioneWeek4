using System;
namespace SquadraCalcio
{
    public class Centrocampista : Calciatore
    {
        public int NumeroPassaggiTentati { get; set; }
        public int NumeroPassaggiRiusciti { get; set; }

        public override string ToString()
        {
            string stampa = $"{NumeroMaglia,-10}{Nome,-30}{DataDiNascita,-20}{NumeroPassaggiTentati,-20}{NumeroPassaggiRiusciti,-20}";
            return stampa;
        }
    }
}

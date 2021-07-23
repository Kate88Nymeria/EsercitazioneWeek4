using System;
namespace SquadraCalcio
{
    public class Difensore : Calciatore
    {
        public int NumeroContrastiRiusciti { get; set; }


        public override string ToString()
        {
            string stampa = $"{NumeroMaglia,-10}{Nome,-30}{DataDiNascita,-20}{NumeroContrastiRiusciti,-20}";
            return stampa;
        }
    }
}

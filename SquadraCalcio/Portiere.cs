using System;
namespace SquadraCalcio
{
    public class Portiere : Calciatore
    {
        public int NumeroGoalSubiti { get; set; }
        public int NumeroRigoriParati { get; set; }


        public override string ToString()
        {
            string stampa = $"{NumeroMaglia,-10}{Nome,-30}{DataDiNascita,-20}{NumeroGoalSubiti,-20}{NumeroRigoriParati,-20}";
            return stampa;
        }
    }
}

using System;
namespace SquadraCalcio
{
    public class Attaccante : Calciatore
    {
        public int NumeroGoalRealizzati { get; set; }

        public override string ToString()
        {
            string stampa = $"{NumeroMaglia,-10}{Nome,-30}{DataDiNascita,-20}{NumeroGoalRealizzati,-20}";
            return stampa;
        }
    }
}

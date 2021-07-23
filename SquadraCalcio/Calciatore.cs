using System;
namespace SquadraCalcio
{
    public abstract class Calciatore
    {
        public int NumeroMaglia { get; set; }
        public string Nome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public Categoria Ruolo { get; set; } 

        public override string ToString()
        {
            string stampa = $"{NumeroMaglia, -10}{Nome, -30}{Ruolo, -20}{DataDiNascita, -20}";
            return stampa;
        }
    }
}

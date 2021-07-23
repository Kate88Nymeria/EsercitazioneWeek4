using System;
using System.Collections;
using System.Collections.Generic;

namespace SquadraCalcio
{
    public class Squadra
    {
        public string Nome { get; set; }
        public DateTime DataFondazione { get; set; }
        public string CampionatoDisputato { get; set; }
        public string NomePresidente { get; set; }
        public string NomeAllenatore { get; set; }
        public ArrayList Rosa { get; set; }
    }
}

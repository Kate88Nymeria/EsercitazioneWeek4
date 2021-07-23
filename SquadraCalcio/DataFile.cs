using System;
using System.Collections.Generic;

namespace SquadraCalcio
{
    public class DataFile
    {
        public static Squadra team = new Squadra()
        {
            Nome = "Topolinia",
            NomeAllenatore = "Pippo",
            NomePresidente = "Zio Paperone",
            DataFondazione = DateTime.Parse("12 / 09 / 1971"),
            CampionatoDisputato = "Champions League 2112",
            Rosa = new List<Calciatore>()
            {
                new Portiere{ NumeroMaglia = 1, Nome = "Portiere1", DataDiNascita = DateTime.Parse("12 / 22 / 1981") , Ruolo = Categoria.Portiere, NumeroGoalSubiti = 12, NumeroRigoriParati =21 },
                new Portiere{ NumeroMaglia = 2, Nome = "Portiere2", DataDiNascita = DateTime.Parse("01 / 02 / 1987") , Ruolo = Categoria.Portiere, NumeroGoalSubiti = 15, NumeroRigoriParati =18 },
                new Portiere{ NumeroMaglia = 3, Nome = "Portiere3", DataDiNascita = DateTime.Parse("03 / 01 / 1989") , Ruolo = Categoria.Portiere, NumeroGoalSubiti = 10, NumeroRigoriParati =15 },
                new Difensore{ NumeroMaglia = 4, Nome = "Difensore1", DataDiNascita = DateTime.Parse("10 / 01 / 1989") , Ruolo = Categoria.Difensore, NumeroContrastiRiusciti = 23 },
                new Difensore{ NumeroMaglia = 5, Nome = "Difensore2", DataDiNascita = DateTime.Parse("07 / 01 / 1989") , Ruolo = Categoria.Difensore, NumeroContrastiRiusciti = 27 },
                new Difensore{ NumeroMaglia = 6, Nome = "Difensore3", DataDiNascita = DateTime.Parse("09 / 01 / 1989") , Ruolo = Categoria.Difensore, NumeroContrastiRiusciti = 23 },
                new Difensore{ NumeroMaglia = 7, Nome = "Difensore4", DataDiNascita = DateTime.Parse("02 / 01 / 1989") , Ruolo = Categoria.Difensore, NumeroContrastiRiusciti = 27 },
                new Difensore{ NumeroMaglia = 8, Nome = "Difensore5", DataDiNascita = DateTime.Parse("06 / 01 / 1989") , Ruolo = Categoria.Difensore, NumeroContrastiRiusciti = 23 },
                new Difensore{ NumeroMaglia = 9, Nome = "Difensore6", DataDiNascita = DateTime.Parse("05 / 01 / 1989") , Ruolo = Categoria.Difensore, NumeroContrastiRiusciti = 27 },
                new Centrocampista{ NumeroMaglia = 10, Nome = "Centrocampista1", DataDiNascita = DateTime.Parse("07 / 01 / 1989") , Ruolo = Categoria.Centrocampista, NumeroPassaggiTentati = 32, NumeroPassaggiRiusciti = 24 },
                new Centrocampista{ NumeroMaglia = 11, Nome = "Centrocampista2", DataDiNascita = DateTime.Parse("08 / 01 / 1989") , Ruolo = Categoria.Centrocampista, NumeroPassaggiTentati = 32, NumeroPassaggiRiusciti = 24 },
                new Centrocampista{ NumeroMaglia = 12, Nome = "Centrocampista3", DataDiNascita = DateTime.Parse("11 / 01 / 1989") , Ruolo = Categoria.Centrocampista, NumeroPassaggiTentati = 32, NumeroPassaggiRiusciti = 24 },
                new Centrocampista{ NumeroMaglia = 13, Nome = "Centrocampista4", DataDiNascita = DateTime.Parse("08 / 01 / 1989") , Ruolo = Categoria.Centrocampista, NumeroPassaggiTentati = 32, NumeroPassaggiRiusciti = 24 },
                new Centrocampista{ NumeroMaglia = 14, Nome = "Centrocampista5", DataDiNascita = DateTime.Parse("01 / 01 / 1989") , Ruolo = Categoria.Centrocampista, NumeroPassaggiTentati = 32, NumeroPassaggiRiusciti = 24 },
                new Attaccante{ NumeroMaglia = 15, Nome = "Attaccante1", DataDiNascita = DateTime.Parse("04 / 01 / 1989") , Ruolo = Categoria.Attaccante, NumeroGoalRealizzati = 19 },
                new Attaccante{ NumeroMaglia = 16, Nome = "Attaccante2", DataDiNascita = DateTime.Parse("05 / 01 / 1989") , Ruolo = Categoria.Attaccante, NumeroGoalRealizzati = 19 },
                new Attaccante{ NumeroMaglia = 17, Nome = "Attaccante3", DataDiNascita = DateTime.Parse("01 / 01 / 1989") , Ruolo = Categoria.Attaccante, NumeroGoalRealizzati = 19 },
                new Attaccante{ NumeroMaglia = 18, Nome = "Attaccante4", DataDiNascita = DateTime.Parse("09 / 01 / 1989") , Ruolo = Categoria.Attaccante, NumeroGoalRealizzati = 19 }
            }
        };
    }
}

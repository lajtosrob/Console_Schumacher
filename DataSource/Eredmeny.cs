﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Schumacher.DataSource
{
    internal class Eredmeny
    {
        string date;
        string grandprix;
        int position;
        int laps;
        int points;
        string team;
        string status;

        public Eredmeny(string date, string grandprix, int position, int laps, int points, string team, string status)
        {
            this.date = date;
            this.grandprix = grandprix;
            this.position = position;
            this.laps = laps;
            this.points = points;
            this.team = team;
            this.status = status;
        }

        public string Date { get => date; set => date = value; }
        public string Grandprix { get => grandprix; set => grandprix = value; }

        public int Position { get => position; set => position = value; }   
        public int Laps { get => laps; set => laps = value; }
        public int Points { get => points; set => points = value; }
        public string Team { get => team; set => team = value; }
        public string Status { get => status; set => status = value; }
    }
}

﻿using PlayByPlayParserConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent
{
    internal class KickoffEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Kickoff";
        public string Kicker { get; set; }
        public int KickYards { get; set; }
        public bool isReturned { get; set; }
        public string? Returner { get; set; }
        public int ReturnYards { get; set; }
        public string[]? Tacklers { get; set; }
        public override string ToString()
        {
            string kickString = $"{PlayType} - Kicker: {Kicker}, Kick Yards: {KickYards}";

            if (isReturned)
            {
                kickString += $", Returner: {Returner}, Return Yards: {ReturnYards}";
            }

            return kickString;
        }
    }
}
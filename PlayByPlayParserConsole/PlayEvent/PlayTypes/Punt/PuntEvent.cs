using PlayByPlayParserConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Punt
{
    internal class PuntEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Punt";
        public string? Punter { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsReturned { get; set; }
        public int PuntYards { get; set; }
        public string? PuntReturner { get; set; }
        public string? PuntBlocker { get; set; }
        public int ReturnYards { get; set; }
        public List<string>? Tacklers { get; set; }
        public bool IsTouchdown { get; set; }

        public override string ToString()
        {
            string puntString = $"{PlayType} - Punter: {Punter}, Punt Yards: {PuntYards}";

            puntString += IsBlocked ? $", BLOCKED by {PuntBlocker}" : "";
            puntString += IsReturned ? $", Returned by {PuntReturner} for {ReturnYards}" : "";
            puntString += IsTouchdown ? ", TOUCHDOWN!" : "";

            return puntString;
        }

        public bool isScoringPlay()
        {
            if (IsTouchdown)
            {
                return true;
            }
            return false;
        }
    }
}

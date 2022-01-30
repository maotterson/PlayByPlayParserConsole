using PlayByPlayParserConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Penalty
{
    internal class PenaltyEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Penalty";
        public int PenaltyYards { get; set; }
        public string PenaltyType { get; set; }
        public string Player { get; set; }
        public bool isAccepted { get; set; }
        public override string ToString()
        {
            string penaltyString = $"{PlayType} - Type: {PenaltyType}, Player: {Player}, Yards: {PenaltyYards}, ";
            penaltyString += isAccepted ? "Accepted" : "Declined";
            return penaltyString;
        }
    }
}

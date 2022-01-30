using PlayByPlayParserConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent
{
    internal class SackEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Sack";
        public string? SackedPlayer { get; set; }
        public string? SackingPlayer { get; set; }
        public int SackYardage { get; set; }
        public override string ToString()
        {
            string sackString = $"{PlayType} - Sacked: {SackedPlayer}, Sacked by: {SackingPlayer}, Yardage: {SackYardage} ";
            return sackString;
        }
    }
}

using PlayByPlayParserConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Spike
{
    internal class SpikeEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Spike";
        public string? Passer { get; set; }
        public override string ToString()
        {
            string spikeString = $"{PlayType} - Passer: {Passer}";
            return spikeString;
        }
        public bool isScoringPlay()
        {
            return false;
        }
    }
}

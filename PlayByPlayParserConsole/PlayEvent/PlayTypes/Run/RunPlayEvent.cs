using PlayByPlayParserConsole.Models;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.Pass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent
{
    internal class RunPlayEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Run";
        public int RushingYards { get; set; }
        public string? Carrier { get; set; }
        public string[]? Tacklers { get; set; }
        public RunType? RunType { get; set; }

        public override string ToString()
        {
            string runString = $"{PlayType} - Type: {RunType}, Carrier: {Carrier}, Yards: {RushingYards}";
            return runString;
        }

    }
}

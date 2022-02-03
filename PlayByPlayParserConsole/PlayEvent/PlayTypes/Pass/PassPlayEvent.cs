using PlayByPlayParserConsole.Models;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.Pass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent
{
    internal class PassPlayEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Pass";
        public int PassingYards { get; set; }
        public string? Passer { get; set; }
        public string? Target { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsIntercepted { get; set; }
        public bool IsDefended { get; set; }
        public string? Interceptor { get; set; }
        public string? Defender { get; set; }
        public string[]? Tacklers { get; set; }
        public PassType? PassType { get; set; }
        public bool IsTouchdown { get; set; }
        public override string ToString()
        {
            string passString = $"{PlayType} - Type: {PassType}, Passer: {Passer}, Target: {Target}";

            // add events during play
            if (IsCompleted)
            {
                passString += $", COMPLETED for {PassingYards} yards";
            }
            else if (IsIntercepted)
            {
                passString += $", INTERCEPTED BY {Interceptor}";
            }
            else if (IsDefended)
            {
                passString += $", DEFENDED BY {Defender}";
            }
            else
            {
                passString += $", INCOMPLETE";
            }
            
            // add potential concluding events
            if (IsTouchdown)
            {
                passString += $", TOUCHDOWN";
            }
            
            return passString;
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

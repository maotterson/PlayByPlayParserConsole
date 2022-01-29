using PlayByPlayParserConsole.Models;
using PlayByPlayParserConsole.PlayEvent;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.Pass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole
{
    internal static class PlayEventFactory
    {
        public static IPlayEvent? ExtractPlayEvent(string summary)
        {
            IPlayEvent? playEvent = null;

            // Kickoff
            if (summary.Contains("kicks off"))
            {
                playEvent = new KickoffEvent();
            }
            else if (summary.Contains("pass"))
            {
                playEvent = PassPlayEventFactory.Create(summary);
            }
            else if (summary.Contains("guard") || summary.Contains("end")||summary.Contains("up the middle")||summary.Contains("left tackle")||summary.Contains("right tackle"))
            {
                playEvent = RunPlayEventFactory.Create(summary);
            }

            return playEvent;
        }
    }
}

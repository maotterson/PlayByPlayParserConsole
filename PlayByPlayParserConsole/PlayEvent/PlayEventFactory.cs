using PlayByPlayParserConsole.Models;
using PlayByPlayParserConsole.PlayEvent;
using PlayByPlayParserConsole.PlayEvent.Helpers;
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
            else if (SummaryDataExtractor.RunTypeRegexDictionary.Values.Any(summary.Contains))
            {
                playEvent = RunPlayEventFactory.Create(summary);
            }

            return playEvent;
        }
    }
}

using PlayByPlayParserConsole.Models;
using PlayByPlayParserConsole.PlayEvent;
using PlayByPlayParserConsole.PlayEvent.Helpers;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.Kickoff;
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
        public static Dictionary<string, Func<string, IPlayEvent>> PlayExtractorDictionary = new Dictionary<string, Func<string, IPlayEvent>>
        {
            { "kicks off", summary => KickoffEventFactory.Create(summary) },
            { "pass", summary => PassPlayEventFactory.Create(summary) }
        };

        public static IPlayEvent? ExtractPlayEvent(string summary)
        {
            IPlayEvent? playEvent = null;

            foreach(string keyPhrase in PlayExtractorDictionary.Keys)
            {
                if (summary.Contains(keyPhrase))
                {
                    playEvent = PlayExtractorDictionary[keyPhrase](summary);
                    return playEvent;
                }
            }
            if (SummaryDataExtractor.RunTypeRegexDictionary.Values.Any(summary.Contains))
            {
                playEvent = RunPlayEventFactory.Create(summary);
            }

            return playEvent;
        }
    }
}

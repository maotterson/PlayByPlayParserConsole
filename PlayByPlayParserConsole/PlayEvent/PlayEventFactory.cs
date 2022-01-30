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
            { "kicks off", x => KickoffEventFactory.Create(x) },
            { "pass", x => PassPlayEventFactory.Create(x) },
            { "up the middle" , x => RunPlayEventFactory.Create(x) },
            { "right end" , x => RunPlayEventFactory.Create(x) },
            { "left end" , x => RunPlayEventFactory.Create(x) },
            { "right tackle" , x => RunPlayEventFactory.Create(x) },
            { "left tackle" , x => RunPlayEventFactory.Create(x) },
            { "right guard" , x => RunPlayEventFactory.Create(x) },
            { "left guard" , x => RunPlayEventFactory.Create(x) }
        };

        public static IPlayEvent? ExtractPlayEvent(string summary)
        {
            IPlayEvent? playEvent = null;

            // check for the type of play based on keyword phrases
            foreach(string keyPhrase in PlayExtractorDictionary.Keys)
            {
                if (summary.Contains(keyPhrase))
                {
                    playEvent = PlayExtractorDictionary[keyPhrase](summary);
                    return playEvent;
                }
            }

            return playEvent;
        }
    }
}

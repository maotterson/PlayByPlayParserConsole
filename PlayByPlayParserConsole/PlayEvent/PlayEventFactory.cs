using PlayByPlayParserConsole.Models;
using PlayByPlayParserConsole.PlayEvent;
using PlayByPlayParserConsole.PlayEvent.Helpers;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.ExtraPoint;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.Kickoff;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.Pass;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.Penalty;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.Spike;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.TwoPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole
{
    internal static class PlayEventFactory
    {
        public static Dictionary<string, Func<string, IPlayEvent>> PlayKeywordDictionary = new Dictionary<string, Func<string, IPlayEvent>>
        {
            { "kicks off", x => KickoffEventFactory.Create(x) },
            { "pass", x => PassPlayEventFactory.Create(x) },
            { "up the middle" , x => RunPlayEventFactory.Create(x) },
            { "right end" , x => RunPlayEventFactory.Create(x) },
            { "left end" , x => RunPlayEventFactory.Create(x) },
            { "right tackle" , x => RunPlayEventFactory.Create(x) },
            { "left tackle" , x => RunPlayEventFactory.Create(x) },
            { "right guard" , x => RunPlayEventFactory.Create(x) },
            { "left guard" , x => RunPlayEventFactory.Create(x) },
            { "Penalty", x => PenaltyEventFactory.Create(x) },
            { "kicks extra point", x => ExtraPointFactory.Create(x) },
            { "sacked", x => SackFactory.Create(x) },
            // todo: create event/factory for remaining plays
            //{ "field goal", x => FieldGoalFactory.Create(x) },
            //{ "kneels", x => KneelFactory.Create(x) },
            //{ "punts", x => PuntFactory.Create(x) },
            { "Two Point Attempt:", x => TwoPointFactory.Create(x) },
            { "spiked the ball", x => SpikeFactory.Create(x) }
        };

        public static IPlayEvent? ExtractPlayEvent(string summary)
        {
            IPlayEvent? playEvent = null;

            // check for the type of play based on keyword phrases
            foreach(string keyPhrase in PlayKeywordDictionary.Keys)
            {
                if (summary.Contains(keyPhrase))
                {
                    playEvent = PlayKeywordDictionary[keyPhrase](summary);
                    return playEvent;
                }
            }

            return playEvent;
        }
    }
}

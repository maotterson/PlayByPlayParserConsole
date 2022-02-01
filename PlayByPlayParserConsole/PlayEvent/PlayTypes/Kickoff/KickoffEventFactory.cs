using PlayByPlayParserConsole.PlayEvent.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Kickoff
{
    internal static class KickoffEventFactory
    {
        public static KickoffEvent? Create(string summary)
        {
            KickoffEvent? playEvent = null;

            playEvent = new KickoffEvent
            {
                isReturned = SummaryDataExtractor.extractIsReturned(summary),
                Kicker = SummaryDataExtractor.extractKicker(summary),
                IsTouchdown = SummaryDataExtractor.extractIsTouchdown(summary),
                KickYards = SummaryDataExtractor.extractKickYards(summary),
                Returner = SummaryDataExtractor.extractReturner(summary),
                ReturnYards = SummaryDataExtractor.extractReturnYards(summary)
            };

            return playEvent;
        }
    }
}

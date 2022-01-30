using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using PlayByPlayParserConsole.PlayEvent.Helpers;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Pass
{
    internal static class RunPlayEventFactory
    {

        public static RunPlayEvent? Create(string summary)
        {
            RunPlayEvent? playEvent = null;

            RunType? runType = SummaryDataExtractor.extractRunType(summary);

            playEvent = new RunPlayEvent
            {
                Carrier = SummaryDataExtractor.extractCarrier(summary, runType),
                RunType = runType,
                IsTouchdown = SummaryDataExtractor.extractIsTouchdown(summary),
                RushingYards = SummaryDataExtractor.extractRushingYards(summary),
                Tacklers = SummaryDataExtractor.extractTacklers(summary)
            };

            return playEvent;
        }

    }
}

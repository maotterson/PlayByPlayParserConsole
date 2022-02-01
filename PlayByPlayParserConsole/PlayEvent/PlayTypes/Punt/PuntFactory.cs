using PlayByPlayParserConsole.PlayEvent.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Punt
{
    internal static class PuntFactory
    {
        public static PuntEvent Create(string summary)
        {
            PuntEvent? playEvent = null;

            playEvent = new PuntEvent
            {
                //todo
                IsTouchdown = SummaryDataExtractor.extractIsTouchdown(summary),
                IsBlocked = SummaryDataExtractor.extractIsBlocked(summary),
                IsReturned = SummaryDataExtractor.extractIsReturned(summary),
                PuntBlocker = SummaryDataExtractor.extractPuntBlocker(summary),
                Punter = SummaryDataExtractor.extractPunter(summary),
                PuntReturner = SummaryDataExtractor.extractReturner(summary),
                PuntYards = SummaryDataExtractor.extractPuntYards(summary),
                ReturnYards = SummaryDataExtractor.extractReturnYards(summary)
                
            };

            return playEvent;
        }
    }
}

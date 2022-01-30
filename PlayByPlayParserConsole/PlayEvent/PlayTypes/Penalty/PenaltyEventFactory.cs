using PlayByPlayParserConsole.PlayEvent.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Penalty
{
    internal static class PenaltyEventFactory
    {
        public static PenaltyEvent Create(string summary)
        {
            PenaltyEvent? playEvent = null;

            string penaltyType = SummaryDataExtractor.extractPenaltyType(summary);

            playEvent = new PenaltyEvent
            {
                isAccepted = SummaryDataExtractor.extractIsPenaltyAccepted(summary),
                PenaltyType = penaltyType,
                PenaltyYards = SummaryDataExtractor.extractPenaltyYards(summary, penaltyType),
                Player = SummaryDataExtractor.extractPenalizedPlayer(summary)
            };

            return playEvent;
        }
    }
}

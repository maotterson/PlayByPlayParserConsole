using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using PlayByPlayParserConsole.PlayEvent.Helpers;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Pass
{
    internal static class PassPlayEventFactory
    {
        public static PassPlayEvent? Create(string summary)
        {
            PassPlayEvent? playEvent = null;

            bool isCompleted = SummaryDataExtractor.isCompleted(summary);
            bool isIntercepted = SummaryDataExtractor.isIntercepted(summary);
            bool isDefended = SummaryDataExtractor.extractIsDefended(summary);
            bool isPenalty = SummaryDataExtractor.extractIsPenalty(summary);

            playEvent = new PassPlayEvent
            {
                IsCompleted = isCompleted,
                Passer = SummaryDataExtractor.extractPasser(summary),
                Target = SummaryDataExtractor.extractTarget(summary,  isIntercepted, isCompleted, isDefended, isPenalty),
                PassingYards = SummaryDataExtractor.extractPassYards(summary),
                IsIntercepted = isIntercepted,
                IsDefended = isDefended,
                IsPenalty = isPenalty,
                Defender = SummaryDataExtractor.extractDefender(summary, isDefended),
                IsTouchdown = SummaryDataExtractor.extractIsTouchdown(summary),
                Interceptor = isIntercepted ? SummaryDataExtractor.extractInterceptor(summary) : null,
                PassType = SummaryDataExtractor.extractPassType(summary),
                Tacklers = SummaryDataExtractor.extractTacklers(summary)
            };

            return playEvent;
        }

    }
}

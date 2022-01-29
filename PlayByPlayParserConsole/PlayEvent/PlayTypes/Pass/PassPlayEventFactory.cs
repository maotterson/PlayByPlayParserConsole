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

            playEvent = new PassPlayEvent
            {
                IsCompleted = SummaryDataExtractor.isCompleted(summary),
                Passer = SummaryDataExtractor.extractPasser(summary),
                Target = SummaryDataExtractor.extractTarget(summary, SummaryDataExtractor.isCompleted(summary)),
                PassingYards = SummaryDataExtractor.extractPassYards(summary),
                IsIntercepted = SummaryDataExtractor.isIntercepted(summary),
                Interceptor = SummaryDataExtractor.isIntercepted(summary) ? SummaryDataExtractor.extractInterceptor(summary) : null,
                PassType = SummaryDataExtractor.extractPassType(summary),
                Tacklers = SummaryDataExtractor.extractTacklers(summary)
            };

            return playEvent;
        }

    }
}

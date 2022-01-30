using PlayByPlayParserConsole.PlayEvent.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Extra_Point
{
    internal class ExtraPointFactory
    {
        public static ExtraPointEvent? Create(string summary)
        {
            ExtraPointEvent? playEvent = null;

            playEvent = new ExtraPointEvent
            {
                Kicker = SummaryDataExtractor.extractKicker(summary),
                isSuccessful = SummaryDataExtractor.extractExtraPointSuccess(summary)
            };

            return playEvent;
        }
    }
}

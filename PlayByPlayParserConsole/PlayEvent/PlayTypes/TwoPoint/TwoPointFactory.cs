using PlayByPlayParserConsole.PlayEvent.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.TwoPoint
{
    internal class TwoPointFactory
    {
        public static TwoPointEvent? Create(string summary)
        {
            TwoPointEvent? playEvent = null;

            playEvent = new TwoPointEvent
            {
                IsSuccessful = SummaryDataExtractor.extractIsSuccessfulTwoPoint(summary)
            };

            return playEvent;
        }
    }
}

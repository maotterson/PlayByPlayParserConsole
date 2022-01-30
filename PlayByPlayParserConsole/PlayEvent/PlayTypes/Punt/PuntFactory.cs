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
                IsTouchdown = SummaryDataExtractor.extractIsTouchdown(summary)
            };

            return playEvent;
        }
    }
}

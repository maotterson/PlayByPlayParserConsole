using PlayByPlayParserConsole.PlayEvent.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.ExtraPoint
{
    internal class SackFactory
    {
        public static SackEvent? Create(string summary)
        {
            SackEvent? playEvent = null;

            playEvent = new SackEvent
            {
                SackedPlayer = SummaryDataExtractor.extractSackedPlayer(summary),
                SackingPlayer = SummaryDataExtractor.extractSackingPlayer(summary),
                SackYardage = SummaryDataExtractor.extractSackYardage(summary)
            };

            return playEvent;
        }
    }
}

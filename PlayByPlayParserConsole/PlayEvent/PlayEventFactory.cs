using PlayByPlayParserConsole.Models;
using PlayByPlayParserConsole.PlayEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole
{
    internal static class PlayEventFactory
    {
        public static IPlayEvent? ExtractPlayEvent(string summary)
        {
            IPlayEvent? playEvent = null;

            // Kickoff
            if(summary.Contains("kicks off"))
            {
                playEvent = new KickPlayEvent();
            }

            return playEvent;
        }
    }
}

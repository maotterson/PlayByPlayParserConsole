using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Kneel
{
    internal static class KneelFactory
    {
        public static KneelEvent? Create(string summary)
        {
            KneelEvent? playEvent = null;

            playEvent = new KneelEvent
            {
                //todo
            };

            return playEvent;
        }
    }
}

using PlayByPlayParserConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Kneel
{
    internal class KneelEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Kneel";

        // todo
        public override string ToString()
        {
            string kneelString = $"{PlayType} - ";
            // todo
            return kneelString;
        }

        public bool isScoringPlay()
        {
            return false;
        }
    }
}

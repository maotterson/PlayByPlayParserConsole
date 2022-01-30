using PlayByPlayParserConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Punt
{
    internal class PuntEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Punt";

        public bool IsTouchdown { get; set; }

        // todo
        public override string ToString()
        {
            string puntString = $"{PlayType} - ";
            // todo
            return puntString;
        }

        public bool isScoringPlay()
        {
            if (IsTouchdown)
            {
                return true;
            }
            return false;
        }
    }
}

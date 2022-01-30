using PlayByPlayParserConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.TwoPoint
{
    internal class TwoPointEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "TwoPoint";
        public bool IsSuccessful { get; set; }
        
        // todo: additional two point data

        public bool isScoringPlay()
        {
            return IsSuccessful;
        }
    }
}

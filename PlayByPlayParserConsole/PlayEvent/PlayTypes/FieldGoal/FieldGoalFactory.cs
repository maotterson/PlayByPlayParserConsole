using PlayByPlayParserConsole.PlayEvent.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.FieldGoal
{
    internal static class FieldGoalFactory
    {
        public static FieldGoalEvent? Create(string summary)
        {
            FieldGoalEvent? playEvent = null;

            playEvent = new FieldGoalEvent
            {
                IsTouchdown = SummaryDataExtractor.extractIsTouchdown(summary),
                IsSuccessful = SummaryDataExtractor.extractIsSuccessfulFieldGoal(summary)

                //todo
            };

            return playEvent;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.Helpers
{
    internal static partial class SummaryDataExtractor
    {
        public static bool extractIsSuccessfulFieldGoal(string summary)
        {
            return summary.Contains("field goal good");
        }
    }
}

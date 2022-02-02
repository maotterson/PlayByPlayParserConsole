using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.Helpers
{
    internal static partial class SummaryDataExtractor
    {
        public static bool extractIsSuccessfulFieldGoal(string summary)
        {
            return summary.Contains("field goal good");
        }
        public static int extractFieldGoalYards(string summary)
        {
            string regex = "(.[0-9]?)(?= yard field goal)";
            int.TryParse(Regex.Match(summary, regex).Value, out int yards);
            return yards;
        }
        public static string extractFieldGoalKicker(string summary, int yards)
        {
            string regex = $"^.*?(?= {yards} )";
            return Regex.Match(summary, regex).Value;
        }
    }
}

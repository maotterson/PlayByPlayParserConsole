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
        public static bool extractIsPenaltyAccepted(string summary)
        {
            return summary.Contains("Penalty");
        }
        public static string extractPenaltyType(string summary)
        {
            string regex = "(?<=: )(.*?)(?= [0-9])";
            return Regex.Match(summary, regex).Value;
        }
        public static int extractPenaltyYards(string summary, string penaltyType)
        {
            string regex = $"(?<={penaltyType} )(.*?)(?= yards)";
            int.TryParse(Regex.Match(summary, regex).Value, out int yards);
            return yards;
        }
        public static string extractPenalizedPlayer(string summary)
        {
            string regex = "(?<=Penalty on )(.*?)(?=:)";
            return Regex.Match(summary, regex).Value;
        }
    }
}

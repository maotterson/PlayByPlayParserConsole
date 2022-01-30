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
        public static string extractSackedPlayer(string summary)
        {
            string regex = "(.*?)(?= sacked by)";
            return Regex.Match(summary, regex).Value;
        }
        public static string extractSackingPlayer(string summary)
        {
            string regex = "(?<=sacked by )(.*?)(?= for)";
            return Regex.Match(summary, regex).Value;
        }
        public static int extractSackYardage(string summary)
        {
            string regex = "(?<=for )(.*?)(?= yards)";
            int.TryParse(Regex.Match(summary, regex).Value, out int yards);
            return yards;
        }
    }
}

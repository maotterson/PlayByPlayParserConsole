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
        
        public static bool extractIsBlocked(string summary)
        {
            return summary.Contains("blocked");
        }
        public static string extractPuntBlocker(string summary)
        {
            string regex = "(?<=blocked by )(.*)";
            return Regex.Match(summary, regex).Value;
        }
        public static string extractPunter(string summary)
        {
            string regex = "^.*?(?= punts)";
            return Regex.Match(summary, regex).Value;
        }
        public static int extractPuntYards(string summary)
        {
            string regex = "(?<=punts )(.*?)(?= yards)";
            int.TryParse(Regex.Match(summary,regex).Value, out int yards);
            return yards;
        }
    }
}

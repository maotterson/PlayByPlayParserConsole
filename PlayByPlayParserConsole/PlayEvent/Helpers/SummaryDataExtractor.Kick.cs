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
        
        public static string extractReturner(string summary)
        {
            string regex = "(?<=returned by )(.*?)(?= for)";
            return Regex.Match(summary, regex).Value;
        }
        public static int extractKickYards(string summary)
        {
            string regex = "(?<=kicks off )(.*?)(?= yards)";
            int.TryParse(Regex.Match(summary,regex).Value, out int yards);
            return yards;
        }
        public static int extractReturnYards(string summary)
        {
            string regex = "(?<=for )(.*?)(?= yards)";
            int.TryParse(Regex.Match(summary, regex).Value, out int yards);
            return yards;
        }
    }
}

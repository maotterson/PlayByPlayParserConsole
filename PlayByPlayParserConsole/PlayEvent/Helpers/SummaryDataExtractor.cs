using PlayByPlayParserConsole.PlayEvent.PlayTypes.Pass;
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
        // helper extractor methods used by multiple event types
        public static string[] extractTacklers(string summary)
        {
            string regex = "(?<=tackle by )(.*)(?=[)])";

            return new[] { Regex.Match(summary, regex).Value };
        }
        public static string extractKicker(string summary)
        {
            string regex = "^.*?(?= kicks )";
            return Regex.Match(summary, regex).Value;
        }

        public static bool extractIsTouchdown(string summary)
        {
            return summary.Contains(" touchdown");
        }

        public static bool extractIsReturned(string summary)
        {
            bool isReturned = summary.Contains("returned by");
            return isReturned;
        }

    }
}

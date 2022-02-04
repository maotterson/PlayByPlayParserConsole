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
        public static List<string> extractTacklers(string summary)
        {
            List<string> tacklers = new List<string>();
            string regexIsSharedTackle = "(?=[(]tackle by )(.*)(?=[)])";
            string tackleSummary = Regex.Match(summary, regexIsSharedTackle).Value;

            if (tackleSummary.Contains("and"))
            {
                string regexFirst = "(?<=tackle by )(.*)(?= and)";
                string regexSecond = "(?<=and )(.*)(?=[)])";
                tacklers.Add(Regex.Match(summary, regexFirst).Value);
                tacklers.Add(Regex.Match(summary, regexSecond).Value);
            }
            else
            {
                string regex = "(?<=tackle by )(.*)(?=[)])";
                tacklers.Add(Regex.Match(summary, regex).Value);
            }

            return tacklers;
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

        public static bool extractIsPenalty(string summary)
        {
            return summary.Contains("Penalty");
        }

    }
}

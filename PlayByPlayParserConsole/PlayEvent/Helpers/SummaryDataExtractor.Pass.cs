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
        public static IDictionary<PassType?, string> PassTypeRegexDictionary = new Dictionary<PassType?, string>
        {
            { PassType.ShortRight, "short right" },
            { PassType.ShortMiddle, "short middle" },
            { PassType.ShortLeft, "short left" },
            { PassType.DeepRight, "deep right" },
            { PassType.DeepMiddle, "deep middle" },
            { PassType.DeepLeft, "deep left" },
        };
        public static PassType? extractPassType(string summary)
        {
            foreach (string passDescription in PassTypeRegexDictionary.Values)
            {
                if (summary.Contains(passDescription))
                {
                    return PassTypeRegexDictionary.FirstOrDefault(x => x.Value == passDescription).Key;
                }
            }

            return null;
        }

        public static bool isCompleted(string summary)
        {
            if (summary.Contains("pass complete"))
            {
                return true;
            }
            return false;
        }
        public static string extractPasser(string summary)
        {
            string regex = "^.*?(?= pass)";
            return Regex.Match(summary, regex).Value;
        }

        public static string extractTarget(string summary, bool isCompleted)
        {
            string regexComplete = "(?<=to )(.*?)(?= for)";
            string regexIncomplete = "(?<=intended for )(.*)";

            if (isCompleted)
            {
                return Regex.Match(summary, regexComplete).Value;
            }

            return Regex.Match(summary, regexIncomplete).Value;
        }

        public static int extractPassYards(string summary)
        {
            string regex = "(?<=for )(.*?)(?= yards)";

            int.TryParse(Regex.Match(summary, regex).Value, out int yards);

            return yards;
        }
        public static bool isIntercepted(string summary)
        {
            return summary.Contains("intercepted by");
        }
        public static string extractInterceptor(string summary)
        {
            string regex = "(?<=intercepted by )(.*?)(?= at)";

            return Regex.Match(summary, regex).Value;

        }
    }
}

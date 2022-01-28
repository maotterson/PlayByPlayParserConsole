using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PlayByPlayParserConsole.PlayEvent.PlayTypes.Pass
{
    internal static class PassPlayEventFactory
    {

        public static PassPlayEvent? Create(string summary)
        {
            PassPlayEvent? playEvent = null;

            playEvent = new PassPlayEvent
            {
                IsCompleted = isCompleted(summary),
                Passer = extractPasser(summary),
                Target = extractTarget(summary, isCompleted(summary)),
                PassingYards = extractPassYards(summary),
                IsIntercepted = isIntercepted(summary),
                Interceptor = isIntercepted(summary) ? extractInterceptor(summary) : null,
                PassType = extractPassType(summary)
            };

            return playEvent;
        }

        // helper methods
        private static bool isCompleted(string summary)
        {
            if (summary.Contains("pass complete"))
            {
                return true;
            }
            return false;
        }
        private static string extractPasser(string summary)
        {
            string regex = "^.*?(?= pass)";
            return Regex.Match(summary, regex).Value;
        }

        private static string extractTarget(string summary, bool isCompleted)
        {
            string regexComplete = "(?<=to )(.*?)(?= for)";
            string regexIncomplete = "(?<=intended for )(.*)";

            if (isCompleted)
            {
                return Regex.Match(summary, regexComplete).Value;
            }

            return Regex.Match(summary, regexIncomplete).Value;
        }

        private static int extractPassYards(string summary)
        {
            string regex = "(?<=for )(.*?)(?= yards)";

            int.TryParse(Regex.Match(summary, regex).Value, out int yards);

            return yards;
        }
        private static bool isIntercepted(string summary)
        {
            return summary.Contains("intercepted by");
        }
        private static string extractInterceptor(string summary)
        {
            string regex = "(?<=intercepted by )(.*?)(?= at)";

            return Regex.Match(summary, regex).Value;

        }
        private static PassType? extractPassType(string summary)
        {
            PassType? passType = null;

            if(summary.Contains("short right"))
            {
                passType = PassType.ShortRight;
            }
            else if(summary.Contains("short left"))
            {
                passType = PassType.ShortLeft;
            }
            else if (summary.Contains("short middle"))
            {
                passType = PassType.ShortMiddle;
            }
            else if (summary.Contains("deep right"))
            {
                passType = PassType.DeepRight;
            }
            else if (summary.Contains("deep left"))
            {
                passType = PassType.DeepLeft;
            }
            else if (summary.Contains("deep middle"))
            {
                passType = PassType.DeepMiddle;
            }

            return passType;
        }
    }
}

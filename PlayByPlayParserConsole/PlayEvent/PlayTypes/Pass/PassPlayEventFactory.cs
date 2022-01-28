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
                Passer = extractPasser(summary)
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
    }
}

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
        public static string extractSpikePasser(string summary)
        {
            string regex = "^.*?(?= spiked)";
            return Regex.Match(summary, regex).Value;
        }
    }
}

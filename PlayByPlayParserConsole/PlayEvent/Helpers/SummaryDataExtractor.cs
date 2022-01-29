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
        public static string[] extractTacklers(string summary)
        {
            string regex = "(?<=tackle by )(.*)(?=[)])";

            return new[] { Regex.Match(summary, regex).Value };
        }
        
    }
}

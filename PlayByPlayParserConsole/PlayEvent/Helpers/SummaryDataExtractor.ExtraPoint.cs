using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent.Helpers
{
    internal static partial class SummaryDataExtractor
    {
        public static bool extractExtraPointSuccess(string summary)
        {
            return summary.Contains("extra point good");
        }
    }
}

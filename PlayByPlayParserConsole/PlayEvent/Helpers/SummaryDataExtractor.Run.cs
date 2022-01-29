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
        public static IDictionary<RunType?, string> RunTypeRegexDictionary = new Dictionary<RunType?, string>
        {
            { RunType.LeftEnd, "left end" },
            { RunType.LeftTackle, "left tackle" },
            { RunType.LeftGuard, "left guard" },
            { RunType.UpMiddle, "up the middle" },
            { RunType.RightGuard, "right guard" },
            { RunType.RightTackle, "right tackle" },
            { RunType.RightEnd, "right end" }
        };

        public static string extractCarrier(string summary, RunType? runType)
        {
            string regex = $"^.*?(?= {RunTypeRegexDictionary[runType]})";
            string carrier = Regex.Match(summary, regex).Value; 
            return carrier;
        }

        public static RunType? extractRunType(string summary)
        {
            foreach(string runDescription in RunTypeRegexDictionary.Values)
            {
                if (summary.Contains(runDescription))
                {
                    return RunTypeRegexDictionary.FirstOrDefault(x => x.Value == runDescription).Key;
                }
            }
            return null;
        }

        public static int extractRushingYards(string summary)
        {
            string regex = $"(?<=for )(.*?)(?= yards)";
            int.TryParse(Regex.Match(summary, regex).Value, out int rushingYards);
            return rushingYards;
        }


    }
}

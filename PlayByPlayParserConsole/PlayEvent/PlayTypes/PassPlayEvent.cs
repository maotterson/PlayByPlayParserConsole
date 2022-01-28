using PlayByPlayParserConsole.Models;
using PlayByPlayParserConsole.PlayEvent.PlayTypes.Pass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent
{
    internal class PassPlayEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Pass";
        public int PassingYards { get; set; }
        public string Passer { get; set; }
        public string Target { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsIntercepted { get; set; }
        public string? Interceptor { get; set; }
        public string[] Tacklers { get; set; }
        public PassType? PassType { get; set; }
    }
}

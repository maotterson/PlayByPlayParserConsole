﻿using PlayByPlayParserConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent
{
    internal class RunPlayEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "Run";
    }
}
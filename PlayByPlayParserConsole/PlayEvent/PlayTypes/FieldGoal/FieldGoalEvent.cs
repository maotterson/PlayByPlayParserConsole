﻿using PlayByPlayParserConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayByPlayParserConsole.PlayEvent
{
    internal class FieldGoalEvent : IPlayEvent
    {
        public string PlayType { get; set; } = "FieldGoal";
        public bool IsTouchdown { get; set; }
        public bool IsSuccessful { get; set; }

        //todo
        public override string ToString()
        {
            string fgString = $"{PlayType} - ";
            // todo
            return fgString;
        }

        public bool isScoringPlay()
        {
            if (IsSuccessful || IsTouchdown)
            {
                return true;
            }
            return false;
        }
    }
}

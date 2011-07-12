﻿using System;

namespace Coypu
{
    ///<summary>
    /// A possible state for the current page
    ///</summary>
    public class State
    {
        public Func<bool> Condition { get; set; }

        public bool ConditionMet { get; private set; }

        public bool CheckCondition()
        {
            return ConditionMet = Condition();
        }
    }
}
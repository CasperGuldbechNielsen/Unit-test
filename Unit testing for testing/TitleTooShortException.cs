﻿using System;

namespace Unit_testing_for_testing
{
    public class TitleTooShortException : Exception
    {
        public TitleTooShortException(string message) : base(message)
        {
            
        }
    }
}
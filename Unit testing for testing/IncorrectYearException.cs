using System;

namespace Unit_testing_for_testing
{
    public class IncorrectYearException : Exception
    {
        public IncorrectYearException(string message) : base(message)
        {
            
        }
    }
}
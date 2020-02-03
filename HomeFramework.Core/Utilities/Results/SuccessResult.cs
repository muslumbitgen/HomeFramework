using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {
        }

        public SuccessResult(string message) : base(message)
        {
        }

        public SuccessResult(bool success, string message) : base(success, message)
        {
        }
    }
}

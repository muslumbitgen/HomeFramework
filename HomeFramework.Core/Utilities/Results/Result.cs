using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFramework.Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {

        }
        public Result(bool success)
        {
            Success = success;
        }

        public Result(string message)
        {
            Message = message;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}

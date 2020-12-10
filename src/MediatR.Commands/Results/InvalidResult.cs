using System;
using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Results
{
    [Obsolete("Type is deprecated. Use InvalidInputResult instead.")]
    public class InvalidResult : FailedResult
    {
        public InvalidResult(string message)
        {
            Body = new MessageBody(message);
        }
    }
}

using System;

namespace MediatR.Commands.BodyTypes
{
    public class ExceptionBody : IResultBody
    {
        public ExceptionBody(Exception e)
        {
            Exception = e;
        }

        public Exception Exception { get; }
    }
}

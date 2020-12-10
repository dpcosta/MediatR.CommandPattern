using System;
using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Results
{
    public class ExceptionResult : FailedResult
    {
        public ExceptionResult(Exception e)
        {
            Body = new ExceptionBody(e);
        }
    }
}

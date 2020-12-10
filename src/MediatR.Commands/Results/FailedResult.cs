using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Results
{
    public class FailedResult : IResult
    {
        public bool Succeeded => false;

        public IResultBody Body { get; protected set; }
    }
}

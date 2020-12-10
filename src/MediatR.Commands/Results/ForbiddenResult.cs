using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Results
{
    public class ForbiddenResult : FailedResult
    {
        public ForbiddenResult()
        {
            Body = new EmptyBody();
        }
    }
}

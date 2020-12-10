using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Results
{
    public class UnauthorizedResult : FailedResult
    {
        public UnauthorizedResult()
        {
            Body = new EmptyBody();
        }
    }
}

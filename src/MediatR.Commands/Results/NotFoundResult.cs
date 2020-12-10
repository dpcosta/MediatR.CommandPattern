using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Results
{
    public class NotFoundResult : FailedResult
    {
        public NotFoundResult()
        {
            Body = new EmptyBody();
        }
    }
}

using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Results
{
    public class ErrorResult : FailedResult
    {
        public ErrorResult(string errorMessage)
        {
            Body = new MessageBody(errorMessage);
        }
    }
}

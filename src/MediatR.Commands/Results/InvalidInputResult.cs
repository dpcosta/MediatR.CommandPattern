using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Results
{
    public class InvalidInputResult : FailedResult
    {
        public InvalidInputResult(string message)
        {
            Body = new MessageBody(message);
        }
    }
}

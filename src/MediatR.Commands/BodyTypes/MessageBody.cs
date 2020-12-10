namespace MediatR.Commands.BodyTypes
{
    public class MessageBody : IResultBody
    {
        public MessageBody(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}

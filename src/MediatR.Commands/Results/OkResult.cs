using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Results
{
    public class OkResult<T> : IResult
    {
        public OkResult(T obj)
        {
            Body = new ObjectBody<T>(obj);
        }

        public bool Succeeded => true;

        public IResultBody Body { get; }
    }
}

using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Results
{
    public interface IResult
    {
        bool Succeeded { get; }
        IResultBody Body { get; }
    }
}

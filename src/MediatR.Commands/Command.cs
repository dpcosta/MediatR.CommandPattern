using MediatR.Commands.Results;

namespace MediatR.Commands
{
    public abstract class Command : IRequest<IResult>
    {
    }
}

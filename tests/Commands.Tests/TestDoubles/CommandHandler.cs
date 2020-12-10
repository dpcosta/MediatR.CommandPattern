using System.Threading;
using System.Threading.Tasks;
using MediatR.Commands.Extensions;
using MediatR.Commands.Results;

namespace MediatR.Commands.Tests.TestDoubles
{
    internal class CommandHandler : IRequestHandler<ComandoQualquer, IResult>
    {
        public Task<IResult> Handle(ComandoQualquer request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new OkResult<string>("Comando funcionou!").AsResult());
        }
    }
}

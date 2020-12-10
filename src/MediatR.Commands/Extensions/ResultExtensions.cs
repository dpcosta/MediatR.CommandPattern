using MediatR.Commands.Results;

namespace MediatR.Commands.Extensions
{
    public static class ResultExtensions
    {
        public static IResult AsResult(this IResult result)
        {
            return result;
        }
    }
}

namespace MediatR.Commands.Results
{
    public class UpdatedResult<T> : OkResult<T>
    {
        public UpdatedResult(T obj) : base(obj)
        {
        }
    }
}

namespace MediatR.Commands.Results
{
    public class DeletedResult<T> : OkResult<T>
    {
        public DeletedResult(T obj) : base(obj)
        {
        }
    }
}

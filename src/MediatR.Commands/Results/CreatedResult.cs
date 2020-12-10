namespace MediatR.Commands.Results
{
    public class CreatedResult<T> : OkResult<T>
    {
        public CreatedResult(T obj) : base(obj)
        {
        }
    }
}

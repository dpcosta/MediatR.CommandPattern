namespace MediatR.Commands.BodyTypes
{
    public class ObjectBody<T> : IResultBody
    {
        public ObjectBody(T obj)
        {
            Response = obj;
        }
        public T Response { get; }
    }
}

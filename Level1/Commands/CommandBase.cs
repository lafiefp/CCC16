using System.IO;

namespace Level1
{
    public abstract class CommandBase<T> where T : ResponseBase, new()
    {
        public T Response { get; protected set; }

        public void InterpretResponse(Stream stream)
        {
            Response = new T();
            Response.Parse(stream);
        }
    }
}
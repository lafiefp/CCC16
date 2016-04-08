using System.IO;

namespace Level1
{
    public abstract class CommandBase
    {
        public abstract ResponseBase InterpretResponse(Stream stream);
    }
}
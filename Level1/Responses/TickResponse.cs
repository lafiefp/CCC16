using System.IO;
using System.Linq;

namespace Level1
{
    public class TickResponse : ResponseBase
    {
        public bool Success;
        public float Time;

        public override void Parse(Stream stream)
        {
            var lines = ReadLines(stream, 1);

            Time = float.Parse(lines.ElementAt(0));
            Success = lines.ElementAt(1).Trim() == "SUCCESS";
        }
    }
}
using System.IO;
using System.Linq;

namespace Level1
{
    public class ThrottleResponse : ResponseBase
    {
        public bool Processed;

        public override void Parse(Stream stream)
        {
            var lines = ReadLines(stream, 1);

            Processed = lines.ElementAt(0).Trim() == "OK";
            Valid = true;
        }


        public override string ToString()
        {
            return string.Format("ThrottleResponse (Processed: {0})", Processed);
        }
    }
}
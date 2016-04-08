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
            var lines = ReadLines(stream, 2);

            Time = float.Parse(lines.ElementAt(0));
            if (lines.Count > 1)
                Success = lines.ElementAt(1).Trim() == "SUCCESS";
            else
                Success = false;
        }

        public override string ToString()
        {
            return string.Format("Tickresponse (Success: {0}, Time: {1})", Success, Time);
        }
    }
}
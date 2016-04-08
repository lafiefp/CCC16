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

            float time;
            if (!float.TryParse(lines.ElementAt(0), out time))
            {
                Success = lines.ElementAt(0).Trim().Equals("SUCCESS");
                if (!Success)
                    throw new ParseException("Invalid response!", lines);
            }
            else
            {
                Time = time;
            }

            Valid = true;
        }

        public override string ToString()
        {
            return string.Format("Tickresponse (Success: {0}, Time: {1})", Success, Time);
        }
    }
}
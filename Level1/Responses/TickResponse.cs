using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Level1
{
    public class TickResponse : ResponseBase
    {
        public float Time;
        public bool Success;

        public override void Parse(Stream stream)
        {
            var lines = ReadLines(stream);

            // check number of lines
            if (lines.Count < 2)
                throw new Exception("too few response lines");

            Time = float.Parse(lines.ElementAt(0));
            Success = lines.ElementAt(1).Trim() == "SUCCESS";
        }
    }
}

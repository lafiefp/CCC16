using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Level1
{
    class TickResponse : ResponseBase
    {
        public float Time;
        public bool Success;

        override public void Parse(Stream stream)
        {
            var lines = ReadLines(stream, 1);

            Time = float.Parse(lines.ElementAt(0));
            Success = lines.ElementAt(1).Trim() == "SUCCESS";
        }
    }
}

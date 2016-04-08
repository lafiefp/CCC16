using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Level1
{
    class ThrottleResponse : ResponseBase
    {
        public bool Processed;

        public override void Parse(Stream stream)
        {
            var lines = ReadLines(stream);

            // check number of lines
            if (lines.Count < 1)
                throw new Exception("too few response lines");

            Processed = lines.ElementAt(0).Trim() == "OK";
            Valid = true;
            
        }
    }
}

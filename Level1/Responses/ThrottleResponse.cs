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

        override public void Parse(Stream stream)
        {
            var lines = ReadLines(stream, 1);

            Processed = lines.ElementAt(0).Trim() == "OK";
            Valid = true;
            
        }

        public override void Parse(Stream s)
        {
            throw new NotImplementedException();
        }
    }
}

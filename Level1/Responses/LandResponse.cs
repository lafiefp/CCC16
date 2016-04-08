using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1.Responses
{
    public class LandResponse : ResponseBase
    {
        public bool Landed;

        public override void Parse(Stream s)
        {
            var lines = ReadLines(stream, 1);

            Landed = lines.ElementAt(0).Trim() == "OK";
            Valid = true;
        }

        public override string ToString()
        {
            return string.Format("LandResponse: (Landed: {0})", Landed);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    public abstract class ResponseBase
    {
        public abstract void Parse(Stream s);
        public bool Valid { get; protected set; }

        protected static List<string> ReadLines(Stream stream)
        {
            if (stream == null || !stream.CanRead)
                throw Exception("invalid stream");

            var reader = new StreamReader(stream);

            var lines = new List<string>();

            while (!reader.EndOfStream)
            {
                lines.Add(reader.ReadLine());
            }
            return lines;
        }
    }
}

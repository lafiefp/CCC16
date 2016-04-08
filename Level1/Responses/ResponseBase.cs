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

        protected static List<string> ReadLines(Stream stream, int numberOfLines)
        {
            if (stream == null || !stream.CanRead)
                throw Exception("invalid stream");

            var reader = new StreamReader(stream);

            var lines = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var line = reader.ReadLine();
                if (line == null)
                    throw new Exception("end of stream reached with insufficient lines");

                lines.Add(line);
            }

            return lines;
        }
    }
}

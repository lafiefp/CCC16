using System;
using System.Collections.Generic;
using System.IO;

namespace Level1
{
    public abstract class ResponseBase
    {
        public bool Valid { get; protected set; }
        public abstract void Parse(Stream s);

        protected static List<string> ReadLines(Stream stream, int numberOfLines)
        {
            if (stream == null || !stream.CanRead)
                throw new Exception("invalid stream");

            var reader = new StreamReader(stream);

            var lines = new List<string>();

            for (var i = 0; i < numberOfLines; i++)
            {
                var line = reader.ReadLine();
                if (line == null)
                    throw new Exception("end of stream reached with insufficient lines");

                lines.Add(line);
                Console.WriteLine(DateTime.Now + " - " + line);
            }

            return lines;
        }
    }
}
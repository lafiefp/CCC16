using System;
using System.IO;
using System.Linq;

namespace Level1
{
    public class InitialResponse : ResponseBase
    {
        public int NumberOfDrones;
        public float Xmax;

        public float Xmin;
        public float Ymax;
        public float Ymin;

        public override void Parse(Stream stream)
        {
            var lines = ReadLines(stream, 2);

            var fieldParts = lines.ElementAt(0).Split(' ');

            Xmin = float.Parse(fieldParts[0]);
            Xmax = float.Parse(fieldParts[1]);
            Ymin = float.Parse(fieldParts[2]);
            Ymax = float.Parse(fieldParts[3]);

            NumberOfDrones = int.Parse(lines.ElementAt(1));

            Valid = true;
        }
        public override string ToString()
        {
            return string.Format("InitialResponse ( NumberOfDrones: {0}, Xmin: {1}, Xmax: {2}, Ymin: {3}, Ymax: {4})", NumberOfDrones, Xmin, Xmax, Ymin, Ymax);
        }
    }
}
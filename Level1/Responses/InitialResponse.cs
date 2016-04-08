using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Level1
{
    public class InitialResponse : ResponseBase
    {
        override public void parse(Stream stream)
        {
            var lines = ReadLines(stream);

            // check number of lines
            if (lines.Count < 3)
                throw Exception("too few response lines");

            var fieldParts = lines.ElementAt(0).Split(' ');

            if (fieldParts.Length < 4)
                throw Exception("too few parameters in first line");
            
            Xmin = float.Parse(fieldParts[0]);
            Xmax = float.Parse(fieldParts[1]);
            Ymin = float.Parse(fieldParts[2]);
            Ymax = float.Parse(fieldParts[3]);
            
            NumberOfDrones = int.Parse(lines.ElementAt(1));
            MinHeight = float.Parse(lines.ElementAt(2));

            Valid = true;
        }

        public float Xmin;
        public float Xmax;
        public float Ymin;
        public float Ymax;
        public int NumberOfDrones;
        public float MinHeight;
    }
}

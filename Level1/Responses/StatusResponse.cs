using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Level1
{
    class StatusResponse : ResponseBase
    {
        public Triple Position;
        public Triple Velocity;
        public Triple Thrust;

        override public void Parse(Stream stream)
        {
            var lines = ReadLines(stream);

            // check number of lines
            if (lines.Count < 1)
                throw new Exception("too few response lines");

            var stateParts = lines.ElementAt(0).Split(' ');

            if (stateParts.Length < 9)
                throw new Exception("too few parameters in first line");
            
            Position.X = float.Parse(stateParts[0]);
            Position.Y = float.Parse(stateParts[1]);
            Position.Z = float.Parse(stateParts[2]);
            Velocity.X = float.Parse(stateParts[3]);
            Velocity.Y = float.Parse(stateParts[4]);
            Velocity.Z = float.Parse(stateParts[5]);
            Thrust.X = float.Parse(stateParts[6]);
            Thrust.Y = float.Parse(stateParts[7]);
            Thrust.Z = float.Parse(stateParts[8]);

            Valid = true;
        }
    }
}

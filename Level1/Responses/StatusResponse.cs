using System;
using System.IO;
using System.Linq;

namespace Level1
{
    internal class StatusResponse : ResponseBase
    {
        public Triple Position;
        public Triple Thrust;
        public Triple Velocity;

        public override void Parse(Stream stream)
        {
            var lines = ReadLines(stream, 1);

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

        public override string ToString()
        {
            return string.Format("StatusResponse (Position: {0}, Velocity: {1}, Thrust: {2})", Position.ToString(), Velocity.ToString(), Thrust.ToString());
        }
    }
}
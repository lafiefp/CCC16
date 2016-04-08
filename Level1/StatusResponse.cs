using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1
{
    class StatusResponse : ResponseBase
    {
        public Triple Position;
        public Triple Velocity;
        public Triple Thrust;

        public StatusResponse(Triple position, Triple velocity, Triple thrust)
            : base(1, new int[]{ 9 })
        {
            Position = positions;
            Velocity = velocity;
            Thrust = thrust;
        }
    }
}

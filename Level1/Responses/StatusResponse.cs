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

        public StatusResponse(Stream stream)
        {
            // TODO: parse response
        }
    }
}

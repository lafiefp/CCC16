using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1.Commands
{
    class ThrottleCommand : CommandBase<ThrottleResponse>
    {
        private readonly float _throttle;
        private readonly int _id;

        public ThrottleCommand(int droneId, float throttle)
        {
            Debug.Assert(throttle >= 0 && throttle <= 1);
            _id = droneId;
            _throttle = throttle;
        }

        public override string ToString()
        {
            return $"THROTTLE {_id}\n{_throttle}\n";
        }
    }
}

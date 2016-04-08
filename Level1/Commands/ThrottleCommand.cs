using System.Diagnostics;

namespace Level1.Commands
{
    internal class ThrottleCommand : CommandBase<ThrottleResponse>
    {
        private readonly int _id;
        private readonly float _throttle;

        public ThrottleCommand(int droneId, float throttle)
        {
            Debug.Assert(throttle >= 0 && throttle <= 1);
            _id = droneId;
            _throttle = throttle;
        }

        public override string ToString()
        {
            return string.Format("THROTTLE {0}\n{1}\n", _id, _throttle); // $"THROTTLE {_id}\n{_throttle}\n";
        }
    }
}
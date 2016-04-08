using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    class Drone
    {
        public int Id { get; set; }
        public Triple Position { get; set; }
        public Triple Velocity { get; set; }
        public Triple ThrustDirection { get; set; }

        public float Height { get; }
    }
}

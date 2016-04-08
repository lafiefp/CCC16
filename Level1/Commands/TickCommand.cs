using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1.Commands
{
    class TickCommand : CommandBase<TickResponse>
    {
        public static int Tick { get; set; } = 1;

        public override string ToString()
        {
            return $"TICK {Tick}";
        }
    }
}

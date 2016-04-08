using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1.Commands
{
    class StatusCommand : CommandBase
    {
        public override string ToString()
        {
            return base.ToString();
        }

        public override ResponseBase InterpretResponse(Stream stream)
        {
            return new StatusResponse(stream);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1.Commands
{
    class StatusCommand : CommandBase<StatusResponse>
    {
        private int _id;

        public StatusCommand(int id)
        {
            _id = id;
        }

        public override string ToString()
        {
            return $"STATUS {_id}\n";
        }

        public override void InterpretResponse(Stream stream)
        {
            Response = new StatusResponse(stream);
        }
    }
}

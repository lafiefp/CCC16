using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Level1
{
    public class InitialResponse : ResponseBase
    {
        public InitialResponse(Stream networkStream)
        {
            // TODO: parse
        }

        public float xmin;
        public float xmax;
        public float ymin;
        public float ymax;
        private NetworkStream networkStream;
    }
}

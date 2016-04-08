using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Level1
{
    class ThrottleResponse : ResponseBase
    {

        public bool Processed;

        public ThrottleResponse(bool processed;)
            : base(1, new int[]{1})
        {
            this.Processed = processed;
        }

        public override void Parse(Stream s)
        {
            throw new NotImplementedException();
        }
    }
}

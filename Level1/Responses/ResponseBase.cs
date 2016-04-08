using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    public abstract class ResponseBase
    {
        public abstract void Parse(Stream s);
    }
}

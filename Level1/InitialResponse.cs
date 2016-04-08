using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1
{
    class InitialResponse : ResponseBase
    {
        public InitialResponse(float xmin, float xmax, float ymin, float ymax)
            : base(3, new int[]{ 4, 1, 1 })
        {
            this.xmin = xmin;
            this.xmax = xmax;
            this.ymin = ymin;
            this.ymax = ymax;
        }

        public float xmin;
        public float xmax;
        public float ymin;
        public float ymax;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1
{
    class TickResponse : ResponseBase
    {
        public enum SuccessState 
        {
            NoSuccess,
            Success
        }

        public float Time;
        public SuccessState State;

        public TickResponse()
            : base(2, new int[]{1, 1})
        {}
    }
}

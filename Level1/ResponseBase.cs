using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    abstract class ResponseBase
    {
        public int NumberOfLines
        {
            get { return mNumberOfLines; }
        }
        
        public int[] NumberOfParameters
        {
            get
            {
                return mNumberOfParameters;
            }
        }

        private int mNumberOfLines;
        private int[] mNumberOfParameters;

        protected ResponseBase(int numberOfLines, int[] numberOfParameters)
        {
            mNumberOfLines = numberOfLines;
            mNumberOfParameters = numberOfParameters;
        }

    }
}

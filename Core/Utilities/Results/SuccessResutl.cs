using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResutl : Result
    {
        public SuccessResutl(string message):base(true,message)
        {

        }

        public SuccessResutl():base(true)
        {

        }
    }
}

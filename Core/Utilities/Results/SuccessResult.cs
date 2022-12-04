using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {

        public SuccessResult(bool success) : base(true)
        {
        }

        public SuccessResult(bool success, string message) : base(success:true, message)
        {
        }

        public SuccessResult(string message) : base(default, message)
        {

        }

        public SuccessResult() : base(default)
        {

        }

    }
}

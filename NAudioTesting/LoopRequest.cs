using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAudioTesting
{
    class LoopRequest
    {
        public Func<bool> function;
        public LoopRequest(Func<bool> function)
        {
            this.function = function;
        }
        public bool run()
        {
            return function?.Invoke() == true;
        }
    }
}

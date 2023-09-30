using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib2
{
    internal class EInvalidNumber:Exception
    {
        public EInvalidNumber(string messsage):
            base(messsage) { }
    }
}

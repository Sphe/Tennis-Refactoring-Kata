using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Domain
{
    public class RangeMessage
    {

        public string Message { get; set; }

        public (int, int) Range { get; set; }

    }
}

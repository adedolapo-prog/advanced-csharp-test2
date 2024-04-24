using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTest
{
    public class args: EventArgs
    {
        public string Name { get; set; }

        public args(string name)
        {
            Name = name;
        }
    }
}

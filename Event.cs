using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exodus
{
    internal abstract class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void Describe();
    }
}

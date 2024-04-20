using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exodus
{
    internal abstract class Person : IEscapeRoute
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public virtual void Move() 
        {
            Console.WriteLine($"{Name} is following the escape route"  );
        }
    }
}

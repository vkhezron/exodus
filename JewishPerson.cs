using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exodus
{
    internal class JewishPerson : Person
    {
        public string Tribe { get; set; }

        public override void Move()
        {
            Console.WriteLine($"{Name} from the tribe of {Tribe} is following the escape route");
        }
    }
}

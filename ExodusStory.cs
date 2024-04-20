using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exodus
{
    internal class ExodusStory
    {
        private List<string> events;

        public ExodusStory()
        {
            events = new List<string>();
        }

        public void AddEvent(string eventName)
        {
            events.Add(eventName);
        }

        public void AddPlagues(List<Plague> plagues)
        {
            foreach (var plague in plagues)
            {
                AddEvent($"{plague.plagueNumber}: {plague.Name} \n{plague.Description}");
            }
        }
        public List<string> GetEvents() 
        {
            return events; 
        }

    }
}

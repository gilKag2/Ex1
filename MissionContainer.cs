using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public class FunctionsContainer
    {
        Dictionary<string, Delegate> container = new Dictionary<string, Delegate>();
        public Delegate this[string func]
        {
            get
            {
                return container[func];
            }
            set
            {
                container[func] = value;
            }
        }
        public List<string> getAllMissions()
        {
            return container.Keys.ToList();  
        }
    }
}

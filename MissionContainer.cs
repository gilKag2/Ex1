/******************
 * Gil Kagan
 * 315233221
*******************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    // delegate that recieves and returns a double.
    public delegate double FuncDelegate(double val);
    
    public class FunctionsContainer
    {
      
        // maps the name of the func to the func.
        Dictionary<string, FuncDelegate> container = new Dictionary<string, FuncDelegate>();
        public double Stam(double val) => val;
       
        /*
         * indexer.
         */ 
        public FuncDelegate this[string funcName]
        {
            get
            {
                // checks if the key exists and returns its value.
                if (container.ContainsKey(funcName))
                    return container[funcName];
                // if the key doesnt exists, 
                // then save it to the container with the stam func, and return stam.
                else
                {
                    container[funcName] = Stam;
                    return Stam;
                }
            }
            set
            {
                container[funcName] = value;
            }
        }

        /*
         * returns a list of all the missions.
         */ 
        public List<string> getAllMissions()
        {
            return container.Keys.ToList();  
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double FuncDelegate(double val);
    
    public class FunctionsContainer
    {
      
        Dictionary<string, FuncDelegate> container = new Dictionary<string, FuncDelegate>();
        public double Stam(double val) => val;
       
        public FuncDelegate this[string funcName]
        {
            get
            {
                if (container.ContainsKey(funcName))
                    return container[funcName];
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
        public List<string> getAllMissions()
        {
            return container.Keys.ToList();  
        }
    }
    
}

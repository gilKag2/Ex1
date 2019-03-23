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
    public class ComposedMission : IMission
    {
        private List<FuncDelegate> missions = new List<FuncDelegate>();
        private string name;
        /*
         * returns the name of the mission.
         */ 
        public string Name
        {
            get
            {
                return name;
            }
        }
        /*
         * returns the type of the missions.
         */
        public string Type
        {
            get
            {
                return "Composed";
            }
        }
        public ComposedMission(string name)
        {
            this.name = name;
        }
        /*
         * adds the func to the list of functions.
         */
        public ComposedMission Add(FuncDelegate func)
        {
            missions.Add(func);
            return this;
        }
        public event EventHandler<double> OnCalculate;
       
        /*
         * activates the functions by order, and returns the value.
         */ 
        public double Calculate(double value)
        {
            double res = value;
            foreach (FuncDelegate func in missions)
            {
                res = func(res);
            }
            // invokes the listeners
            OnCalculate?.Invoke(this, res);
            return res;

        }
    }
}


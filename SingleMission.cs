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
    public class SingleMission : IMission
    {
        private FuncDelegate mission;
       
        public SingleMission(FuncDelegate del, string name)
        {
            this.name = name;
            this.mission = new FuncDelegate(del);
        }

        public event EventHandler<double> OnCalculate;
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
                return "Single";
            }
        }

        /*
         * Activates the func on the given value, and returns the result.
         */
        public double Calculate(double value)
        {
            
            double res = mission(value);
            // invokes the listeners
            OnCalculate?.Invoke(this, res);
            return res;
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private List<Delegate> missions = new List<Delegate>();
        private string name;
        private string type;
        public string Name
        {
            get
            {
                return name;
            }
        }
        
        public string Type
        {
            get
            {
                return type;
            }
        }
        public ComposedMission add(Delegate del)
        {
            missions.Add(del);
            return this;
        }
        public event EventHandler<double> OnCalculate;
       
        public double Calculate(double value)
        {
            
        }
    }
}


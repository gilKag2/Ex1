using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        
        private FuncDelegate composedMission;
        private List<FuncDelegate> missions = new List<FuncDelegate>();
        private string name;
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
                return "Composed";
            }
        }
        public ComposedMission(string name)
        {
            this.name = name;
        }
        public ComposedMission Add(FuncDelegate del)
        {
            missions.Add(del);
            return this;
        }
        public event EventHandler<double> OnCalculate;
       
        public double Calculate(double value)
        {
            double res = value;
            foreach (FuncDelegate func in missions)
            {
                res = func(res);
            }
            OnCalculate?.Invoke(this, res);
            return res;

        }
    }
}


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
                return "Single";
            }
        }


        public double Calculate(double value)
        {
            double res = mission(value);
            OnCalculate?.Invoke(this, res);
            return res;
           
        }
    }
}

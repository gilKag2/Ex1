using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
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

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            throw new NotImplementedException();
        }
    }
}

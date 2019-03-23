﻿/******************
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
    public interface IMission
    {
        // An Event of when a mission is activated
        event EventHandler<double> OnCalculate;  

        String Name { get; }
        String Type { get; }

        double Calculate(double value);
    }
}


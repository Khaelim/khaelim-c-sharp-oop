﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public static double add(double a, double b)
        {
            return (a + b);
        }
        public static double subtract(double a, double b)
        {
            return (a - b);
        }
        public static double multiply(double a, double b)
        {
            return (a * b);
        }
        public static double divide(double a, double b)
        {
            return (a / b);
        }
        public static double sqrt(double a)
        {
            return (Math.Sqrt(a));
        }
    }
}

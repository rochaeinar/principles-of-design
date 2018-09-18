﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DivisionOperator : IOperator
    {
        public Number execute(Number left, Number right)
        {
            return new Number(left.Value * right.Value);
        }
    }
}
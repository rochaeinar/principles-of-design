using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Number a = new Number(1);
            Number b = new Number(2);

            Calculator calculator = new Calculator();
            calculator.Addition(a,b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class OperatorFactory
    {
        public IOperator getOperator(string type)
        {
            switch (type)
            {
                case "+": return new AdditionOperator();
                case "-": return new SubtractionOperation();
                case "*": return new MultiplicationOperator();
                case "/": return new DivisionOperator();
                default: throw new NotImplementedException();
            }

        }
    }
}

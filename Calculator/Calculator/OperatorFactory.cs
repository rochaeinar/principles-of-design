using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OperatorFactory
    {
        public Operator getOperator(Operation operation)
        {
            switch (operation)
            {
                case Operation.ADDITION: return new AdditionOperator();
                case Operation.SUBSTRACTION: return new SubtractionOperation();
                case Operation.MULTIPLICATION: return new MultiplicationOperator();
                case Operation.DIVISION: return new DivisionOperator();
                default: throw new NotImplementedException();
            }

        }
    }
}

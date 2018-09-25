using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        private OperatorFactory operatorFactory;
        public Calculator()
        {
            operatorFactory = new OperatorFactory();
        }

        public Number Addition(Number left, Number right)
        {
            return operatorFactory.getOperator(Operation.ADDITION).execute(left, right);
        }

        public Number Subtraction(Number left, Number right)
        {
            return operatorFactory.getOperator(Operation.SUBSTRACTION).execute(left, right);
        }

        public Number Multiplication(Number left, Number right)
        {
            return operatorFactory.getOperator(Operation.MULTIPLICATION).execute(left, right);
        }

        public Number Division(Number left, Number right)
        {
            return operatorFactory.getOperator(Operation.DIVISION).execute(left, right);
        }
    }
}

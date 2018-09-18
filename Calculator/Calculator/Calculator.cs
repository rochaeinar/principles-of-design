using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        private OperatorFactory operatorFactory;
        public Calculator()
        {
            operatorFactory = new OperatorFactory();
        }

        public Number Addition(Number left, Number right)
        {
            return operatorFactory.getOperator("+").execute(left, right);
        }

        public Number Subtraction(Number left, Number right)
        {
            return operatorFactory.getOperator("-").execute(left, right);
        }

        public Number Multiplication(Number left, Number right)
        {
            return operatorFactory.getOperator("*").execute(left, right);
        }

        public Number Division(Number left, Number right)
        {
            return operatorFactory.getOperator("/").execute(left, right);
        }
    }
}

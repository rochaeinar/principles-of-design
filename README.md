# Principios de diseño y desarrollo de software

# En cuanto a los "Valores" identificados
* “simplicity”: En el código de ejemplo se implemento pensando en que la lectura del código fuera muy simple con líneas bastante simples hasta para un desarrollador junior

		Number a = new Number(1);
		Number b = new Number(2);
		Calculator calculator = new Calculator();
		calculator.Addition(a,b);

* “flexibility”: Se trato de ejemplificar la flexibilidad haciendo uso de un “Factory” (Operatorfactory.cs) ya que el uso de “Factory” permite una mayor flexibilidad a largo plazo. También Permite un diseño más desacoplado y, por lo tanto, más comprobable. 

		public Number Addition(Number left, Number right)
		{
		    return operatorFactory.getOperator("+").execute(left, right);
		}
# En cuanto a algunos “Principios” se identifico y se trato de ejemplificar los siguientes:
* “Local Consequences”: Se identifico este principio en cada Clase que implementa de “IOperator”, ya que cualquier modificación dentro de los métodos implementados no afecta a otros operadores.

		class AdditionOperator : IOperator
		{
				public Number execute(Number left, Number right)
				{
				 return new Number(left.Value + right.Value);
				}
		}
    
* “Small pieces”, Se implemento este ejemplo usando clases pequeñas, métodos pequeños que solo tienen una simple y única responsabilidad

		class SubtractionOperation : IOperator
		{
				public Number execute(Number left, Number right)
				{
						return new Number(left.Value - right.Value);
				}
		}
* “Symmetry”: Se identifico este principio en la clase “Calculator.cs” donde solo se encuentran métodos “Simétricos” (en cierto punto de vista) por ejemplo “Addition” y “Subtraction”.

		public Number Addition(Number left, Number right)
		{
				return operatorFactory.getOperator("+").execute(left, right);
		}

		public Number Subtraction(Number left, Number right)
		{
				return operatorFactory.getOperator("-").execute(left, right);
		}
* “Declarative Expression”: La implementación de todos los métodos se hizo de tal forma de demostrar que es lo que “hace” explícitamente.

		calculator.Addition(a,b);

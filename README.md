# principles-of-design
Principios de diseño y desarrollo de software

# En cuanto a los "Valores" identificados
•	“simplicity”: En el código de ejemplo se implemento pensando en que la lectura del código fuera muy simple con líneas bastante simples hasta para un desarrollador junior
•	“flexibility”: Se trato de ejemplificar la flexibilidad haciendo uso de un “Factory” (Operatorfactory.cs) ya que el uso de “Factory” permite una mayor flexibilidad a largo plazo. También Permite un diseño más desacoplado y, por lo tanto, más comprobable. 
# En cuanto a algunos “Principios” se identifico y se trato de ejemplificar los siguientes:
•	“Local Consequences”: Se identifico este principio en cada Clase que implementa de “IOperator”, ya que cualquier modificación dentro de los métodos implementados no afecta a otros operadores.
•	“Small pieces”, Se implemento este ejemplo usando clases pequeñas, métodos pequeños que solo tienen una simple y única responsabilidad
•	“Symmetry”: Se identifico este principio en la clase “Calculator.cs” donde solo se encuentran métodos “Simétricos” (en cierto punto de vista) por ejemplo “Addition” y “Subtraction”.
•	“Declarative Expression”: La implementación de todos los métodos se hizo de tal forma de demostrar que es lo que “hace” explícitamente.

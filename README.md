# C-sharp

Primera clase:  Software necesario


En este curso vamos a programar con un lenguaje de programación llamado C# (C sharp). El lenguaje fue desarrollado por Microsoft y tiene una forma de ser escrito bastante
parecida a lo que es C++ o Java.
Para poder programar en C# necesitamos contar con toda la suite de desarrollo de Microsoft que se instala automáticamente al descargar e instalar un IDE que se llama Visual
Studio Community. El tema es que este programa es súper pesado y no tiene mucho sentido, por ahora.
Así que lo que vamos a usar es su hermano menor, que no es menos importante y de hecho es uno de los más famosos hoy en día. Se llama Visual Studio Code. No confundan el nombre,
es muy parecido, pero son dos cosas bastante distintas.
El tema es que el Visual Studio Code no te instala todo automáticamente. Pero no pasa nada, es instalar una sola cosa aparte.
Entonces, lo primero que tenés que hacer es descargar e instalar:
Visual Studio Code
Y luego de que lo tengas instalado, vamos a descargar e instalar el Software Development Kit de Microsoft .Net Core. Ufff... cuánto nombre... es básicamente un kit de desarrollo
que tiene todo lo que necesitamos, no te asustes.
SDK .Net Core
Nota: para poder instalar todo esto necesitás contar con Windows. Si no usás Windows, contame que lo podemos adaptar para el sistema que uses. 
Crear nuevo proyecto
Lo vamos a ver en la clase, pero si querés ir intentando, te dejo los pasos a seguir para poder crear un nuevo proyecto.
Lo primero que necesitamos hacer es abrir la terminal, o consola de comandos. En Windows, para ello podés presionar la combinación de teclas Windows + R y en el cuadro de
diálogo escribir "cmd" y presionar Enter. Otra forma es buscando la consola en el buscador del menú de Windows.
Una vez allí lo que tendrás que hacer es posicionarte en una carpeta. O sea entrar a una carpeta en la que vamos a crear el proyecto. Para ello te recomiendo que vayas al
escritorio o a Documents y te crees una carpeta que se llame "Práctica Programación" o algo por el estilo. Allí dentro crearás luego todos tus proyectos.
Supongamos que en Documents creaste la carpeta "Ejercicios", entonces en la consola deberías escribir:
cd C:\Users\msarfernandez\Documents\Ejercicios
O sea, la clave "cd" seguida por un espacio y luego la ruta completa de la carpeta. En el ejemplo es la ruta completa en MI máquina, vos tenés que poner la ruta completa en la
tuya. 
Una vez que logres eso vas a ver algo así:
 
Eso quiere decir que ya estás dentro de la carpeta.
Ahora lo que tenés que poner es lo siguiente:
dotnet new console -o nombreproyecto
Esto va a crear una nueeeva carpeta adentro de tu carpeta Ejercicios con el nombre "nombreproyecto" o el nombre que le pongas.
Ahora abrís Visual Studio Code y lo que hacés es simplemente arrastrar la nueva carpeta al Visual Studio Code. Se te va a abrir el proyecto y deberías ver algo así:
 
Bueno, falta poquito. Parece largo pero vas a ver que luego de hacerlo dos o tres veces, ya está.
Volvemos a la consola y escribimos:
cd nombreproyecto
Esto nos deja DENTRO de la carpeta del proyecto que corresponda, acordate que en mi ejemplo se llama así... qué ejemplo, no?...
Bueno, una vez allí, ahora escribimos:
dotnet restore
y presionamos enter. Y luego:
dotnet run
Tardará unos segundos y vas a ver en pantalla la frase "Hello World". 
Uff, listo, ejecutaste tu primer programa. 

Te repito que esto lo vamos a ver y varias veces clase a clase. Pero siempre tendrás esta guía paso a paso o para anticiparte o para venir. a consultar cuando necesites.
Cualquier cosa, me consultás!

http://youtube.com/watch?v=s6i5I1b4y-I&utm_source=youtube.com&utm_medium=short_domains&utm_campaign=ssyoutube.com&a_ts=1626454393.643

Introducción
La programación es una disciplina (de tantas hoy en día) que pertenece a la informática, ciencia que se dedica al análisis y transformación de datos e información a partir del
uso de computadoras.
En dicha disciplina se desarrollan algoritmos en un determinado lenguaje de programación, los cuales serán implementados en una computadora para de esa manera realizar los
llamados programas.
Algoritmo
Un algoritmo es una secuencia finita y ordenada de instrucciones que deben ser seguidas en pos de resolver un problema. 

https://www.youtube.com/watch?v=i3J42rmbrBQ


https://www.youtube.com/watch?v=kJCin3JwIBY


Programa
Un programa es, técnicamente hablando, uno o más (al menos uno) algoritmos de programación escrito en un lenguaje que puede ser interpretado y ejecutado por una computadora. En
otras palabras, decimos que un programa es la solución a un problema, ya que cada vez que se requiere desde sumar números hasta realizar traducciones, grandes cálculos o enviar
mensajes de texto, se recurre a un programa (o aplicación, o web, lo que corresponda). 

https://www.youtube.com/watch?v=xmbRFUy8fcc


Existen distintos tipos de programas o aplicaciones (podemos decir que son sinónimos), por ejemplo:
-       Programas de escritorio: Se ejecutan en windows, por ejemplo Word, Excel, el buscaminas.
-       Programas web: Facebook, Mercado Libre, son aplicaciones o sistemas web.
-       Programas de celular: también llamados apps, o aplicaciones, por ejemplo Whatsapp, Instagram, Google Maps.
Todos estos son parte de un gran grupo dentro de la informática que se denomina Software.
Sistema Informático
El sistema informático está compuesto necesariamente por tres partes:
-       Hardware
-       Software
-       Humano
Ante la ausencia de alguna de éstas partes, no podríamos completar el sistema y este no tendría sentido dado que:
Software es todo lo que creamos para que una computadora funcione, pero requiere justamente una computadora donde hacerlo, ahí entra el Hardware.
Hardware es “todo lo que se puede tocar” en una computadora: el monitor, el teclado, incluso todos los componentes internos dentro de la misma. 
Sin embargo, sin programas para utilizar, todo ese poder de procesamiento, no nos sería de utilidad.
Humano. Se completa el ciclo con el humano que es quien hace uso de ese Software gracias a ese Hardware, y quizá pueda sonar a una obviedad, pero es clave tener en cuenta este
círculo.
Como ya dijimos, el Software es lo que le da vida a la computadora. Son los programas que nos permiten utilizarlas, y existen distintas categorizaciones dentro del software. 
Las más comunes son:
-       Software de base: esto corresponde a las cuestiones básicas y de sistema operativo que se requiere para poder encender y usar una computadora (Windows, Linux, Mac OS,
-        Android, iOS).
-       Software utilitarios: son aplicaciones complementarias para el correcto funcionamiento y/o administración de los sistemas. Podemos hablar del desfragmentador de disco, 
o utilidades de análisis de errores en memoria, entre otros.
-       Software de aplicación: los programas, sistemas o aplicaciones que utilizamos a diario.
Existen más categorías y sub-categorías y además ciertas características adicionales como si son libres, o no, o si son open source, o multiplataforma, pero eso es para indagar
en otro contexto.
También podemos mencionar los “programas para programar”. Desde ya que hoy en día para poder desarrollar programas, vamos a necesitar una computadora, pero además vamos a
necesitar uno o más (según corresponda) programas que nos sirvan para ello. Hay aplicaciones específicamente preparadas para, justamente, desarrollar otras aplicaciones, en
definitiva, para programar. Estas aplicaciones se suelen conocer como IDE, de sus siglas en inglés "Entorno de Desarrollo Integrado".
Dependiendo de lo que quisiéramos programar, será la aplicación que deberíamos utilizar, y esto aplica del mismo modo para la tecnología o lenguaje de programación a utilizar.


https://www.youtube.com/watch?v=_rl4vXVgoyE

 
https://www.youtube.com/watch?v=wvJv1CDptvc
Tipos de datos
Como veremos más adelante, al programar no solo hay que escribir en un lenguaje determinado, sino que vamos a tener que utilizar muchas herramientas distintas, dentro de la propia programación, que iremos adquiriendo a medida que vayamos avanzando. Una de esas herramientas y de la que más vamos a hablar y utilizar de entrada (y para siempre si seguís con la programación) es la variable.
Una variable, técnicamente hablando, un espacio en la memoria de la computadora destinado a ser utilizado por nuestro programa para poder guardar un dato. La variable tiene ciertas características como que debe contar con un nombre, que puede guardar un solo dato a la vez (el mismo puede ir cambiando, de allí su nombre) y que debe tener un tipo. Este tipo se refiere a qué es lo que precisamente va a guardar esa variable. Los primeros tipos que aprendemos son los más basicos y elementales pero que nos acompañarán, junto a las variables, en toda la vida dentro de la programación. Estos tipos son:
-       Int para guardar números enteros.
-       Float o double (dependiendo del lenguaje, hay otras variantes) para guardar números con coma.
-       Char para guardar letras.
-       Bool para guardar verdadero o falso (que es lo mismo a 1 o 0 respectivamente.
Que le asignemos un tipo de dato a una variable afecta y tiene una relevancia puntual. Si estoy creando una variable de tipo entera, la misma solamente podrá guardar valores enteros. Qué sucederá si quiero guardarle un número con coma? Bueno, dependiendo del momento, el lenguaje o la operación, podrá dar error o bien podrá redondear el valor quitando los decimales y quedándose solo con la parte entera. Ninguno de los escenarios serían pertinentes en nuestro programa. Lo ideal sería que si la variable solo admite valores enteros, pues que se la use con valores enteros.
https://www.youtube.com/watch?v=kJ2vUwgxzSY

https://www.youtube.com/watch?v=IfvTgaMX4J4


Ejercicios 1


https://www.youtube.com/watch?v=8ANRCYtveMI


https://www.youtube.com/watch?v=Bm3X8eHVv-s


Esta unidad es más teórica introductoria que para ejercitar. Por eso el siguiente ejercicio va a ser más que nada para que testeemos que el entorno quedó configurado
correctamente y que estamos en condiciones para comenzar a programar.
1. Para este primer ejercicio deberás crear tu primer programa que emita en pantalla "Hola Mundo".
Adicionalmente, podés hacer las modificaciones correspondientes para que el programa emita "Bienvenido Juanito", donde "Juanito" puede ser tu nombre. 
En este módulo comenzamos a manejar conceptos más precisos y técnicos, puntuales y necesarios para la confección de nuestros primeros programas.
En la unidad anterior comprendimos las herramientas a utilizar y llevamos a cabo la creación del primer proyecto para corroborar que todo estaba en orden.
Lo primero que tenemos que comenzar a comprender en cuanto a los programas es que existe un principio básico de todo algoritmo, de todo programa, de toda aplicación; el cual se
basa en el esquema que se muestra a continuación:
 
Todo programa, para poder operar, necesita contar con una entrada de datos con los cuales realizará un posterior procesamiento, una transformación de esos datos, a partir de 
los cuales terminará obteniendo información para finalmente brindar una salida.
Nuestro ejemplo más sencillo parte de la necesidad de sumar dos números. Para poder sumar dos números, el programa deberá solicitarlos (o recibirlos), es decir, contar con una
entrada de datos que serán esos dos números. Luego aplicará un procesamiento, que en este caso será sumar esos dos valores que fueron ingresados; para finalmente obtener el
resultado de la suma y mostrarlo en pantalla. Esta última sería la salida de información.
¿Dato o Información?
Por qué se hace hincapié en la diferencia de que lo que entra son Datos y lo que sale es Información? Podríamos tomarlos como sinónimos?
La definición de datos dice que: un dato es un conjunto de símbolos sin significado alguno, mientras que por otro lado, la definición de información afirma que: la información está compuesta por símbolos a los que se le ha atribuido algún significado.
Yo siempre suelo dar un ejemplo un tanto fantástico, pero simple y que, a mí entender, funciona para comprender la idea.
Se trata de una persona que, caminando por la calle, se encontró con un pergamino tirado. Cuando lo abre se trata de un documento bastante elegante, con firmas y demás pero con
un texto que esta persona no podía comprender. Pensó en hacer un cuadro, ya que era lindo, vistoso; terminó por regalárselo a un amigo hijo de japoneses. Este amigo resulta que
manejaba la lengua nativa de Japón por sus padres y al ver el pergamino entendió de qué se trataba y no solo eso, pudo leerlo pues estaba escrito en un lenguaje que manejaba y
comprendía. Se trataba de un documento correspondiente a un testamento el cual otorgaba una fortuna a quién lo encuentre y, desde ya, pueda reclamarlo por saber de qué se
trataba.
A qué quiero llegar con todo esto? Para la primera persona ese pergamino no era más que un papel "lindo" que a lo sumo podría utilizar para decorar una sala. Un papel con un
conjunto de símbolos sin sentido. Pero por otro lado, para su amigo, quien contaba con los elementos necesarios para comprender ese papel, lo que decía en él, par aplicar un
procesamiento (a partir de traducir -aplicar un algoritmo-) el contenido del mismo, pasó a atribuirle un significado valiosísimo, en este caso monetario, transformando esos
datos en información, mediante un procesamiento.
El fin de toda aplicación es siempre obtener información.
El proceso y las variables
Para poder realizar las transformaciones de las que hablamos necesitamos construir nuestros algoritmos con las instrucciones necesarias. Desde ya que tendremos, generalmente,
para comenzar un ingreso de datos y para terminar una salida de información. Pero en el medio es donde vamos a tener que establecer las instrucciones necesarias para darle 
forma al proceso pertinente que realice la transformación, o "la magia".
Volviendo a nuestro ejemplo de la suma, el proceso sería justamente sumar, valga la redundancia, pero hay varias cosas que se encuentran implícitas en esa operación.
Para poder sumar dos valores necesitamos previamente contar con ellos, y para eso no alcanza con pedirlos. Una vez que los pedimos, tenemos que guardarlos. Para poder guardar
esos datos vamos a necesitar hacer uso de un elemento fundamental en la programación: la variable. Una variable es un espacio en memoria que permite alojar un valor. Es un 
medio que utilizaremos en nuestros programas para ir guardando todas las cosas que necesitamos dentro y a lo largo de todo algoritmo.
Imaginen la memoria RAM (si no conocen la memoria RAM repasen el video de la PC del módulo 1) como una hoja excel, la cual cuenta con columnas representadas por letras y filas
representadas por números y en cada intersección encontramos una celda. 
 
Ok. Si yo digo C5, estoy haciendo referencia a la columna C en la fila 5. Podemos decir que la memoria RAM trabaja parecido a esto. C5 sería la dirección de memoria de esa
celda. Sin embargo, al querer usar esas "celdas" (variables) en nuestros programas no vamos a estar todo el tiempo usando direcciones de memoria, para ello, lo que haremos es
ponerle nombre a las variables. De ese modo, podremos hacer referencia a esas celdas mediante un nombre significativo y fácil de recordar. Significativo porque deberíamos
nombrar nuestras variables teniendo en cuenta qué es lo que contienen dentro. 
Volviendo una vez más a nuestro ejemplo de la suma, para guardar los dos valores ingresados podemos decir que lo haremos en las variables numero1 y numero2. Los nombres de las
variables pueden contener cualquier letra, varias palabras y también números, aunque hay ciertas restricciones: 
•	No se puede comenzar el nombre de una variable con números.
•	El nombre no puede estar compuesto solo por números.
•	El nombre no puede contener símbolos especiales (por ejemplo * o +).
El nombre no puede ser igual a una palabra reservada. Dependiendo del lenguaje de programación que usemos, hay palabras que son específicas para hacer algo puntual, con lo cual
no podemos usarlas como nombres de variables. Por ejemplo:
Console
Palabra que usamos para invocar a la muestra de un mensaje en pantalla como vimos en el primer proyecto de ejemplo:
Console.WriteLine("Hola Mundo");


https://www.youtube.com/watch?v=1_xqLhsk9Ns


https://www.youtube.com/watch?v=kJ2vUwgxzSY


Operadores Aritméticos
Son los primeros operadores que comenzaremos a utilizar. Estos son:
•	+ para sumar
•	- para restar
•	* para multiplicar
•	/ para dividir
Estas son las operaciones básicas que el procesador ya conoce y que tenemos disponibles para utilizar. De allí para arriba, es decir, un cuadrado, un logaritmo, etc., etc., 
son operaciones que tendremos que construir a mano porque el procesador no las sabe. Es verdad que en la actualidad existen muchas cosas ya hechas las cuales podemos utilizar
(se llaman librerías, las veremos más adelante), pero generalmente cuando se está comenzando en la programación, una de las primeras cosas se trata de recrear algunas de esas
funcionalidades para entender cómo trabajan.


https://www.youtube.com/watch?v=BbYo0eeBNUw


Asignación
La asignación es una acción mediante la cual se da un valor a una variable. Por ejemplo
jota = 10;
Lo que estamos haciendo en esa instrucción es tomar el valor 10 y asignarlo, o sea guardarlo, en la variable llamada jota. Hay varios orígenes de datos para realizar una
asignación. La que acabamos de ver directamente asigna un valor. También se puede asignar el resultado de una operación matemática o simplemente asignar lo que se pide que una
persona ingrese por teclado:
resultado = jota + 7;
variable = Console.ReadLine();
El primer programa
Ya sabemos que tenemos que pedir y guardar, y que tenemos que procesar y mostrar. Y tenemos casi todas las herramientas. Hagamos nuestro primer programa en código y luego
terminamos de analizar.
int numero1;
int numero2;
int resultado;
numero1 = int.Parse(Console.ReadLine());
numero2 = int.Parse(Console.ReadLine());
resultado = numero1 + numero2;
Console.WriteLine(resultado);
En las primeras tres líneas lo que hacemos es declarar las variables y darles un tipo. Trabajaremos con números enteros (recordemos que los tipos que manejaremos por ahora son
int, float, char y bool).
Luego pedimos datos por teclado con la función ReadLine. La misma devuelve un texto, es por eso que con int.Parse lo que hacemos es transformarlo a número, que es lo que
queremos. Tranqui, hay cosas que de a poco vamos a ir terminando de entender.
Luego de pedir y guardar los datos en nuestras variables, volvemos a usar éstas últimas ahora para leer el contenido que antes guardamos y, haciendo uso del operador aritmético
para sumar, realizamos la suma. El resultado lo guardamos con el operador = (que en programación no es igual, sino asignar). 
Finalmente, con WriteLine volvemos a leer, esta vez el valor que quedó guardado en resultado, para mostrarlo en pantalla.
Y listo, ese es nuestro primer programa. Todos estos pasos que tenemos detallados aquí, los tenés súper explicados en el video "Primer Programa" que te sugiero que veas.
Luego de todo esto, ya estamos en condiciones para seguir avanzando en la creación de otros programas de este tipo.
Tenés algunos ejercicios para practicar. 
Otra cosas interesantes que deberías saber:


https://www.youtube.com/watch?v=wvJv1CDptvc


https://www.youtube.com/watch?v=pju8moNrEHE


https://www.youtube.com/watch?v=gk0FOyOOw5I


Mi primer programa:

https://www.youtube.com/watch?v=tgBDluKHcws


Calculadora en diagrama de flujo.
Figura de ingreso pide valores de entrada
La de egreso muestra en pantalla
La de proceso, procesa los valores de entrada
El inicio y el fin marcan el comienzo y final de un programa.


El if condicional: https://www.youtube.com/watch?v=TTvnrL1KUZM


Ejercicios resueltos: guía 1 empeza a programar: https://www.youtube.com/watch?v=SvMQ6-Qlfos&t=134s


Tipo de dato INT:

Integral numeric types (C# reference)
The integral numeric types represent integer numbers. All integral numeric types are value types. They are also simple types and can be initialized with literals. All integral
numeric types support arithmetic, bitwise logical, comparison, and equality operators.
 
In all of the table rows except the last two, each C# type keyword from the leftmost column is an alias for the corresponding .NET type. The keyword and .NET type name are
interchangeable. For example, the following declarations declare variables of the same type:
int a = 123;
System.Int32 b = 123;
The nint and nuint types in the last two rows of the table are native-sized integers. They are represented internally by the indicated .NET types, but in each case the keyword
and the .NET type are not interchangeable. The compiler provides operations and conversions for nint and nuint as integer types that it doesn't provide for the pointer types
System.IntPtr and System.UIntPtr. For more information, see nint and nuint types.
The default value of each integral type is zero, 0. Each of the integral types except the native-sized types has MinValue and MaxValue constants that provide the minimum and
maximum value of that type.
Use the System.Numerics.BigInteger structure to represent a signed integer with no upper or lower bounds.
Integer literals
Integer literals can be
•	decimal: without any prefix
•	hexadecimal: with the 0x or 0X prefix
•	binary: with the 0b or 0B prefix (available in C# 7.0 and later)
The following code demonstrates an example of each:
var decimalLiteral = 42;
var hexLiteral = 0x2A;
var binaryLiteral = 0b_0010_1010;
The preceding example also shows the use of _ as a digit separator, which is supported starting with C# 7.0. You can use the digit separator with all kinds of numeric literals.
The type of an integer literal is determined by its suffix as follows:
•	If the literal has no suffix, its type is the first of the following types in which its value can be represented: int, uint, long, ulong.
 Note
Literals are interpreted as positive values. For example, the literal 0xFF_FF_FF_FF represents the number 4294967295 of the uint type, though it has the same bit representation
as the number -1 of the int type. If you need a value of a certain type, cast a literal to that type. Use the unchecked operator, if a literal value cannot be represented in the
target type. For example, unchecked((int)0xFF_FF_FF_FF) produces -1.
•	If the literal is suffixed by U or u, its type is the first of the following types in which its value can be represented: uint, ulong.
•	If the literal is suffixed by L or l, its type is the first of the following types in which its value can be represented: long, ulong.
 Note
You can use the lowercase letter l as a suffix. However, this generates a compiler warning because the letter l can be confused with the digit 1. Use L for clarity.
•	If the literal is suffixed by UL, Ul, uL, ul, LU, Lu, lU, or lu, its type is ulong.
If the value represented by an integer literal exceeds UInt64.MaxValue, a compiler error CS1021 occurs.
If the determined type of an integer literal is int and the value represented by the literal is within the range of the destination type, the value can be implicitly converted to sbyte, byte, short, ushort, uint, ulong, nint or nuint:
byte a = 17;
byte b = 300;   // CS0031: Constant value '300' cannot be converted to a 'byte'
As the preceding example shows, if the literal's value is not within the range of the destination type, a compiler error CS0031 occurs.
You can also use a cast to convert the value represented by an integer literal to the type other than the determined type of the literal:
var signedByte = (sbyte)42;
var longVariable = (long)42;
Conversions
You can convert any integral numeric type to any other integral numeric type. If the destination type can store all values of the source type, the conversion is implicit.
Otherwise, you need to use a cast expression to perform an explicit conversion. For more information, see Built-in numeric conversions.
C# language specification
For more information, see the following sections of the C# language specification:
•	Integral types
•	Integer literals
See also
•	C# reference
•	Value types
•	Floating-point types
•	Standard numeric format strings
•	Numerics in .NET
Feedback

Tipo de dato FLOAT:
Floating-point numeric types (C# reference)
The floating-point numeric types represent real numbers. All floating-point numeric types are value types. They are also simple types and can be initialized with literals. All
floating-point numeric types support arithmetic, comparison, and equality operators.
 
The default value of each floating-point type is zero, 0. Each of the floating-point types has the MinValue and MaxValue constants that provide the minimum and maximum finite
value of that type. The float and double types also provide constants that represent not-a-number and infinity values. For example, the double type provides the following
constants: Double.NaN, Double.NegativeInfinity, and Double.PositiveInfinity.
The decimal type is appropriate when the required degree of precision is determined by the number of digits to the right of the decimal point. Such numbers are commonly used in
financial applications, for currency amounts (for example, $1.00), interest rates (for example, 2.625%), and so forth. Even numbers that are precise to only one decimal digit
are handled more accurately by the decimal type: 0.1, for example, can be exactly represented by a decimal instance, while there's no double or float instance that exactly
represents 0.1. Because of this difference in numeric types, unexpected rounding errors can occur in arithmetic calculations when you use double or float for decimal data. You
can use double instead of decimal when optimizing performance is more important than ensuring accuracy. However, any difference in performance would go unnoticed by all but the
most calculation-intensive applications. Another possible reason to avoid decimal is to minimize storage requirements. For example, ML.NET uses float because the difference
between 4 bytes and 16 bytes adds up for very large data sets. For more information, see System.Decimal.
You can mix integral types and the float and double types in an expression. In this case, integral types are implicitly converted to one of the floating-point types and, if
necessary, the float type is implicitly converted to double. The expression is evaluated as follows:
•	If there is double type in the expression, the expression evaluates to double, or to bool in relational and equality comparisons.
•	If there is no double type in the expression, the expression evaluates to float, or to bool in relational and equality comparisons.
You can also mix integral types and the decimal type in an expression. In this case, integral types are implicitly converted to the decimal type and the expression evaluates 
to decimal, or to bool in relational and equality comparisons.
You cannot mix the decimal type with the float and double types in an expression. In this case, if you want to perform arithmetic, comparison, or equality operations, you must
explicitly convert the operands either from or to the decimal type, as the following example shows:
double a = 1.0;
decimal b = 2.1m;
Console.WriteLine(a + (double)b);
Console.WriteLine((decimal)a + b);
You can use either standard numeric format strings or custom numeric format strings to format a floating-point value.
Real literals
The type of a real literal is determined by its suffix as follows:
•	The literal without suffix or with the d or D suffix is of type double
•	The literal with the f or F suffix is of type float
•	The literal with the m or M suffix is of type decimal
The following code demonstrates an example of each:
double d = 3D;
d = 4d;
d = 3.934_001;

float f = 3_000.5F;
f = 5.4f;

decimal myMoney = 3_000.5m;
myMoney = 400.75M;
The preceding example also shows the use of _ as a digit separator, which is supported starting with C# 7.0. You can use the digit separator with all kinds of numeric literals.
You can also use scientific notation, that is, specify an exponent part of a real literal, as the following example shows:
double d = 0.42e2;
Console.WriteLine(d);  // output 42

float f = 134.45E-2f;
Console.WriteLine(f);  // output: 1.3445

decimal m = 1.5E6m;
Console.WriteLine(m);  // output: 1500000
Conversions
There is only one implicit conversion between floating-point numeric types: from float to double. However, you can convert any floating-point type to any other floating-point
type with the explicit cast. For more information, see Built-in numeric conversions.
C# language specification
For more information, see the following sections of the C# language specification:
•	Floating-point types
•	The decimal type
•	Real literals
See also
•	C# reference
•	Value types
•	Integral types
•	Standard numeric format strings
•	Numerics in .NET
•	System.Numerics.Complex

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Ejercicios 2
Leer atentamente y resolver!
Para cada ejercicio deberás escribir el código correspondiente y probar su funcionamiento.

1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

1) using System;

namespace sumar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mi app de sumar
            //paso cero pedirle guardar valores en variables
            //pedir 2 numeros, sumar dos numeros y devolver el resultado
            //para pedir datos en pantalla
            //Console.WriteLine() escribe una linea; Console.Write() escribe lo siguiente;
            int numero1;
            int numero2;
            int resultado; 
            Console.WriteLine("Ingrese un numero");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            numero2 = int.Parse(Console.ReadLine());
            
            //Operacion
            resultado = numero1 + numero2;
            Console.WriteLine("Gracias por usar la aplicacion");
            Console.WriteLine("Los nros ingresados son:");
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine("El resultado es: " + resultado);
            //Ejercicio 2: Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
            int numerox;
            Console.WriteLine("Ingrese un numero");
            numerox = int.Parse(Console.ReadLine());
            Console.WriteLine("El cubo del numero ingresado es:");
            Console.WriteLine(numerox * numerox * numerox);
            //Ejercicio 3: Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            float diferencia;
            Console.WriteLine("Ingrese los Km de diferencia entre las dos ciudades:");
            diferencia = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese la velocidad promedio");
            float km;
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Llegara al punto de destino en:");
            Console.WriteLine(diferencia / km);
            //Ejercicio 4: Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            float total;
            Console.WriteLine("Ingrese el total facturado");
            total = int.Parse(Console.ReadLine());
            float comision = total * 0.05;
            float sueldo = comision + 15000;
            Console.WriteLine("El sueldo total es:");
            Console.WriteLine(sueldo);
            //Ejercicio 5: Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.
            int nota1;
            int nota2;
            int nota3;
            Console.WriteLine("Ingrese sus 3 notas:");
            int nota1 = int.Parse(Console.ReadLine());
            int nota2 = int.Parse(Console.ReadLine());
            int nota3 = int.Parse(Console.ReadLine());
            int promedio = (nota1 + nota2 + nota3)/3;
            Console.WriteLine("Su promedio es: ");
            Console.WriteLine(promedio);
        }
    }
}

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Clase 3: Condicionales
Módulo 3 - Lectura
Condicionales
A ésta altura ya hemos desarrollado nuestros primeros programas. Los mismos se encargan de realizar operaciones matemáticas sencillas solicitando datos a un usuario y luego mostrando un resultado en pantalla. Las operaciones no tienen por qué ser sencillas, vimos que podemos combinar los operadores aritméticos y hacer uso de paréntesis (como en matemática) para separar en términos y demás con el fin de llegar a armar operaciones un poco más complejas que una simple suma.
Sin embargo, todos estos programas siguen siendo lineales, tengan tres líneas de código o cien. Quiere decir que comienzan por la primera instrucción y recorre absolutamente cada línea ejecutando todo lo que se encuentre en su camino hasta concluir.
Existen momentos en los que vamos a querer ejecutar instrucciones bajo determinados escenarios; en determinadas circunstancias o en situaciones específicas exceptuando de ese modo un escenario alterno. Por ejemplo: calcular y mostrar el resultado de una suma si el primer número ingresado es mayor a 10.
Ya hicimos programas que piden y suman dos números, pero ahora solamente hay que sumarlos si el primer ingreso es mayor a 10, de otro modo, no hay que hacerlo. 
Para esto, y muchas otras cosas, existe una herramienta en programación denominada "If", del idioma inglés "si". Se trata de una herramienta que nos permitirá confeccionar condiciones (realizar preguntas) que tendrán como resultado posible SI o NO y dependiendo de cuál sea la respuesta podremos programar distintos sets de instrucciones.
Una vez que se establece una condición If, lo que sucede es que se bifurca, se divide el flujo de ejecución del programa, creando, por así decirlo, dos "dimensiones" o caminos alternativos. El programa deberá elegir uno de esos caminos a seguir, no ejecutará los dos al mismo tiempo ni primero uno y luego el otro. No. Se evalúa la condición, y si el resultado es SI (recordemos que los posibles son SI o NO, o true o false, o 1 o 0), entonces se ejecutará el set de instrucciones programado en ese camino; pero si la respuesta a la pregunta es NO, entonces se ejecutará el otro set de instrucciones (en caso de haberlo, el NO puede no tener nada para ejecutar).

Lo podemos ver un poco más en detalle y de manera gráfica en el siguiente video:


Link de youtube: https://www.youtube.com/watch?v=TTvnrL1KUZM&t=1s


Ejemplo en código
Por otro lado, podemos ver el código del ejemplo antes mencionado;
int a, b, c;
Console.WriteLine("ingrese un nro");
a = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese un nro");
b = int.Parse(Console.ReadLine());
If(a > b) {
   c = a + b;
   Console.WriteLine("El resultado es: " + c);
}
Console.ReadLine();
Explicado paso a paso:
1.	Declaramos las variables.
2.	Mostramos un cartel para pedir el primer número.
3.	Leemos y guardamos el primer número.
4.	Mostramos otro cartel para pedir el siguiente número. 
5.	Leemos y guardamos el segundo número.
6.	Establecemos la condición IF. En la misma preguntamos si el contenido de la variable "a" es mayor a 10.
7.	Si es mayor a 10, se ejecutará el contenido siguiente encerrado entre llaves, sino no entra a ese set y sigue de largo.
Algunas consideraciones a tener en cuenta:
Formato de las condiciones
Las condiciones están formadas, inicialmente, por tres partes: 
•	Un valor.
•	Un operador de comparación.
•	Otro valor a ser comparado.
En este caso el primer valor corresponde al contenido de la variable "a", mientras que el operador de comparación es ">" (mayor) y finalmente el segundo valor es el literal
"10".
Operadores relacionales
Los operadores disponibles para construir condiciones lógicas se denominan relacionales, y son los siguientes:
•	> mayor
•	< menor
•	>= mayor o igual
•	<= menor o igual
•	== igual (nótese que no es = a secas, son dos símbolos juntos para la igualdad)
•	!= distinto

Por ahora, solo podemos poner una condición por If. Es decir, una sola "valor condición valor"; con lo cual, deberías tener solamente dos valores y UN operador relacional, 
para que se entienda que es correcta la condición.
Ejemplos
Ejemplos correctos
•	A > 10
•	B < 12
•	A != B
•	C == 20
Ejemplos incorrectos
•	A > B < 10 en este caso tenemos dos operadores y tres valores. No es correcto.
•	10 < 15 en este caso tenemos dos literales, no tiene sentido la condición pues siempre va a dar verdadero.

Si se te ocurren otros ejemplos y no sabés si son correctos, podés postearlos en el Foro de dudas y los vemos.

¿Verdadero o Falso?
Hasta ahora vimos como hacer una condición y trabajar si la misma da como resultado true o no hacer nada si la misma da como resultado false. Por ejemplo:
int edad = 21;
if(edad > 18){
   Console.WriteLine("Sos mayor");
}
En este caso muestra un cartel en pantalla si edad tiene un valor mayor a 18 y en caso contrario, no hace nada. Pero qué pasa si sí quisiéramos hacerlo? En ese caso lo que
podemos hacer es escribir el bloque else, que, como te habrás dado cuenta, es opcional, ya que hasta ahora no lo habíamos hecho. 
De este modo, siguiendo el mismo ejemplo, podemos mostrar un cartel que diga que sos menor si el valor no es mayor a 18, o sea, si la condición fue falsa.
int edad = 17;
if(edad > 18){
   Console.WriteLine("Sos mayor");
}
else{
   Console.WriteLine("Sos menor");
}
En este caso, como ahora a edad le asignamos el valor 17, en vez de ir por el verdadero del If, va a ir por el else, o sea, el falso. Tené en cuenta que le asignamos 17 a la
variable. Y qué pasa si le hubiésemos asignado 18? En ese caso qué resultado daría el If, verdadero o falso? Teniendo en cuenta lo que se pregunta específicamente en el If y 
no lo que sepamos de cuándo sos mayor de edad. Si tenés dudas sobre cuál es la respuesta correcta podés probar el código o consultarlo en el Foro de dudas.

Bueno, comenzamos con IF. En realidad en este video primero resolvemos algunos ejercicios anteriores, creo que ya te lo había compartido antes. Pero ahora, lo relevante es el
comienzo de la explicación del condicional IF y comenzar a trabajar con dicha herramienta.


Link de youtube: https://www.youtube.com/watch?v=TTvnrL1KUZM&t=1s


Luego de aprender lo básico, obviamente viene la hora de hacer ejercicios para comenzar a entrenar lo recién visto. Así que acá resolvemos algunos ejercicios. Y desde ya,
seguimos sumando algún que otro dato de color, como también micro temas y datos relevantes!


Link de youtube:https://www.youtube.com/watch?v=6B7oRyWqmxA


Ejercicios 3
Bueno, ya entramos en condicionales, así que ahora sí, vamos a codificar ejercicios con condiciones.
Lean atentamente y codifiquen las soluciones. Si van apareciendo dudas, me van consultando.

1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero”
 si el número es igual a cero.
3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
•	Si el importe es menor a ARS 1000, no hay descuento.
•	Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
•	Si el importe es ARS 5000 o más, aplica un descuento del 18%.
Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.
4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

1)   int numero;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            if(numero > 10) {
                Console.WriteLine("El numero ingresado es mayor a 10");
            }
            else {
                Console.WriteLine("El numero ingresado no es mayor a 10");
            }

        }
    }
}

2)


int positivo;
            Console.WriteLine("Ingrese un numero");
            positivo = int.Parse(Console.ReadLine());
            if (positivo > 0) {
                Console.WriteLine("Positivo");
            }
            if (positivo < 0) {
                Console.WriteLine("Negativo");
            }
            else (positivo == 0) {
                Console.WriteLine("Cero");
            }
3)





int descuento;
            Console.WriteLine("Ingrese el importe");
            descuento = int.Parse(Console.ReadLine());
            if(descuento < 1000) {
                Console.WriteLine(descuento);
            }
            else if(descuento >= 1000 && descuento < 5000) {
                Console.WriteLine(descuento * 0.1);
            }
            else {
                Console.WriteLine(descuento * 0.18);
            }

4)
int n1, n2, n3, n4;
            Console.WriteLine("Ingrese cuatro numeros:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            if(n1 < n2 && n1 < n3 && n1 < n4) {
                Console.WriteLine(n1);
            }
            else if(n2 < n1 && n2 < n3 && n2 < n4) {
                Console.WriteLine(n2);
            }
            else if(n3 < n1 && n3 < n2 && n3 < n4) {
                Console.WriteLine(n3);
            }
            else if(n4 < n1 && n4 < n2 && n4 < n3) {
                Console.WriteLine(n4);
            }

5)
int uno, dos, tres, cuatro;
            Console.WriteLine("Ingrese cuatro numeros:");
            uno = Console.ReadLine();
            dos = Console.ReadLine();
            tres = Console.ReadLine();
            cuatro = Console.ReadLine();
            if(uno > 100) {
                Console.WriteLine(uno);
            }
            else if(dos > 100) {
                Console.WriteLine(dos);
            }
            else if(tres > 100) {
                Console.WriteLine(tres);
            }
            else if(cuatro > 100) {
                Console.WriteLine(cuatro);
            }
            
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


Clase 4:

Módulo 4 - Lectura
En este módulo vamos a ver varias herramientas complementarias a la hora de trabajar con condicionales. 

Ya sabemos cómo trabaja el If y cuál es el modo correcto de construir condiciones lógicas a partir del uso de operadores relacionales. 

Sin embargo, lo que vimos hasta ahora es que cada If puede tener una única condición y que si, por ejemplo, quisiéramos realizar dos preguntas, lo tenemos que hacer en dos Ifs
separados.

Bueno, hay una herramienta que nos brinda la posibilidad de crear más de una condición en un mismo If, y esa herramienta se llama: operador lógico.

Operadores lógicos
Existen dos operadores lógicos, también conocidos como operadores de concatenación lógica.

OR cuyo símbolo corresponde a || (doble pipe).
AND cuyo símbolo corresponde a && (doble ampersand).
AND
El and es el operador "y". Al usar este operador para concatenar dos o más condiciones lógicas, el comportamiento será el siguiente:

si todas las condiciones dan verdadero, entonces el If dará como resultado verdadero.

si una condición da falso, entonces el If dará como resultado falso.

Esto se debe a que al usar el operador AND para concatenar las condiciones, lo que estamos indicando es que queremos que se consulta si se cumple la condición 1 Y se cumple la
condición 2 Y se cumple la condición 3 Y.... etc. Estamos buscando saber si se cumplen todas; con lo cual, si se cumplen todas, dará verdadero PERO, con UNA condición que no se
cumpla, entonces todo el If dará como resultado falso.

OR
Con el operador "o" pasa exactamente lo contrario. Lo que se busca es el verdadero si se cumple la condición 1 o se cumple la condición 2 o se cumple la condición 3 o... etc.
En el caso del operador OR, el resultado será verdadero cuando cualquiera de las condiciones dentro del If de como resultado verdadero. Ahora, cuándo el If se irá hacia el
falso? Cuando todas las condiciones den falso.

NOT
Existe un tercer operador lógico que es el operador de negación, cuyo símbolo es el "!" (signo de admiración). Este operador sirve para invertir (para negar) el resultado de
una condición lógica. De este modo, si la condición diera verdadero, el Not haría que se vaya para el falso.

Por ejemplo:

int a = 10
if(!a==10){
   Console.WriteLine("no es igual a 10");
}
else{
   Console.WriteLine("ES igual a 10");
}
Contadores
Un contador no es más que una variable que vamos a usar para realizar un conteo de algo. Por ejemplo: cuántas personas son mayores de 18, o cuántas personas se sacaron un 10 
en la materia, etc.

Todo conteo comienza desde un valor conocido, generalmente desde cero; es por eso que un de las prácticas a tener en cuenta a la hora de contar es inicializar la variable 
en cero. Inicializar significa dar un valor inicial. De ese modo nos garantizamos que el conteo arranca desde un valor determinado.

Contar es agregarle una unidad a una variable. Esto se puede hacer del siguiente modo:

int a = 0;
a = a + 1;
a = a + 1;
a = a + 1;
Console.WriteLine(a);
Console.ReadLine();
Si se observa, en este caso el valor de "a" comienza en cero y luego se realiza tres veces una suma de una unidad sobre la misma. Esto realiza un efecto de conteo ya que se 
va sumando de a uno. Al final, al mostrar el contenido de "a", el mismo será 3.

La idea de estos conteos es realizarlos, como se mencionó antes, de manera condicional, de modo tal que antes de contar se realizaría una comparación para identificar si hay
que contar o no.

Por ejemplo: evaluar tres edades y mostrar por pantalla cuántas son mayores a 18.

int a = 16, b = 20, c = 33;
int con = 0;
if(a > 18){
   con = con + 1;
}
if(b > 18){
   con = con + 1;
}
if(c > 18){
   con = con + 1;
}
Console.WriteLine("La cantidad de mayores es: " + con);
Console.ReadLine();
En este caso, el resultado por pantalla sería 2.

Operador de incremento
Existe un operador que nos permite simplificar el conteo aplicado a una variable. Ese operador se denomina operador de incremento, cuyo símbolo se representa con un doble más:
++

Con este operador, pasamos de tener

con = con + 1
a tener simplemente 

con++
El ++ lo que hará es incrementar una unidad a cualquiera sea la variable y contenido que tenga a su izquierda. También existe su contraparte que corresponde a "--" (menos
menos) que lo que hace es exactamente lo opuesto: disminuir una unidad de la variable a la que se asigne.

Nótese que en este caso no aplica el uso de la asignación (operador =), ya que la misma se desarrolla de manera implícita.

Acumuladores
Un acumulador funciona de manera similar a un contador. La diferencia es que en este caso no se suma de a una unidad sino que se suman distintos valores y lo que escriba, se
irá agregando a lo ya existente. Por ejemplo:

int a = 0;
a = a + 10;
a = a + 3;
a = a + 5;
Console.WriteLine(a);
Console.ReadLine();
En este caso el resultado en pantalla será 18, la suma de todos los valores.

De la misma manera que el conteo, los acumuladores se suelen usar condicionalmente; y también contamos con un operador especial para resumir la instrucción. El operador de
acumulación: +=.

De este modo, pasamos de tener:

a = a + 10;
a tener

a+=10;
Son instrucciones que hace exactamente lo mismo, pero de una manera más compacta de escribir. También existe el operador para disminuir, y el mismo es el "-=".

El Switch
El switch es una herramienta de decisión que nos permite evaluar el contenido de una variable u operación y, a diferencia del If que nos permite solo una de dos opciones
posibles (verdadero o falso), nos permite setear múltiples opciones posibles para el valor que se esté evaluando. Desde ya que una vez decidido el valor, se ejecutará un solo
camino como también sucede con el If.

La diferencia principal, además de la cantidad de opciones, es que e switch no hace uso de los operadores relacionales. Simplemente se evalúa un valor y se elige un camino
posible dependiendo de lo que se haya evaluado.

Por ejemplo: haremos un switch que reciba una variable y si la misma contiene un 1, mostrar Hola en pantalla, si tiene 2, mostrar Chau, si tiene 3 mostrar Blanco y si tiene 4
mostrar Negro.

int a = 3;
Switch(a){
case 1: 
Console.WriteLine("Hola");
break;
case 2:
Console.WriteLine("Chau");
break;
case 3:
Console.WriteLine("Blanco");
break;
case 4:
Console.WriteLine("Negro");
break;
default:
Console.WriteLine("Opción incorrecta");
break;
}
Console.ReadLine();
Este programa muestra por pantalla "Blanco", como pueden ver (también pueden copiar y probar el código en ejecución). Pueden ver dos particularidades: por un lado, contamos
dentro de cada "case" el valor posible. En este caso cada "case" es cada brazo del Switch. Pero además, cada case al final cuenta con un break, que determina el final del
mismo. Por otro lado, contamos con un último "case" denominado "default", que es por donde pasará la ejecución si el valor contenido en la variable que está siendo analizada 
no se corresponde con ninguna de las opciones seteadas.


Videos 4
En este video seguimos resolviendo ejercicios pero en este caso sumando unos detalles más: los operadores lógicos, o concatenadores lógicos OR y AND (|| y && respectivamente).

Además sumamos los conceptos de Acumulador y Contador.

https://www.youtube.com/watch?v=cwonYFylSVk

Resolvemos algunos ejercicios haciendo uso de estos conceptos; https://www.youtube.com/watch?v=Ck_AlU2x5nc

Y finalmente, para cerrar la unidad de Condicionales 2, vemos una nueva herramienta: El Switch.

https://www.youtube.com/watch?v=6hj-3F-s6ks


Ejercicios 4
Bueno, ya entramos en condicionales, así que ahora sí, vamos a codificar ejercicios con condiciones.

Lean atentamente y codifiquen las soluciones. Si van apareciendo dudas, me van consultando.

1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

La resta si el primero es mayor que el segundo.
La suma si son iguales.
El producto si el primero es menor.
Se deberá emitir un cartel por pantalla con el resultado correspondiente.

2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

Si vende menos de 100 litros, no hay descuento.
Si vende entre 101 y 300 litros, el descuento es del 10%.
Si vende entre 301 y 500 litros, el descuento es del 15%.
Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

i5 (1)	i7 (2)	i9 (3)
8 RAM (1)	USD 800	USD 900	USD 1200
16 RAM (2)	USD 900	USD 1000	USD 1400
32 RAM (3)	USD 1000	USD 1400	USD 2000
Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300.
Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita
por pantalla el monto de la máquina seleccionada.

4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Clase 5:

Módulo 5 - Lectura

Ciclos
Un ciclo es una herramienta de la programación que nos permite repetir la ejecución de cierta instrucción o cierto conjunto de instrucciones tantas veces como necesitemos. 

Es decir, al día de hoy, si quisiéramos mostrar un cartel "Hola mundo" en la pantalla 5 veces, podemos, pero tendríamos que hacer lo siguiente:

Console.WriteLine("Hola mundo");
Console.WriteLine("Hola mundo");
Console.WriteLine("Hola mundo");
Console.WriteLine("Hola mundo");
Console.WriteLine("Hola mundo");


Es decir, escribir cinco veces la misma línea de código. Con un ciclo (también conocidos como bucles) puedo programar escribir esa instrucción una sola vez pero que se ejecute
cinco veces. O las veces que necesite. 


Ciclo For
Hay distintos tipos de ciclos, vamos a comenzar con el ciclo exacto: el ciclo FOR.

El FOR es un ciclo que nos permite ejecutar un conjunto de instrucciones una cantidad de veces establecida. Por ejemplo cinco. Por ejemplo diez. De allí su calificación de
"ciclo exacto", porque dará exactamente la cantidad de vueltas que esté configurado para dar.

Para configurar un ciclo FOR vamos a necesitar contar con una variable, generalmente se usa como nombre para dicha variable las letras "x", "y" o "z" aunque también encontrarán
muy frecuentemente que la variable del FOR se denomina "i" (de "iterar", que significa ciclar, o dar una vuelta al ciclo).

Una vez con la variable hay tres factores que se requiere configurar en un ciclo:

Inicialización.
Condición.
Incremento.
Cada una de estas acciones ya son conocidas por separado, pero en este caso van a estar trabajando en conjunto para poder configurar lo que se denomina "reloj" del ciclo y que
será lo que permita el funcionamiento del mecanismo del mismo.

Inicialización
Se trata de dar un valor inicial a la variable del ciclo. Esta instrucción se ejecutará una sola vez en toda la vida del ciclo y es para darle un punto de partida al mismo. Se
puede inicializar en cualquier valor, incluso en el valor de otra variable, aunque en una configuración regular, se suele incializar simplemente en cero.

Condición
La condición es la instrucción que determinará si se sigue iterando o no. Se ejecuta previo a comenzar cada vuelta del ciclo y si da verdadero, se ejecuta la vuelta. Cuando sea
falso, se dará por terminado el ciclo. Aquí se puede asignar cualquier condición válida para un IF, ya que manejan exactamente el mismo formato, incluso se pueden agregar
operadores lógicos. En una configuración regular se suele hacer una comparación del tipo "menor a" el valor cuya cantidad de vueltas se quiere dar. Por ejemplo "x < 5" si
quiero dar cinco vueltas.

Incremento
El incremento es la instrucción que se encargará de modificar el valor de la variable del ciclo para que, eventualmente, la condición dé falso y el ciclo pueda concluir. De
otro modo, la condición dará siempre verdadero y el ciclo no terminaría, lo que sería un problema (se conoce como ciclo que tiende a infinito). Generalmente se utiliza un
incremento de a una unidad (x++) aunque también puede variar.

Funcionamiento
Cuando la ejecución de un programa se encuentra con un ciclo, lo primero que hace es reconocer cuál es la variable del mismo. Lo siguiente, y por única vez, es ejecutar la
inicialización. Luego de eso ejecuta la condición y si la misma da verdadero, ingresa al ciclo y ejecuta todo lo que haya dentro. Dentro del ciclo pueden haber tantas
instrucciones como necesitemos, incluso otros ciclos, pero esto lo veremos más adelante. Luego de haber ejecutado todas las instrucciones dentro del ciclo y haber llegado al
final del mismo, el próximo paso es el incremento. Una vez realizado, se vuelve a evaluar la condición, y si sigue dando verdadero, sigue entrando al ciclo. Así hasta que la
condición por fin dé falso.

Como se ha dicho antes, cada una de las configuraciones cuenta con lo que llamaremos "configuración estándar", sin embargo se puede establecer valores de cualquier tipo en cada
una de ellas siempre y cuando se cumpla con la estructura respectiva. Hay que tener en cuenta que la cantidad de vueltas que dará el ciclo depende directamente de la
configuración de su reloj, con lo cual tenemos que tener muy claro qué es lo que estamos configurando y por qué.

Configuración estándar
Si queremos que un ciclo de diez vueltas, la configuración más sencilla sería:

x = 0
x < 10
x++
Donde "x" arranca en cero, y en cada vuelta se preguntará si "x" es menor a diez. Mientras sea, se ingresa y se da una vuelta. Al final de cada vuelta se incrementará el valor
de "x" en uno.

Ejemplo en código
Hagamos en código el ejemplo de mostrar cinco veces el hola mundo pero escribiendo una sola vez dicha instrucción:

for(x = 0; x < 5; x++){
   Console.WriteLine("Hola mundo");
}


Link de youtube: https://www.youtube.com/watch?v=v3rHho4ticQ


Ciclo While
Ya conocemos el Ciclo FOR. El mismo nos permite, a partir de una configuración previamente establecida, repetir un conjunto de instrucciones siempre y cuando conozcamos la
cantidad de veces que necesitamos que el mismo se ejecute. Hay ocasiones en las que no se conocerá la cantidad de veces que un algoritmo deberá ser ejecutado; en dichos casos
se utiliza otro tipo de ciclo, denominado ciclo inexacto, que repetirá el conjunto de instrucciones dado dependiendo de una condición establecida. Existen básicamente dos tipos
de ciclos inexactos en la programación. Por un lado el While y por otro lado en Do While.

El ciclo While (del inglés “mientras”) comenzará a ciclar siempre y cuando la condición dada sea verdadera, y seguirá ciclando hasta tanto esa situación no cambie.

int N = 0;
while(n<10){
   n++;
   Console.WriteLine(n);
}
En el ejemplo se declara una variable inicializada en cero. Cuando el flujo se encuentra con el ciclo While, lo primero que se hace es evaluar la condición: “El contenido de la
variable, es menor a diez?”. Naturalmente en este momento la condición tiene como resultado un valor “TRUE”. Recordemos que una condición de este tipo puede adoptar sólo uno de
dos valores (true o false. 1 o 0, etc.). Una vez dentro del ciclo, se ejecutan las instrucciones. Se incrementa el valor de la variable y se muestra en pantalla. Una vez
concluías estas dos instrucciones, se evaluará la condición nuevamente. El ciclo del ejemplo dejará de girar cuando la variable “N” sea igual a 10 (diez).

Ciclo Do While

Este ciclo funciona casi de la misma manera que el ciclo While tradicional. La diferencia fundamental es que la primer vuelta se ejecutará siempre, y recién para la segunda es
que la condición será evaluada para determinar si continuar ciclando o concluir el bloque. Un ejemplo codificado sería:

int N = 0;
do{
   n++;
}while(n<10)


Link de youtube: https://www.youtube.com/watch?v=HSUKndu5XAg


Videos
Muchachada, en este video aprendemos qué es el ciclo FOR, cómo funciona, para qué sirve y varios ejemplos de su funcionamiento!
Mirenlo, lean el apunte de la unidad, y arranquen a hacer los ejercicios de la guía 3


Arrancamos con ciclos! En el siguiente video vemos en qué consiste el ciclo FOR y cómo funciona paso a paso y súper detallado.


Link de youtube: https://www.youtube.com/watch?v=v3rHho4ticQ


Luego de entenderlo, vemos varios ejercicios para seguir mejorando la idea de iterar instrucciones.


Link de youtube: https://www.youtube.com/watch?v=XXyXv6DR1xA


Link de youtube: https://www.youtube.com/watch?v=AsRQmd9y6i8


Link de youtube: https://www.youtube.com/watch?v=HSUKndu5XAg


Link de youtube: https://www.youtube.com/watch?v=BX5DYuPfhOo

Módulo 5 - Videos While
Gente, aquí va la explicación en video del ciclo inexacto While. 

https://www.youtube.com/watch?v=HSUKndu5XAg

Bueno, ejercicios resueltos de While. En este caso en un único video, pero punteado ejercicio por ejercicio. Muy importante para ver cómo se abordan, qué particularidades tener en cuenta y demás. A revisar!

Lista de ejercicios del video:

00:00 👉Inicio
03:00 👉 Ejercicio 1. Números 1 al 10.
06:22 👉 Ejercicio 2. Números 10 a 1.
07:33 👉 Ejercicio 3. Contador.
09:57 👉 Ejercicio 4. Números entre el menor y el mayor.
12:58 👉 Ejercicio 5. 1 a 100 de 5 en 5.
13:59 👉 Ejercicio 6. Primo con While.
16:01 👉 Ejercicio 7. Máximo y Posición. Cantidad de oros variable.
21:50 👉 Ejercicio 8. Menor y segundo menor.
31:43   👉 Ejercicio 9. Menor, segundo menor y sus posiciones.
38:51 👉 Ejercicio 10. Máximo negativo, mínimo positivo. BANDERA.
45:08 👉 Ejercicio 11. Contador. Ciclo dentro de ciclo.

https://www.youtube.com/watch?v=BX5DYuPfhOo

Ejercicios 5
Comencemos a practicar con ciclos entonces!

Recordá siempre leer atentamente lo que se pide en la consigna. Las consignas son cada vez más complejas, con lo cual seguramente vayan necesitando más lectura. Es decir, no
alcanza con leer la consigna una sola vez para terminar de entender lo que pide. Puede que tengas que leerlas 5, 10, 15 veces o más. No te preocupes, hay que hacerlo!



1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.

2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible
 únicamente por 1 y por sí mismo.

5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Clase 6:

Bueno, comenzamos a trabajar con ciclos combinados y aquí les dejo una explicación con diagramas para que vean un poco más al respecto, además con algunos ejemplos adicionales

https://www.youtube.com/watch?v=BX5DYuPfhOo&list=PLQRFzsIQFmxrqL5ViA0k3rsR5H0oNKYxE&index=15


Corte de control

Este tema es algo que no vamos a ver en este curso, pero que si tienen ganas y tiempo para ampliar sobre esto, les va a aportar bastante. Corte de control es básicamente una
"estrategia" de manejo de datos a partir del uso de ciclos combinados. Les dejo un video en el que lo explico en detalle y, también, con varios ejemplos. Esto es un tema
exclusivo que se suele ver en las carreras en la universidad.

https://www.youtube.com/watch?v=VOjsn9liLKo&list=PLQRFzsIQFmxrqL5ViA0k3rsR5H0oNKYxE&index=18

Finalmente, como siempre, una serie de ejercicios resueltos para ir viendo cómo es la cuestión. Pueden verlos, analizarlos, llevarlos al código y chequear su funcionamiento.

https://www.youtube.com/watch?v=HnFENssh9-I&list=PLQRFzsIQFmxrqL5ViA0k3rsR5H0oNKYxE&index=19

Ejercicios 6
Les dejo algunos ejercicios de ciclos combinados. Ya son un poco más largos y complejos, así que serán menos así tratan de hacerlos en la semana. Lo que sí, analicen bien ya que tendrán que determinar qué tipo de combinación de ciclos deben aplicar, es decir, si for con for, o for con while, etc.

1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

https://www.youtube.com/watch?v=k12fjsyjah0 Ejercicio 1

https://www.youtube.com/watch?v=VVictUqVRtI Ejercicio 2

https://www.youtube.com/watch?v=efe2ud9rT7k Ejercicio 3

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Clase 7:

Vectores
Comenzamos con Vectores. Un tipo de variable especial, dimensional, que nos permite guardar muchos valores bajo un mismo pseudónimo de variable...

https://www.youtube.com/watch?v=B-KRYhDRnt0

Ejercicios resueltos
Como siempre, una serie de ejercicios para practicar lo aprendido.
00:00 Inicio.
01:10 Ejercicio 1. Guardar 10 números y mostrar la suma.
06:07 Ejercicio 2. Guardar 50 números. Buscar máximo y posición.
10:00 Ejercicio 3. Guardar 100 números. Calcular promedio, mostrar los mayores.
12:30 Ejercicio 4. Guardar 20 números. Determinar si está ordenado.
16:58 Ejercicio 5. Vector de valores Char. Intercambiar caracteres dados.
30:12 Ejercicio 6. Guardar 10 números y buscar repetidos.
37:23 Ejercicio 7. Registros de ventas. Lote y puntos a, b y c.
57:32 Ejercicio 8. Ordenar Vector.

https://www.youtube.com/watch?v=AYVpDkVMdVg

https://www.youtube.com/watch?v=-MywsWPHmSI

Array Class
Definition
Namespace:
System
Assembly:
System.Runtime.dll
Provides methods for creating, manipulating, searching, and sorting arrays, thereby serving as the base class for all arrays in the common language runtime.

C#

Copy
public abstract class Array : ICloneable, System.Collections.IList, System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable
Inheritance
Object
Array
Implements
ICollection  IEnumerable  IList  IStructuralComparable  IStructuralEquatable  ICloneable
Examples
The following code example shows how Array.Copy copies elements between an array of type integer and an array of type Object.

C#

Copy

Run
using System;
public class SamplesArray
{

    public static void Main()
    {

        // Creates and initializes a new integer array and a new Object array.
        int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
        Object[] myObjArray = new Object[5] { 26, 27, 28, 29, 30 };

        // Prints the initial values of both arrays.
        Console.WriteLine("Initially,");
        Console.Write("integer array:");
        PrintValues(myIntArray);
        Console.Write("Object array: ");
        PrintValues(myObjArray);

        // Copies the first two elements from the integer array to the Object array.
        System.Array.Copy(myIntArray, myObjArray, 2);

        // Prints the values of the modified arrays.
        Console.WriteLine("\nAfter copying the first two elements of the integer array to the Object array,");
        Console.Write("integer array:");
        PrintValues(myIntArray);
        Console.Write("Object array: ");
        PrintValues(myObjArray);

        // Copies the last two elements from the Object array to the integer array.
        System.Array.Copy(myObjArray, myObjArray.GetUpperBound(0) - 1, myIntArray, myIntArray.GetUpperBound(0) - 1, 2);

        // Prints the values of the modified arrays.
        Console.WriteLine("\nAfter copying the last two elements of the Object array to the integer array,");
        Console.Write("integer array:");
        PrintValues(myIntArray);
        Console.Write("Object array: ");
        PrintValues(myObjArray);
    }

    public static void PrintValues(Object[] myArr)
    {
        foreach (Object i in myArr)
        {
            Console.Write("\t{0}", i);
        }
        Console.WriteLine();
    }

    public static void PrintValues(int[] myArr)
    {
        foreach (int i in myArr)
        {
            Console.Write("\t{0}", i);
        }
        Console.WriteLine();
    }
}
/*
This code produces the following output.

Initially,
integer array:  1       2       3       4       5
Object array:   26      27      28      29      30

After copying the first two elements of the integer array to the Object array,
integer array:  1       2       3       4       5
Object array:   1       2       28      29      30

After copying the last two elements of the Object array to the integer array,
integer array:  1       2       3       29      30
Object array:   1       2       28      29      30
*/
The following code example creates and initializes an Array and displays its properties and its elements.

C#

Copy

Run
// Creates and initializes a new three-dimensional Array of type int.
Array myArr = Array.CreateInstance(typeof(int), 2, 3, 4);
for (int i = myArr.GetLowerBound(0); i <= myArr.GetUpperBound(0); i++)
{
    for (int j = myArr.GetLowerBound(1); j <= myArr.GetUpperBound(1); j++)
    {
        for (int k = myArr.GetLowerBound(2); k <= myArr.GetUpperBound(2); k++)
        {
            myArr.SetValue((i * 100) + (j * 10) + k, i, j, k);
        }
    }
}

// Displays the properties of the Array.
Console.WriteLine("The Array has {0} dimension(s) and a total of {1} elements.", myArr.Rank, myArr.Length);
Console.WriteLine("\tLength\tLower\tUpper");
for (int i = 0; i < myArr.Rank; i++)
{
    Console.Write("{0}:\t{1}", i, myArr.GetLength(i));
    Console.WriteLine("\t{0}\t{1}", myArr.GetLowerBound(i), myArr.GetUpperBound(i));
}

// Displays the contents of the Array.
Console.WriteLine("The Array contains the following values:");
PrintValues(myArr);

void PrintValues(Array myArray)
{
    System.Collections.IEnumerator myEnumerator = myArray.GetEnumerator();
    int i = 0;
    int cols = myArray.GetLength(myArray.Rank - 1);
    while (myEnumerator.MoveNext())
    {
        if (i < cols)
        {
            i++;
        }
        else
        {
            Console.WriteLine();
            i = 1;
        }
        Console.Write("\t{0}", myEnumerator.Current);
    }
    Console.WriteLine();
}
// This code produces the following output.

// The Array has 3 dimension(s) and a total of 24 elements.
//     Length    Lower    Upper
// 0:  2    0    1
// 1:  3    0    2
// 2:  4    0    3
//
// The Array contains the following values:
//    0      1      2      3
//    10     11     12     13
//    20     21     22     23
//    100    101    102    103
//    110    111    112    113
//    120    121    122    123
Remarks
The Array class is not part of the System.Collections namespaces. However, it is still considered a collection because it is based on the IList interface.

The Array class is the base class for language implementations that support arrays. However, only the system and compilers can derive explicitly from the Array class. Users should employ the array constructs provided by the language.

An element is a value in an Array. The length of an Array is the total number of elements it can contain. The lower bound of an Array is the index of its first element. An Array can have any lower bound, but it has a lower bound of zero by default. A different lower bound can be defined when creating an instance of the Array class using CreateInstance. A multidimensional Array can have different bounds for each dimension. An array can have a maximum of 32 dimensions.

Unlike the classes in the System.Collections namespaces, Array has a fixed capacity. To increase the capacity, you must create a new Array object with the required capacity, copy the elements from the old Array object to the new one, and delete the old Array.

The array size is limited to a total of 4 billion elements, and to a maximum index of 0X7FEFFFFF in any given dimension (0X7FFFFFC7 for byte arrays and arrays of single-byte structures).

.NET Framework only: By default, the maximum size of an Array is 2 gigabytes (GB). In a 64-bit environment, you can avoid the size restriction by setting the enabled attribute of the gcAllowVeryLargeObjects configuration element to true in the run-time environment.

Single-dimensional arrays implement the System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IReadOnlyList<T> and System.Collections.Generic.IReadOnlyCollection<T> generic interfaces. The implementations are provided to arrays at run time, and as a result, the generic interfaces do not appear in the declaration syntax for the Array class. In addition, there are no reference topics for interface members that are accessible only by casting an array to the generic interface type (explicit interface implementations). The key thing to be aware of when you cast an array to one of these interfaces is that members which add, insert, or remove elements throw NotSupportedException.

Type objects provide information about array type declarations. Array objects with the same array type share the same Type object.

Type.IsArray and Type.GetElementType might not return the expected results with Array because if an array is cast to the type Array, the result is an object, not an array. That is, typeof(System.Array).IsArray returns false, and typeof(System.Array).GetElementType returns null.

The Array.Copy method copies elements not only between arrays of the same type but also between standard arrays of different types; it handles type casting automatically.

Some methods, such as CreateInstance, Copy, CopyTo, GetValue, and SetValue, provide overloads that accept 64-bit integers as parameters to accommodate large capacity arrays. LongLength and GetLongLength return 64-bit integers indicating the length of the array.

The Array is not guaranteed to be sorted. You must sort the Array prior to performing operations (such as BinarySearch) that require the Array to be sorted.

Using an Array object of pointers in native code is not supported and will throw a NotSupportedException for several methods.

Properties
PROPERTIES
IsFixedSize	
Gets a value indicating whether the Array has a fixed size.

IsReadOnly	
Gets a value indicating whether the Array is read-only.

IsSynchronized	
Gets a value indicating whether access to the Array is synchronized (thread safe).

Length	
Gets the total number of elements in all the dimensions of the Array.

LongLength	
Gets a 64-bit integer that represents the total number of elements in all the dimensions of the Array.

Rank	
Gets the rank (number of dimensions) of the Array. For example, a one-dimensional array returns 1, a two-dimensional array returns 2, and so on.

SyncRoot	
Gets an object that can be used to synchronize access to the Array.

Methods
METHODS
AsReadOnly<T>(T[])	
Returns a read-only wrapper for the specified array.

BinarySearch(Array, Int32, Int32, Object)	
Searches a range of elements in a one-dimensional sorted array for a value, using the IComparable interface implemented by each element of the array and by the specified value.

BinarySearch(Array, Int32, Int32, Object, IComparer)	
Searches a range of elements in a one-dimensional sorted array for a value, using the specified IComparer interface.

BinarySearch(Array, Object)	
Searches an entire one-dimensional sorted array for a specific element, using the IComparable interface implemented by each element of the array and by the specified object.

BinarySearch(Array, Object, IComparer)	
Searches an entire one-dimensional sorted array for a value using the specified IComparer interface.

BinarySearch<T>(T[], Int32, Int32, T)	
Searches a range of elements in a one-dimensional sorted array for a value, using the IComparable<T> generic interface implemented by each element of the Array and by the specified value.

BinarySearch<T>(T[], Int32, Int32, T, IComparer<T>)	
Searches a range of elements in a one-dimensional sorted array for a value, using the specified IComparer<T> generic interface.

BinarySearch<T>(T[], T)	
Searches an entire one-dimensional sorted array for a specific element, using the IComparable<T> generic interface implemented by each element of the Array and by the specified object.

BinarySearch<T>(T[], T, IComparer<T>)	
Searches an entire one-dimensional sorted array for a value using the specified IComparer<T> generic interface.

Clear(Array, Int32, Int32)	
Sets a range of elements in an array to the default value of each element type.

Clone()	
Creates a shallow copy of the Array.

ConstrainedCopy(Array, Int32, Array, Int32, Int32)	
Copies a range of elements from an Array starting at the specified source index and pastes them to another Array starting at the specified destination index. Guarantees that all changes are undone if the copy does not succeed completely.

ConvertAll<TInput,TOutput>(TInput[], Converter<TInput,TOutput>)	
Converts an array of one type to an array of another type.

Copy(Array, Array, Int32)	
Copies a range of elements from an Array starting at the first element and pastes them into another Array starting at the first element. The length is specified as a 32-bit integer.

Copy(Array, Array, Int64)	
Copies a range of elements from an Array starting at the first element and pastes them into another Array starting at the first element. The length is specified as a 64-bit integer.

Copy(Array, Int32, Array, Int32, Int32)	
Copies a range of elements from an Array starting at the specified source index and pastes them to another Array starting at the specified destination index. The length and the indexes are specified as 32-bit integers.

Copy(Array, Int64, Array, Int64, Int64)	
Copies a range of elements from an Array starting at the specified source index and pastes them to another Array starting at the specified destination index. The length and the indexes are specified as 64-bit integers.

CopyTo(Array, Int32)	
Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 32-bit integer.

CopyTo(Array, Int64)	
Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 64-bit integer.

CreateInstance(Type, Int32)	
Creates a one-dimensional Array of the specified Type and length, with zero-based indexing.

CreateInstance(Type, Int32, Int32)	
Creates a two-dimensional Array of the specified Type and dimension lengths, with zero-based indexing.

CreateInstance(Type, Int32, Int32, Int32)	
Creates a three-dimensional Array of the specified Type and dimension lengths, with zero-based indexing.

CreateInstance(Type, Int32[])	
Creates a multidimensional Array of the specified Type and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 32-bit integers.

CreateInstance(Type, Int32[], Int32[])	
Creates a multidimensional Array of the specified Type and dimension lengths, with the specified lower bounds.

CreateInstance(Type, Int64[])	
Creates a multidimensional Array of the specified Type and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 64-bit integers.

Empty<T>()	
Returns an empty array.

Equals(Object)	
Determines whether the specified object is equal to the current object.

(Inherited from Object)
Exists<T>(T[], Predicate<T>)	
Determines whether the specified array contains elements that match the conditions defined by the specified predicate.

Fill<T>(T[], T)	
Assigns the given value of type T to each element of the specified array.

Fill<T>(T[], T, Int32, Int32)	
Assigns the given value of type T to the elements of the specified array which are within the range of startIndex (inclusive) and the next count number of indices.

Find<T>(T[], Predicate<T>)	
Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire Array.

FindAll<T>(T[], Predicate<T>)	
Retrieves all the elements that match the conditions defined by the specified predicate.

FindIndex<T>(T[], Int32, Int32, Predicate<T>)	
Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the Array that starts at the specified index and contains the specified number of elements.

FindIndex<T>(T[], Int32, Predicate<T>)	
Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the Array that extends from the specified index to the last element.

FindIndex<T>(T[], Predicate<T>)	
Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the entire Array.

FindLast<T>(T[], Predicate<T>)	
Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence within the entire Array.

FindLastIndex<T>(T[], Int32, Int32, Predicate<T>)	
Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the Array that contains the specified number of elements and ends at the specified index.

FindLastIndex<T>(T[], Int32, Predicate<T>)	
Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the Array that extends from the first element to the specified index.

FindLastIndex<T>(T[], Predicate<T>)	
Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the entire Array.

ForEach<T>(T[], Action<T>)	
Performs the specified action on each element of the specified array.

GetEnumerator()	
Returns an IEnumerator for the Array.

GetHashCode()	
Serves as the default hash function.

(Inherited from Object)
GetLength(Int32)	
Gets a 32-bit integer that represents the number of elements in the specified dimension of the Array.

GetLongLength(Int32)	
Gets a 64-bit integer that represents the number of elements in the specified dimension of the Array.

GetLowerBound(Int32)	
Gets the index of the first element of the specified dimension in the array.

GetType()	
Gets the Type of the current instance.

(Inherited from Object)
GetUpperBound(Int32)	
Gets the index of the last element of the specified dimension in the array.

GetValue(Int32)	
Gets the value at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.

GetValue(Int32, Int32)	
Gets the value at the specified position in the two-dimensional Array. The indexes are specified as 32-bit integers.

GetValue(Int32, Int32, Int32)	
Gets the value at the specified position in the three-dimensional Array. The indexes are specified as 32-bit integers.

GetValue(Int32[])	
Gets the value at the specified position in the multidimensional Array. The indexes are specified as an array of 32-bit integers.

GetValue(Int64)	
Gets the value at the specified position in the one-dimensional Array. The index is specified as a 64-bit integer.

GetValue(Int64, Int64)	
Gets the value at the specified position in the two-dimensional Array. The indexes are specified as 64-bit integers.

GetValue(Int64, Int64, Int64)	
Gets the value at the specified position in the three-dimensional Array. The indexes are specified as 64-bit integers.

GetValue(Int64[])	
Gets the value at the specified position in the multidimensional Array. The indexes are specified as an array of 64-bit integers.

IndexOf(Array, Object)	
Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.

IndexOf(Array, Object, Int32)	
Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its first occurrence. The range extends from a specified index to the end of the array.

IndexOf(Array, Object, Int32, Int32)	
Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of ifs first occurrence. The range extends from a specified index for a specified number of elements.

IndexOf<T>(T[], T)	
Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.

IndexOf<T>(T[], T, Int32)	
Searches for the specified object in a range of elements of a one dimensional array, and returns the index of its first occurrence. The range extends from a specified index to the end of the array.

IndexOf<T>(T[], T, Int32, Int32)	
Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its first occurrence. The range extends from a specified index for a specified number of elements.

Initialize()	
Initializes every element of the value-type Array by calling the parameterless constructor of the value type.

LastIndexOf(Array, Object)	
Searches for the specified object and returns the index of the last occurrence within the entire one-dimensional Array.

LastIndexOf(Array, Object, Int32)	
Searches for the specified object and returns the index of the last occurrence within the range of elements in the one-dimensional Array that extends from the first element to the specified index.

LastIndexOf(Array, Object, Int32, Int32)	
Searches for the specified object and returns the index of the last occurrence within the range of elements in the one-dimensional Array that contains the specified number of elements and ends at the specified index.

LastIndexOf<T>(T[], T)	
Searches for the specified object and returns the index of the last occurrence within the entire Array.

LastIndexOf<T>(T[], T, Int32)	
Searches for the specified object and returns the index of the last occurrence within the range of elements in the Array that extends from the first element to the specified index.

LastIndexOf<T>(T[], T, Int32, Int32)	
Searches for the specified object and returns the index of the last occurrence within the range of elements in the Array that contains the specified number of elements and ends at the specified index.

MemberwiseClone()	
Creates a shallow copy of the current Object.

(Inherited from Object)
Resize<T>(T[], Int32)	
Changes the number of elements of a one-dimensional array to the specified new size.

Reverse(Array)	
Reverses the sequence of the elements in the entire one-dimensional Array.

Reverse(Array, Int32, Int32)	
Reverses the sequence of a subset of the elements in the one-dimensional Array.

Reverse<T>(T[])	
Reverses the sequence of the elements in the one-dimensional generic array.

Reverse<T>(T[], Int32, Int32)	
Reverses the sequence of a subset of the elements in the one-dimensional generic array.

SetValue(Object, Int32)	
Sets a value to the element at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.

SetValue(Object, Int32, Int32)	
Sets a value to the element at the specified position in the two-dimensional Array. The indexes are specified as 32-bit integers.

SetValue(Object, Int32, Int32, Int32)	
Sets a value to the element at the specified position in the three-dimensional Array. The indexes are specified as 32-bit integers.

SetValue(Object, Int32[])	
Sets a value to the element at the specified position in the multidimensional Array. The indexes are specified as an array of 32-bit integers.

SetValue(Object, Int64)	
Sets a value to the element at the specified position in the one-dimensional Array. The index is specified as a 64-bit integer.

SetValue(Object, Int64, Int64)	
Sets a value to the element at the specified position in the two-dimensional Array. The indexes are specified as 64-bit integers.

SetValue(Object, Int64, Int64, Int64)	
Sets a value to the element at the specified position in the three-dimensional Array. The indexes are specified as 64-bit integers.

SetValue(Object, Int64[])	
Sets a value to the element at the specified position in the multidimensional Array. The indexes are specified as an array of 64-bit integers.

Sort(Array)	
Sorts the elements in an entire one-dimensional Array using the IComparable implementation of each element of the Array.

Sort(Array, Array)	
Sorts a pair of one-dimensional Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the IComparable implementation of each key.

Sort(Array, Array, IComparer)	
Sorts a pair of one-dimensional Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the specified IComparer.

Sort(Array, Array, Int32, Int32)	
Sorts a range of elements in a pair of one-dimensional Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the IComparable implementation of each key.

Sort(Array, Array, Int32, Int32, IComparer)	
Sorts a range of elements in a pair of one-dimensional Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the specified IComparer.

Sort(Array, IComparer)	
Sorts the elements in a one-dimensional Array using the specified IComparer.

Sort(Array, Int32, Int32)	
Sorts the elements in a range of elements in a one-dimensional Array using the IComparable implementation of each element of the Array.

Sort(Array, Int32, Int32, IComparer)	
Sorts the elements in a range of elements in a one-dimensional Array using the specified IComparer.

Sort<T>(T[])	
Sorts the elements in an entire Array using the IComparable<T> generic interface implementation of each element of the Array.

Sort<T>(T[], Comparison<T>)	
Sorts the elements in an Array using the specified Comparison<T>.

Sort<T>(T[], IComparer<T>)	
Sorts the elements in an Array using the specified IComparer<T> generic interface.

Sort<T>(T[], Int32, Int32)	
Sorts the elements in a range of elements in an Array using the IComparable<T> generic interface implementation of each element of the Array.

Sort<T>(T[], Int32, Int32, IComparer<T>)	
Sorts the elements in a range of elements in an Array using the specified IComparer<T> generic interface.

Sort<TKey,TValue>(TKey[], TValue[])	
Sorts a pair of Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the IComparable<T> generic interface implementation of each key.

Sort<TKey,TValue>(TKey[], TValue[], IComparer<TKey>)	
Sorts a pair of Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the specified IComparer<T> generic interface.

Sort<TKey,TValue>(TKey[], TValue[], Int32, Int32)	
Sorts a range of elements in a pair of Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the IComparable<T> generic interface implementation of each key.

Sort<TKey,TValue>(TKey[], TValue[], Int32, Int32, IComparer<TKey>)	
Sorts a range of elements in a pair of Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the specified IComparer<T> generic interface.

ToString()	
Returns a string that represents the current object.

(Inherited from Object)
TrueForAll<T>(T[], Predicate<T>)	
Determines whether every element in the array matches the conditions defined by the specified predicate.

Explicit Interface Implementations
EXPLICIT INTERFACE IMPLEMENTATIONS
ICollection.Count	
Gets the number of elements contained in the Array.

IList.Add(Object)	
Calling this method always throws a NotSupportedException exception.

IList.Clear()	
Removes all items from the IList.

IList.Contains(Object)	
Determines whether an element is in the IList.

IList.IndexOf(Object)	
Determines the index of a specific item in the IList.

IList.Insert(Int32, Object)	
Inserts an item to the IList at the specified index.

IList.Item[Int32]	
Gets or sets the element at the specified index.

IList.Remove(Object)	
Removes the first occurrence of a specific object from the IList.

IList.RemoveAt(Int32)	
Removes the IList item at the specified index.

IStructuralComparable.CompareTo(Object, IComparer)	
Determines whether the current collection object precedes, occurs in the same position as, or follows another object in the sort order.

IStructuralEquatable.Equals(Object, IEqualityComparer)	
Determines whether an object is equal to the current instance.

IStructuralEquatable.GetHashCode(IEqualityComparer)	
Returns a hash code for the current instance.

Extension Methods
EXTENSION METHODS
Cast<TResult>(IEnumerable)	
Casts the elements of an IEnumerable to the specified type.

OfType<TResult>(IEnumerable)	
Filters the elements of an IEnumerable based on a specified type.

AsParallel(IEnumerable)	
Enables parallelization of a query.

AsQueryable(IEnumerable)	
Converts an IEnumerable to an IQueryable.

Applies to
APPLIES TO
Product	Versions
.NET	5.0, 6.0 RC 1
.NET Core	1.0, 1.1, 2.0, 2.1, 2.2, 3.0, 3.1
.NET Framework	1.1, 2.0, 3.0, 3.5, 4.0, 4.5, 4.5.1, 4.5.2, 4.6, 4.6.1, 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8
.NET Standard	1.0, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 2.0, 2.1
UWP	10.0
Xamarin.Android	7.1
Xamarin.iOS	10.8
Xamarin.Mac	3.0
Thread Safety
Public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

This implementation does not provide a synchronized (thread safe) wrapper for an Array; however, .NET classes based on Array provide their own synchronized version of the collection using the SyncRoot property.

Enumerating through a collection is intrinsically not a thread-safe procedure. Even when a collection is synchronized, other threads can still modify the collection, which causes the enumerator to throw an exception. To guarantee thread safety during enumeration, you can either lock the collection during the entire enumeration or catch the exceptions resulting from changes made by other threads.
 
 Ejercicios 7
Bueno, veamos algunos ejercicios para practicar lo visto!

1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
CADENA FUENTE: “La mar estaba serena"
CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
CADENA RESULTADO: “Li mir estibi sereni"

4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
- Número de Artículo (1 a 15)
- Cantidad Vendida 

Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
Se pide determinar e informar:
a) El número de artículo que más se vendió en total.
b) Los números de artículos que no registraron ventas.
c) Cuantas unidades se vendieron del número de artículo 10.

 https://www.youtube.com/watch?v=1BeeaZ416vc Ejercicio 1
 
 https://www.youtube.com/watch?v=dMo3zl6-hKU Ejercicio 2
 
 https://www.youtube.com/watch?v=EqK7dppFR2M Ejercicio 3
 
 https://www.youtube.com/watch?v=_8BG8TKj1Ss Ejercicio 4
 
 Cadenas de caracteres
Bueno, como ya habremos hablado, este es un manejo de cadenas a bajo nivel, bien manual; pero entenderlo nos da una amplitud mayor sobre el funcionamiento de ciertas cosas en programación. Es completamente opcional, aunque te recomiendo que lo chequees. Es un tema que vemos obligatoriamente en la carrera de programación en la uni.
 
 
 
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 Clase 8:
 
 Módulo 8 - Videos
Les dejo un video en el que explico el concepto de funciones de manera detallada junto a todas sus particularidades. Scope, parámetros por valor, por referencia, tipos, return, etc! 
 
 https://www.youtube.com/watch?v=7X6qzA7pssw
 
 Y por otro lado, una serie de ejercicios resueltos. Todo en diagrama, pero con la práctica que veamos en la clase, lo pueden codificar e ir probando todo! Adelante!
 
 https://www.youtube.com/watch?v=jbgGa96R7Vc
 
 Ejercicios 8
En este caso, la idea va a ser armar una función que resuelva algo y luego armar un main que interactúe con una persona para pedir y mostrar datos pero que llame a esa función para resolver lo planteado. Vamos?

1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

a. 1 si el número es positivo.
b. -1 si el número es negativo.
c. 0 si el número es cero.

https://www.youtube.com/watch?v=ByisntHXPi8 Ejercicio 1
 
 https://www.youtube.com/watch?v=aPblwCG9SHA Ejercicio 2
 
 https://www.youtube.com/watch?v=rdcTLXQayrE Ejercicio 3
 
 https://www.youtube.com/watch?v=LE0QTaToyCE Ejercicio 4
 
 
 
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


Trabajo Práctico
Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

a. El mayor de los números pares.
b. La cantidad de números impares.
c. El menor de los números primos.

Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

Entregar carpeta comprimida del proyecto con el TP resuelto.
Poner nombre tanto al proyecto como al zip: TP1_Apellido >> por ejemplo: TP1_SarFernandez

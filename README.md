# C-sharp

Primera clase:  Software necesario
En este curso vamos a programar con un lenguaje de programación llamado C# (C sharp). El lenguaje fue desarrollado por Microsoft y tiene una forma de ser escrito bastante parecida a lo que es C++ o Java.
Para poder programar en C# necesitamos contar con toda la suite de desarrollo de Microsoft que se instala automáticamente al descargar e instalar un IDE que se llama Visual Studio Community. El tema es que este programa es súper pesado y no tiene mucho sentido, por ahora.
Así que lo que vamos a usar es su hermano menor, que no es menos importante y de hecho es uno de los más famosos hoy en día. Se llama Visual Studio Code. No confundan el nombre, es muy parecido, pero son dos cosas bastante distintas.
El tema es que el Visual Studio Code no te instala todo automáticamente. Pero no pasa nada, es instalar una sola cosa aparte.
Entonces, lo primero que tenés que hacer es descargar e instalar:
Visual Studio Code
Y luego de que lo tengas instalado, vamos a descargar e instalar el Software Development Kit de Microsoft .Net Core. Ufff... cuánto nombre... es básicamente un kit de desarrollo que tiene todo lo que necesitamos, no te asustes.
SDK .Net Core
Nota: para poder instalar todo esto necesitás contar con Windows. Si no usás Windows, contame que lo podemos adaptar para el sistema que uses. 
Crear nuevo proyecto
Lo vamos a ver en la clase, pero si querés ir intentando, te dejo los pasos a seguir para poder crear un nuevo proyecto.
Lo primero que necesitamos hacer es abrir la terminal, o consola de comandos. En Windows, para ello podés presionar la combinación de teclas Windows + R y en el cuadro de diálogo escribir "cmd" y presionar Enter. Otra forma es buscando la consola en el buscador del menú de Windows.
Una vez allí lo que tendrás que hacer es posicionarte en una carpeta. O sea entrar a una carpeta en la que vamos a crear el proyecto. Para ello te recomiendo que vayas al escritorio o a Documents y te crees una carpeta que se llame "Práctica Programación" o algo por el estilo. Allí dentro crearás luego todos tus proyectos.
Supongamos que en Documents creaste la carpeta "Ejercicios", entonces en la consola deberías escribir:
cd C:\Users\msarfernandez\Documents\Ejercicios
O sea, la clave "cd" seguida por un espacio y luego la ruta completa de la carpeta. En el ejemplo es la ruta completa en MI máquina, vos tenés que poner la ruta completa en la tuya. 
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
La programación es una disciplina (de tantas hoy en día) que pertenece a la informática, ciencia que se dedica al análisis y transformación de datos e información a partir del uso de computadoras.
En dicha disciplina se desarrollan algoritmos en un determinado lenguaje de programación, los cuales serán implementados en una computadora para de esa manera realizar los llamados programas.
Algoritmo
Un algoritmo es una secuencia finita y ordenada de instrucciones que deben ser seguidas en pos de resolver un problema. https://www.youtube.com/watch?v=i3J42rmbrBQ
https://www.youtube.com/watch?v=kJCin3JwIBY
Programa
Un programa es, técnicamente hablando, uno o más (al menos uno) algoritmos de programación escrito en un lenguaje que puede ser interpretado y ejecutado por una computadora. En otras palabras, decimos que un programa es la solución a un problema, ya que cada vez que se requiere desde sumar números hasta realizar traducciones, grandes cálculos o enviar mensajes de texto, se recurre a un programa (o aplicación, o web, lo que corresponda). https://www.youtube.com/watch?v=xmbRFUy8fcc
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
Humano. Se completa el ciclo con el humano que es quien hace uso de ese Software gracias a ese Hardware, y quizá pueda sonar a una obviedad, pero es clave tener en cuenta este círculo.
Como ya dijimos, el Software es lo que le da vida a la computadora. Son los programas que nos permiten utilizarlas, y existen distintas categorizaciones dentro del software. Las más comunes son:
-       Software de base: esto corresponde a las cuestiones básicas y de sistema operativo que se requiere para poder encender y usar una computadora (Windows, Linux, Mac OS, Android, iOS).
-       Software utilitarios: son aplicaciones complementarias para el correcto funcionamiento y/o administración de los sistemas. Podemos hablar del desfragmentador de disco, o utilidades de análisis de errores en memoria, entre otros.
-       Software de aplicación: los programas, sistemas o aplicaciones que utilizamos a diario.
Existen más categorías y sub-categorías y además ciertas características adicionales como si son libres, o no, o si son open source, o multiplataforma, pero eso es para indagar en otro contexto.
También podemos mencionar los “programas para programar”. Desde ya que hoy en día para poder desarrollar programas, vamos a necesitar una computadora, pero además vamos a necesitar uno o más (según corresponda) programas que nos sirvan para ello. Hay aplicaciones específicamente preparadas para, justamente, desarrollar otras aplicaciones, en definitiva, para programar. Estas aplicaciones se suelen conocer como IDE, de sus siglas en inglés "Entorno de Desarrollo Integrado".
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
Esta unidad es más teórica introductoria que para ejercitar. Por eso el siguiente ejercicio va a ser más que nada para que testeemos que el entorno quedó configurado correctamente y que estamos en condiciones para comenzar a programar.
1. Para este primer ejercicio deberás crear tu primer programa que emita en pantalla "Hola Mundo".
Adicionalmente, podés hacer las modificaciones correspondientes para que el programa emita "Bienvenido Juanito", donde "Juanito" puede ser tu nombre. 
En este módulo comenzamos a manejar conceptos más precisos y técnicos, puntuales y necesarios para la confección de nuestros primeros programas.
En la unidad anterior comprendimos las herramientas a utilizar y llevamos a cabo la creación del primer proyecto para corroborar que todo estaba en orden.
Lo primero que tenemos que comenzar a comprender en cuanto a los programas es que existe un principio básico de todo algoritmo, de todo programa, de toda aplicación; el cual se basa en el esquema que se muestra a continuación:
 
Todo programa, para poder operar, necesita contar con una entrada de datos con los cuales realizará un posterior procesamiento, una transformación de esos datos, a partir de los cuales terminará obteniendo información para finalmente brindar una salida.
Nuestro ejemplo más sencillo parte de la necesidad de sumar dos números. Para poder sumar dos números, el programa deberá solicitarlos (o recibirlos), es decir, contar con una entrada de datos que serán esos dos números. Luego aplicará un procesamiento, que en este caso será sumar esos dos valores que fueron ingresados; para finalmente obtener el resultado de la suma y mostrarlo en pantalla. Esta última sería la salida de información.
¿Dato o Información?
Por qué se hace hincapié en la diferencia de que lo que entra son Datos y lo que sale es Información? Podríamos tomarlos como sinónimos?
La definición de datos dice que: un dato es un conjunto de símbolos sin significado alguno, mientras que por otro lado, la definición de información afirma que: la información está compuesta por símbolos a los que se le ha atribuido algún significado.
Yo siempre suelo dar un ejemplo un tanto fantástico, pero simple y que, a mí entender, funciona para comprender la idea.
Se trata de una persona que, caminando por la calle, se encontró con un pergamino tirado. Cuando lo abre se trata de un documento bastante elegante, con firmas y demás pero con un texto que esta persona no podía comprender. Pensó en hacer un cuadro, ya que era lindo, vistoso; terminó por regalárselo a un amigo hijo de japoneses. Este amigo resulta que manejaba la lengua nativa de Japón por sus padres y al ver el pergamino entendió de qué se trataba y no solo eso, pudo leerlo pues estaba escrito en un lenguaje que manejaba y comprendía. Se trataba de un documento correspondiente a un testamento el cual otorgaba una fortuna a quién lo encuentre y, desde ya, pueda reclamarlo por saber de qué se trataba.
A qué quiero llegar con todo esto? Para la primera persona ese pergamino no era más que un papel "lindo" que a lo sumo podría utilizar para decorar una sala. Un papel con un conjunto de símbolos sin sentido. Pero por otro lado, para su amigo, quien contaba con los elementos necesarios para comprender ese papel, lo que decía en él, par aplicar un procesamiento (a partir de traducir -aplicar un algoritmo-) el contenido del mismo, pasó a atribuirle un significado valiosísimo, en este caso monetario, transformando esos datos en información, mediante un procesamiento.
El fin de toda aplicación es siempre obtener información.
El proceso y las variables
Para poder realizar las transformaciones de las que hablamos necesitamos construir nuestros algoritmos con las instrucciones necesarias. Desde ya que tendremos, generalmente, para comenzar un ingreso de datos y para terminar una salida de información. Pero en el medio es donde vamos a tener que establecer las instrucciones necesarias para darle forma al proceso pertinente que realice la transformación, o "la magia".
Volviendo a nuestro ejemplo de la suma, el proceso sería justamente sumar, valga la redundancia, pero hay varias cosas que se encuentran implícitas en esa operación.
Para poder sumar dos valores necesitamos previamente contar con ellos, y para eso no alcanza con pedirlos. Una vez que los pedimos, tenemos que guardarlos. Para poder guardar esos datos vamos a necesitar hacer uso de un elemento fundamental en la programación: la variable. Una variable es un espacio en memoria que permite alojar un valor. Es un medio que utilizaremos en nuestros programas para ir guardando todas las cosas que necesitamos dentro y a lo largo de todo algoritmo.
Imaginen la memoria RAM (si no conocen la memoria RAM repasen el video de la PC del módulo 1) como una hoja excel, la cual cuenta con columnas representadas por letras y filas representadas por números y en cada intersección encontramos una celda. 
 
Ok. Si yo digo C5, estoy haciendo referencia a la columna C en la fila 5. Podemos decir que la memoria RAM trabaja parecido a esto. C5 sería la dirección de memoria de esa celda. Sin embargo, al querer usar esas "celdas" (variables) en nuestros programas no vamos a estar todo el tiempo usando direcciones de memoria, para ello, lo que haremos es ponerle nombre a las variables. De ese modo, podremos hacer referencia a esas celdas mediante un nombre significativo y fácil de recordar. Significativo porque deberíamos nombrar nuestras variables teniendo en cuenta qué es lo que contienen dentro. 
Volviendo una vez más a nuestro ejemplo de la suma, para guardar los dos valores ingresados podemos decir que lo haremos en las variables numero1 y numero2. Los nombres de las variables pueden contener cualquier letra, varias palabras y también números, aunque hay ciertas restricciones: 
•	No se puede comenzar el nombre de una variable con números.
•	El nombre no puede estar compuesto solo por números.
•	El nombre no puede contener símbolos especiales (por ejemplo * o +).
El nombre no puede ser igual a una palabra reservada. Dependiendo del lenguaje de programación que usemos, hay palabras que son específicas para hacer algo puntual, con lo cual no podemos usarlas como nombres de variables. Por ejemplo:
Console
Palabra que usamos para invocar a la muestra de un mensaje en pantalla como vimos en el primer proyecto de ejemplo:
Console.WriteLine("Hola Mundo");
Reproducir Vídeo

Reproducir Vídeo

Operadores Aritméticos
Son los primeros operadores que comenzaremos a utilizar. Estos son:
•	+ para sumar
•	- para restar
•	* para multiplicar
•	/ para dividir
Estas son las operaciones básicas que el procesador ya conoce y que tenemos disponibles para utilizar. De allí para arriba, es decir, un cuadrado, un logaritmo, etc., etc., son operaciones que tendremos que construir a mano porque el procesador no las sabe. Es verdad que en la actualidad existen muchas cosas ya hechas las cuales podemos utilizar (se llaman librerías, las veremos más adelante), pero generalmente cuando se está comenzando en la programación, una de las primeras cosas se trata de recrear algunas de esas funcionalidades para entender cómo trabajan.
Reproducir Vídeo


Asignación
La asignación es una acción mediante la cual se da un valor a una variable. Por ejemplo
jota = 10;
Lo que estamos haciendo en esa instrucción es tomar el valor 10 y asignarlo, o sea guardarlo, en la variable llamada jota. Hay varios orígenes de datos para realizar una asignación. La que acabamos de ver directamente asigna un valor. También se puede asignar el resultado de una operación matemática o simplemente asignar lo que se pide que una persona ingrese por teclado:
resultado = jota + 7;
variable = Console.ReadLine();
El primer programa
Ya sabemos que tenemos que pedir y guardar, y que tenemos que procesar y mostrar. Y tenemos casi todas las herramientas. Hagamos nuestro primer programa en código y luego terminamos de analizar.
int numero1;
int numero2;
int resultado;
numero1 = int.Parse(Console.ReadLine());
numero2 = int.Parse(Console.ReadLine());
resultado = numero1 + numero2;
Console.WriteLine(resultado);
En las primeras tres líneas lo que hacemos es declarar las variables y darles un tipo. Trabajaremos con números enteros (recordemos que los tipos que manejaremos por ahora son int, float, char y bool).
Luego pedimos datos por teclado con la función ReadLine. La misma devuelve un texto, es por eso que con int.Parse lo que hacemos es transformarlo a número, que es lo que queremos. Tranqui, hay cosas que de a poco vamos a ir terminando de entender.
Luego de pedir y guardar los datos en nuestras variables, volvemos a usar éstas últimas ahora para leer el contenido que antes guardamos y, haciendo uso del operador aritmético para sumar, realizamos la suma. El resultado lo guardamos con el operador = (que en programación no es igual, sino asignar). 
Finalmente, con WriteLine volvemos a leer, esta vez el valor que quedó guardado en resultado, para mostrarlo en pantalla.
Y listo, ese es nuestro primer programa. Todos estos pasos que tenemos detallados aquí, los tenés súper explicados en el video "Primer Programa" que te sugiero que veas.
Luego de todo esto, ya estamos en condiciones para seguir avanzando en la creación de otros programas de este tipo.
Tenés algunos ejercicios para practicar. 
Otra cosas interesantes que deberías saber
Reproducir Vídeo


Reproducir Vídeo


Reproducir Vídeo
Mi primer programa:
Calculadora en diagrama de flujo.
Figura de ingreso pide valores de entrada
La de egreso muestra en pantalla
La de proceso, procesa los valores de entrada
El inicio y el fin marcan el comienzo y final de un programa.
El if condicional:
Ejercicios resueltos: guía 1 empeza a programar
Integral numeric types (C# reference)
The integral numeric types represent integer numbers. All integral numeric types are value types. They are also simple types and can be initialized with literals. All integral numeric types support arithmetic, bitwise logical, comparison, and equality operators.
 
In all of the table rows except the last two, each C# type keyword from the leftmost column is an alias for the corresponding .NET type. The keyword and .NET type name are interchangeable. For example, the following declarations declare variables of the same type:
int a = 123;
System.Int32 b = 123;
The nint and nuint types in the last two rows of the table are native-sized integers. They are represented internally by the indicated .NET types, but in each case the keyword and the .NET type are not interchangeable. The compiler provides operations and conversions for nint and nuint as integer types that it doesn't provide for the pointer types System.IntPtr and System.UIntPtr. For more information, see nint and nuint types.
The default value of each integral type is zero, 0. Each of the integral types except the native-sized types has MinValue and MaxValue constants that provide the minimum and maximum value of that type.
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
Literals are interpreted as positive values. For example, the literal 0xFF_FF_FF_FF represents the number 4294967295 of the uint type, though it has the same bit representation as the number -1 of the int type. If you need a value of a certain type, cast a literal to that type. Use the unchecked operator, if a literal value cannot be represented in the target type. For example, unchecked((int)0xFF_FF_FF_FF) produces -1.
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
You can convert any integral numeric type to any other integral numeric type. If the destination type can store all values of the source type, the conversion is implicit. Otherwise, you need to use a cast expression to perform an explicit conversion. For more information, see Built-in numeric conversions.
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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
Link de youtube: 
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
En este caso el primer valor corresponde al contenido de la variable "a", mientras que el operador de comparación es ">" (mayor) y finalmente el segundo valor es el literal "10".
Operadores relacionales
Los operadores disponibles para construir condiciones lógicas se denominan relacionales, y son los siguientes:
•	> mayor
•	< menor
•	>= mayor o igual
•	<= menor o igual
•	== igual (nótese que no es = a secas, son dos símbolos juntos para la igualdad)
•	!= distinto

Por ahora, solo podemos poner una condición por If. Es decir, una sola "valor condición valor"; con lo cual, deberías tener solamente dos valores y UN operador relacional, para que se entienda que es correcta la condición.
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
En este caso muestra un cartel en pantalla si edad tiene un valor mayor a 18 y en caso contrario, no hace nada. Pero qué pasa si sí quisiéramos hacerlo? En ese caso lo que podemos hacer es escribir el bloque else, que, como te habrás dado cuenta, es opcional, ya que hasta ahora no lo habíamos hecho. 
De este modo, siguiendo el mismo ejemplo, podemos mostrar un cartel que diga que sos menor si el valor no es mayor a 18, o sea, si la condición fue falsa.
int edad = 17;
if(edad > 18){
   Console.WriteLine("Sos mayor");
}
else{
   Console.WriteLine("Sos menor");
}
En este caso, como ahora a edad le asignamos el valor 17, en vez de ir por el verdadero del If, va a ir por el else, o sea, el falso. Tené en cuenta que le asignamos 17 a la variable. Y qué pasa si le hubiésemos asignado 18? En ese caso qué resultado daría el If, verdadero o falso? Teniendo en cuenta lo que se pregunta específicamente en el If y no lo que sepamos de cuándo sos mayor de edad. Si tenés dudas sobre cuál es la respuesta correcta podés probar el código o consultarlo en el Foro de dudas.

Bueno, comenzamos con IF. En realidad en este video primero resolvemos algunos ejercicios anteriores, creo que ya te lo había compartido antes. Pero ahora, lo relevante es el comienzo de la explicación del condicional IF y comenzar a trabajar con dicha herramienta.
Link de youtube:
Luego de aprender lo básico, obviamente viene la hora de hacer ejercicios para comenzar a entrenar lo recién visto. Así que acá resolvemos algunos ejercicios. Y desde ya, seguimos sumando algún que otro dato de color, como también micro temas y datos relevantes!
Link de youtube:
Ejercicios 3
Bueno, ya entramos en condicionales, así que ahora sí, vamos a codificar ejercicios con condiciones.
Lean atentamente y codifiquen las soluciones. Si van apareciendo dudas, me van consultando.

1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
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
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------Clase 4:




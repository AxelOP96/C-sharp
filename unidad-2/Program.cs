// See https://aka.ms/new-console-template for more information
//1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
int numeroUno, numeroDos, resultado;
Console.WriteLine("Ingrese un numero");
numeroUno = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
numeroDos = int.Parse(Console.ReadLine());

resultado = numeroUno + numeroDos;
Console.WriteLine(resultado);

//2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
int numeroPedido, cubo;
Console.WriteLine("Ingrese un numero para elevar al cubo");
numeroPedido= int.Parse(Console.ReadLine());
cubo = numeroPedido * numeroPedido * numeroPedido;
Console.WriteLine(cubo);
//3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad 
//promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un 
//punto a otro teniendo en cuenta los datos ingresados.
double kilometros, velocidad, tiempo;
Console.WriteLine("Ingrese los kilometros entre las dos ciudades");
kilometros = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la velocidad");
velocidad = double.Parse(Console.ReadLine());
tiempo = kilometros/ velocidad;
Console.WriteLine("El tiempo que tardara en llegar es de " + tiempo + " minutos");
//4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total 
//facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego 
//calcule y emita por pantalla el sueldo total a cobrar por el mismo
double total, sueldo;
Console.WriteLine("Ingrese el total facturado");
total = double.Parse(Console.ReadLine());
sueldo = 15000 + (total * 0.05);
Console.WriteLine("El sueldo a cobrar es de " + sueldo);
//5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y 
//emita por pantalla el promedio final.
int nota1, nota2, nota3;
double promedio;
Console.WriteLine("Ingrese las tres notas de examenes");
nota1 = int.Parse(Console.ReadLine());
nota2 = int.Parse(Console.ReadLine());
nota3 = int.Parse(Console.ReadLine());
promedio = (nota1 + nota2 + nota3)/3;
Console.WriteLine("El promedio de las 3 notas da " + promedio);
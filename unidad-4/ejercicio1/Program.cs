
//1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

//La resta si el primero es mayor que el segundo.
//La suma si son iguales.
//El producto si el primero es menor.
//Se deberá emitir un cartel por pantalla con el resultado correspondiente.
int numero1, numero2;
int resultado =0;
Console.WriteLine("Ingrese dos numeros");
numero1 = int.Parse(Console.ReadLine());
numero2 = int.Parse(Console.ReadLine());
if(numero1 > numero2){
    resultado = numero1 - numero2;
}
if(numero1 == numero2){
    resultado = numero1 + numero2;
}
if(numero1 < numero2){
    resultado = numero1 * numero2;
}
Console.WriteLine("El resultado de la operacion es: " + resultado);
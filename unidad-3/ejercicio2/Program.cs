﻿// 2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, 
//“Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
int numero ;
Console.WriteLine("Ingrese un numero");
numero = int.Parse(Console.ReadLine());

if(numero>0){
    Console.WriteLine("Positivo");
}
else if(numero<0){
    Console.WriteLine("Negativo");
}else{
    Console.WriteLine("Cero");
}

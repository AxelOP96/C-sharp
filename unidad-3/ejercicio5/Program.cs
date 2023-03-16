// 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
int n1, n2, n3, n4;
String acumulador = " ";
Console.WriteLine("Ingrese cuatro numeros");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());
n3 = int.Parse(Console.ReadLine());
n4 = int.Parse(Console.ReadLine());

if(n1>100){
    acumulador += " " +n1;
}
if(n2>100){
    acumulador += " " +n2;
}
if(n3>100){
    acumulador += " " +n3;
}
if(n4>100){
    acumulador += " " + n4;
}

Console.WriteLine("Los numeros ingresados mayores a 100 son: " + acumulador);
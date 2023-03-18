// 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma 
//de los dos primeros es mayor al producto del segundo con el tercero.
int numero1, numero2, numero3;
Console.WriteLine("Ingrese tres numeros");
numero1 = int.Parse(Console.ReadLine());
numero2 = int.Parse(Console.ReadLine());
numero3 = int.Parse(Console.ReadLine());

if((numero1+numero2)>(numero2*numero3)){
    Console.WriteLine("La suma es mayor al producto");
}else{
    Console.WriteLine("La suma no es mayor al producto");
}
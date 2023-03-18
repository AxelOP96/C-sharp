// 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos 
//se encuentran ordenados de forma decreciente .
int numero1, numero2, numero3, numero4;
Console.WriteLine("Ingresa cuatro numeros");
numero1 = int.Parse(Console.ReadLine());
numero2 = int.Parse(Console.ReadLine());
numero3 = int.Parse(Console.ReadLine());
numero4 = int.Parse(Console.ReadLine());

if(numero1>numero2 && numero1>numero3 && numero1>numero4 && numero2>numero3 && numero2>numero4 && numero3>numero4){
    Console.WriteLine("Se encuentra ordenado en forma decreciente");
}else{
    Console.WriteLine("No se encuentra ordenado en forma decreciente");
}
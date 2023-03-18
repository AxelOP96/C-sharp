// 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por 
//pantalla. Solo se debe emitir UN valor por pantalla.

int numero, mayor;
mayor =0;
for(int i=0;i<10;i++){
    Console.WriteLine("Ingrese 10 numeros!");
    numero = int.Parse(Console.ReadLine());
    if(i==0){
        mayor = numero;
    }
    if(mayor<numero)
        mayor = numero;
}
Console.WriteLine("El mayor es " + mayor);

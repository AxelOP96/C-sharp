// 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es 
//primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
int numero, contador=0;
Console.WriteLine("Ingrese un numero!");
numero  = int.Parse(Console.ReadLine());
for(int divisor =2;divisor<numero;divisor++){
    if(numero%divisor==0)
        contador++;
}
if(contador>=2){
    Console.WriteLine("El numero no es primo");
}else{
    Console.WriteLine("El numero es primo");
    }
    


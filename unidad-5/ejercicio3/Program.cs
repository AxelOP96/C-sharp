// 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores 
//a 18 años.
Console.WriteLine("Ingrese 20 edades!");
int edad, acum=0, contador=0;
//double promedio;
for(int i = 0;i<20;i++){
    edad = int.Parse(Console.ReadLine());
    if(edad>18){
        acum += edad;
        contador++;
    }
}
Console.WriteLine("El promedio de las edades es " + (acum/contador));
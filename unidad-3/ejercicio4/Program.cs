// 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
int n1, n2, n3, n4;
int menor;
Console.WriteLine("Ingrese cuatro numeros");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());
n3 = int.Parse(Console.ReadLine());
n4 = int.Parse(Console.ReadLine());

if(n1<n2){
    menor = n1;
    if(n3<n1){
        menor = n3;
        if(n4<n3){
            menor = n4;
        }
    }else{
        if(n4<n1){
        menor = n4;
    }
}
} else{
    menor = n2;
    if(n3<n2){
        menor = n3;
        if(n4<n3){
            menor = n4;
        }
    }else{
        if(n4<n2){
        menor = n4;
    }
}
}
Console.WriteLine("El menor es " + menor);
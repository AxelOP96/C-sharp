// 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y 
//el mínimo de los números impares.
int numero, menorImpar =0, maximoPar=0;
int contadorPar =0, contadorImpar  =0;
for(int i=0;i<20;i++){
    Console.WriteLine("ingrese 20 numeros!");
    numero = int.Parse(Console.ReadLine());
    if(numero%2==0 && contadorPar ==0){
        maximoPar= numero;
        contadorPar++;
    }
    if(numero%2==1 && contadorImpar ==0){
        menorImpar= numero;
        contadorImpar++;
    }
    if(numero%2==0 && maximoPar< numero){
        maximoPar= numero;
    }
    if(numero%2==1 && menorImpar> numero){
        menorImpar= numero;
    }
}
Console.WriteLine("El maximo de los numeros pares es " + maximoPar + " y el minimo impar es " + menorImpar);
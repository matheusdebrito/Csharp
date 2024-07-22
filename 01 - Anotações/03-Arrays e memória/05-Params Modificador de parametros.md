# Params
Pode ser utilizado para criar uma função que recebe um número variável de valores. Com o params não é necessário colocar a quantidade total de argumentos que a função receberá.
OBS: deve ser passado um vetor de argumentos.

````c#
public static int soma(params int[] numeros){
    int sum = 0;
    for (int i = 0; i < numeros.Length; i++>){
        sum += numeros[i];
    }
    return sum;
}
````

Com essa função podemos calcular com uma quantidade ilimitada de parametros na função.


Para invocar a função no código principal.
````c#
int resultado = soma(1, 2, 3, 4, 5, 6, 7 ,8 ,9);
````

A função irá fazer a soma de todos os parametros passados. Se não fosse dessa maneira teriamos que especificar a quantidade máxima de números que a função poderia aceitar.
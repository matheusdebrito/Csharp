# Ref
Ao criar uma função dentro de uma classe não podemos alterar parâmetros que estejam fora do escopo da classe. Para que isso seja possível devemos atribuir o modificador de parâmetros ref na frente do parâmetro na declaração da função na classe e na chamada da função no código principal.

````c#
public static int triple(ref int numero){
    numero = numero * 3
}
````

Fazendo assim ao chamar a função e atribuindo o valor ref na passagem do parâmetro é possível alterar a variável, mesmo estando fora do escopo da função da classe.

# Out
O modificador out é similar ao ref, mas não exige que a variável original seja iniciada.

# Nota
Ambos são considerados "Code Smells" (design ruim) e devem ser evitados.
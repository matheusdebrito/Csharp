É uma sintaxe opcional e simplificada para percorrer coleções.
Leitura: "Para cada objeto 'obj' contido em vect, faça:"
Deve ser colocado o tipo do vetor antes de 'obj'.

````c#
string[] vect = new string[] {"Maria", "Bob", "Alex"}

foreach(string obj in vect){
    Console.WriteLine(obj);
}
````

Percorrerá todo o vetor e irá imprimir todos os itens do vetor.
"obj" é apenas um apelido. Pode ter o nome que você desejar.


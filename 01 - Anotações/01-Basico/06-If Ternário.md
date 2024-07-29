Estrutura opcional ao if-else quando se deseja decidir um único valor com base em uma condição

Sintaxe: 
( Condição ) ? valor_se_verdadeiro : valor_se_falso
Exemplo:
````c#
(2 < 4) ? Console.WriteLine("Verdadeiro") : Console.WriteLine("Falso") // Imprime verdadeiro pois 2 é menor que 4

(10 != 3) ? Console.WriteLine("Maria") : Console.WriteLine("Alex") // Imprime "Maria" pois 10 é diferente de 3
````
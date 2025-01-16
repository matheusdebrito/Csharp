São operações da classe Object utilizadas para comparar se um objeto é igual a outro.

- Equals: Lento, resposta 100%;
- GetHashCode: Rápido, porém resposta positiva não é 100%;

Os tipos pré-definidos já possuem implementação para essas operações. Classes e structs personalizados precisam sobrepô-las.

- Regra de ouro do GetHashCode: Se os códigos gerados são diferente, então os dois objetos são diferentes. Se os códigos gerados são iguais PROVAVELMENTE os objetos são iguais.
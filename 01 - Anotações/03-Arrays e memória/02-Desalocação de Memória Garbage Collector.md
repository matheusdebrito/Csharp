# Garbage Collector
É um processo que automatiza o gerencimento de memória de um programa em execução.
O Garbage collector monitora os objetos alocados dinamicamente pelo programa (no heap), desalocando aqueles que não estão mais sendo utilizados.

# Desalocação por escopo
É quando, por exemplo, usamos um if e as variáveis declaradas dentro do if são desalocadas assim que o if terminar.

# Resumo
Os objetos alocados dinamicamente, quanto não possuem mais referencia para eles, serão desalocados pelo garbage collector.
Variáveis locais são desalocadas imediatamente assim que seu escopo local sai de execução.
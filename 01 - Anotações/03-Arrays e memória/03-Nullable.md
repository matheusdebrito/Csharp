# Nullable
É um recurso do C# para que dados do tipo valor (structs) possam receber o valor null.

# Uso comum
Campos de bancos de dados que podem valer nulo (data de nascimento, algum valor numérico, etc).
Dados e parâmetros opcionais.

# Atribuindo null a um tipo básico
Para atribuir o valor null para tipo básicos podemos fazer:

```c#
Nullable<double> x = null;
// ou
double? b = null; 
```

# Métodos Nullable

variavel.GetValueOrDefault(); => Pega o valor da variável e caso o valor não exista vai pegar o valor padrão.

variavel.HasValue => verifica se existe valor e retorna true ou false.

variavel.value => da erro caso chame ela a partir de uma variavel que não tenha valor.

# Operador de coalescência nula
Serve para quando formos atribuir o valor de uma variável para outra. Ex:

```c#
double? x = null;
double? y = x ?? 0.0;
```

Nesse caso o operador ?? serve para verificar se a variável x possui valor diferente de nulo e caso a variável x tenha valor nulo será atribuído à variável y o valor 0.0
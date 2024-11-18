Em algumas cituações pode ser necessário sobescrever um método que é herdado de uma classe pai. Para sobescrever um método basta colocar override na frente.

````c#
public override void Withdrawn(double amount){
    Balance -= amount;
}
````

Neste exemplo sobescrevemos um método withdrawn que é herdado da classe pai.
Além disso devemos adicionar Virtual no método na classe pai.

````c#
public virtual override void Withdrawn(double amount){
    Balance -= amount + 5.0;
}
````

Podemos também utilizar a palavra base para chamar o método da classe principal.

````c#
public override void Withdrawn(double amount){
    base.Withdrawn(amount) // Executa o método da classe principal
    Balance -= 2.0;
}
````

No exemplo acima é executado o Withdrawn como na classe pai e também é diminuido 2.0 do Balance.
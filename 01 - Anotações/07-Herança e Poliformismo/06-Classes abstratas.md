São classes que não podem ser instanciadas. É uma forma de garantir herança total: somente subclasses não abstratas podem ser instanciadas, mas nunca a superclasse abstrata.

Ex: Suponha que em um negócio relacionado a banco, apenas contas poupança e contas para empresa são permitidas. Não existe conta comum. Para garantir que contas comuns não possam ser instanciadas, basta acrescentarmos a palavra "abstract" na declaração da classe.

````c#
abstract class Account{

}
````
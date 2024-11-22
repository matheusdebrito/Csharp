Criamos uma pasta Exceptions na pasta entities para guardar as exceções.
Dentro da pasta criamos uma classe com o nome da exceção o nome precisa terminar com Exception.
Essa classe herda "Exception".
Na clase que vai usar a exceção vamos ao método que vai usar a exceção fazemos um if e passamos a exceção com "throw new NomeDaExceção"


Classe exceção
````c#
namespace ExcecaoPersonalizada.Entities.Exceptions
{
    internal class IdadeVotoException : Exception
    {
        public IdadeVotoException(string message) : base(message) 
        { 
                
        }
    }
}

````

Classe eleitor
````c#
using ExcecaoPersonalizada.Entities.Exceptions;

namespace ExcecaoPersonalizada.Entities
{
    internal class Eleitor
    {
        private string _nome;
        private int _idade;

        public int Idade
        {
            get { return _idade; }
            set {
                if(value <= 0)
                {
                    throw new ArgumentException("Idade deve ser maior que zero!");
                }
            }
        }

        public string Nome
        {
            get { return _nome; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome não pode ser nulo ou vazio!");
                }
            }
        }

        public Eleitor(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Votar()
        {
            if(Idade < 16)
            {
                throw new IdadeVotoException("Para votar você deve ter pelo menos 16 anos!");
            }
            Console.WriteLine("Voto realizado com sucesso!");
        }

    }
}

````

Programa Principal
````c#
using ExcecaoPersonalizada.Entities;
using ExcecaoPersonalizada.Entities.Exceptions;
using System;

namespace ExcecaoPersonalizada
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                Eleitor eleitor = new Eleitor("Matheus", 10);
                eleitor.Votar();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IdadeVotoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
````
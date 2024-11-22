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

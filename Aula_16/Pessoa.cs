namespace Aula_16
{
    internal class Pessoa
    {
        private string _nome;
        public string Nome 
        { 
            get { return _nome; } 
            set { _nome = value; } 
        }

        public Pessoa (string nome)
        {
            Nome = nome;
        }
    }
}

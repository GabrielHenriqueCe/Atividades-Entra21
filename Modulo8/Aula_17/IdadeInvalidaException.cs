namespace Aula_17
{
    class IdadeInvalidaException : Exception
    {
        public IdadeInvalidaException(int idade)
            : base($"\nIdade inválida: {idade} anos\n") { }
    }
}
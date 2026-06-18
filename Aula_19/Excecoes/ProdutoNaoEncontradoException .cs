namespace Aula_19.Excecoes
{
    internal class ProdutoNaoEncontradoException : Exception
    {
        public ProdutoNaoEncontradoException(int id)
            : base($"Produto {id} não encontrado.") { }
    }
}
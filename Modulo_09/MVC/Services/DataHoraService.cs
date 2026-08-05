namespace MVC.Services
{
    public class DataHoraService : IDataHoraService
    {
        private readonly Guid _id = Guid.NewGuid();

        public string ObterDataAtual()
        {
            return $"{DateTime.Now:dd/MM/yyyy HH:mm:ss} (Instância: {_id})";
        }
    }
}
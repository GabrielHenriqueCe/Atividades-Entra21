namespace MVC.Services
{
    public class CalculadoraCargaHorariaService : ICalculadoraCargaHorariaService
    {
        private const int HorasPorDiaUtil = 4;

        public double ConverterParaDiasUteis(int cargaHoraria)
        {
            return Math.Round((double)cargaHoraria / HorasPorDiaUtil, 1);
        }
    }
}
namespace Amazonia
{
    public interface IObserver
    {
        void Atualizar(string nomePCD, double temp, double ph, double umidade);
    }
}

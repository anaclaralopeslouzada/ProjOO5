namespace Amazonia
{
    public class Universidade : IObserver
    {
        private string _nome;
        public Universidade(string nome) => _nome = nome;

        public void Atualizar(string nomePCD, double temp, double ph, double umidade)
        {
            Console.WriteLine($"[NOTIFICAÇÃO] A {_nome} recebeu dados da {nomePCD}: Temp: {temp}°C, PH: {ph}, Umidade: {umidade}%");
        }
    }
}

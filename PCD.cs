using System.Collections.Generic;

namespace Amazonia
{
    public class PCD
    {
        private List<IObserver> _observadores = new List<IObserver>();
        public string Nome { get; }
        public double Temperatura { get; private set; }
        public double PH { get; private set; }
        public double Umidade { get; private set; }

        public PCD(string nome) => Nome = nome;

        public void AdicionarObservador(IObserver obs) => _observadores.Add(obs);

        public void SetDados(double temp, double ph, double umidade)
        {
            Temperatura = temp;
            PH = ph;
            Umidade = umidade;
            Notificar();
        }

        private void Notificar()
        {
            foreach (var obs in _observadores)
            {
                obs.Atualizar(Nome, Temperatura, PH, Umidade);
            }
        }
    }
} 

using System;

namespace Amazonia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando as plataformas (Sujeitos)
            PCD pcdRioNegro = new PCD("Rio Negro");
            PCD pcdTapajos = new PCD("Rio Tapajós");

            // Criando as universidades (Observadores)
            Universidade usp = new Universidade("USP");
            Universidade unifesp = new Universidade("UNIFESP");

            // Ligando os interesses 
            pcdRioNegro.AdicionarObservador(usp);
            pcdRioNegro.AdicionarObservador(unifesp); // UNIFESP também quer Rio Negro

            pcdTapajos.AdicionarObservador(unifesp); // UNIFESP quer Tapajós também

            // Mostrando a mudança 
            Console.WriteLine("Mudança na temperatura do Rio Negro");
            pcdRioNegro.SetDados(32.5, 6.8, 80.0); // Aqui o USP e UNIFESP vão imprimir

            Console.WriteLine("\nMudança na umidade do Rio Tapajós");
            pcdTapajos.SetDados(29.0, 7.0, 95.0); // Aqui só a UNIFESP vai imprimir
        }
    }
}

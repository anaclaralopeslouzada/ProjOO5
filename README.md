# Exercício de ProjOO - Monitoramento da Amazônia (Padrão Observer)

Este repositório contém a minha resolução para o problema de monitoramento ambiental das regiões da Amazônia, utilizando o padrão de projeto **Observer**, conforme discutido em aula com o Prof. Fábio Fagundes Silveira.

## O que eu fiz no projeto:
A ideia foi criar um sistema onde plataformas de coleta de dados (PCDs) espalhadas pelos rios da Amazônia conseguem notificar universidades interessadas sempre que houver uma mudança no ambiente.

O ponto principal aqui é que a notificação é **específica**: uma universidade só recebe o aviso se ela tiver demonstrado interesse por aquela plataforma específica. Se a temperatura do Rio Negro mudar, apenas as universidades que "assinaram" o monitoramento do Rio Negro serão avisadas.

## Padrão Utilizado:
- **Observer**: As PCDs agem como o "Sujeito" (Subject) e as Universidades como os "Observadores" (Observers). Isso permite um acoplamento dinâmico, onde posso ligar e desligar o interesse de uma universidade a qualquer momento.

## Estrutura dos arquivos:

- **IObserver.cs**: Interface que define o contrato de atualização para qualquer interessado nos dados.
- **PCD.cs**: Classe que representa a plataforma de sensores (Sujeito). Ela guarda os valores de temperatura, PH e umidade, e gerencia sua própria lista de observadores.
- **Universidade.cs**: Classe que representa as instituições (Observadores). Ela reage e imprime a notificação quando recebe novos dados.
- **Program.cs**: Arquivo onde eu instanciei as plataformas e as universidades, configurei os interesses de cada uma e testei as notificações mudando os valores dos sensores.

## Como rodar o código:
O repositório contém o arquivo de projeto (`.csproj`). Para executar e testar as notificações no terminal:

```bash
dotnet run

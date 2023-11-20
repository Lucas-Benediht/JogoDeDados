# Jogo de Dados

## Descrição
Este é um simples jogo de dados em C# que permite que dois jogadores joguem dados por três rodadas. O vencedor é determinado com base na pontuação acumulada ao longo das rodadas.

## Como Jogar
1. Execute o programa.
2. Digite `1` para iniciar o jogo ou qualquer outra tecla para finalizar.
3. Insira o nome do primeiro e do segundo jogador quando solicitado.
4. O jogo realizará três rodadas de lançamento de dados.
5. A pontuação de cada jogador é atualizada após cada rodada.
6. O vencedor é determinado no final das três rodadas.

## Estrutura do Código

### Jogo.cs
A classe `Jogo` controla a lógica principal do jogo. Ela tem métodos para configurar jogadores, executar rodadas e verificar o vencedor.

### Jogador.cs
A classe `Jogador` representa um jogador no jogo. Ela possui propriedades para nome e pontuação, e métodos para incrementar a pontuação e jogar os dados.

### Program.cs
O arquivo `Program` contém o método `Main`, que inicia o jogo.

## Requisitos
- .NET Core SDK

## Como Executar
1. Abra o terminal na pasta do projeto.
2. Execute o comando `dotnet run`.

## Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## Licença
Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE.md](LICENSE.md) para detalhes.

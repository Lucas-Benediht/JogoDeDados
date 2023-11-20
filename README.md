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

---

## Screenshot
- Segue algumas telas do console da aplicação:
  
![image](https://github.com/Lucas-Benediht/JogoDeDados/assets/110697669/c8caf238-a12c-411f-983f-0d69f32a7ef3)

![image](https://github.com/Lucas-Benediht/JogoDeDados/assets/110697669/f45c3139-11b7-45ad-b634-d122ed6a6dc3)

![image](https://github.com/Lucas-Benediht/JogoDeDados/assets/110697669/2c9fd014-d00f-4c0e-9fce-10b8c8a02c85)

![image](https://github.com/Lucas-Benediht/JogoDeDados/assets/110697669/ed6465ac-50ee-4180-8680-ffa6ffd12ae6)

![image](https://github.com/Lucas-Benediht/JogoDeDados/assets/110697669/90270448-46a2-46dc-9533-d1b65e9bc9af)

![image](https://github.com/Lucas-Benediht/JogoDeDados/assets/110697669/7ef86cf3-11ef-4fe2-9529-3c96766efff5)


## Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

## Licença
Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE.md](LICENSE.md) para detalhes.

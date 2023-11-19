using System.Threading;
using System;

public class Jogo
{
    private Jogador jogador1;
    private Jogador jogador2;

    public Jogo()
    {
        jogador1 = new Jogador();
        jogador2 = new Jogador();
    }

    public void IniciarJogo()
    {
        Console.WriteLine("\r\n░░░░░██╗░█████╗░░██████╗░░█████╗░  ██████╗░███████╗  ██████╗░░█████╗░██████╗░░█████╗░░██████╗\r\n░░░░░██║██╔══██╗██╔════╝░██╔══██╗  ██╔══██╗██╔════╝  ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝\r\n░░░░░██║██║░░██║██║░░██╗░██║░░██║  ██║░░██║█████╗░░  ██║░░██║███████║██║░░██║██║░░██║╚█████╗░\r\n██╗░░██║██║░░██║██║░░╚██╗██║░░██║  ██║░░██║██╔══╝░░  ██║░░██║██╔══██║██║░░██║██║░░██║░╚═══██╗\r\n╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝  ██████╔╝███████╗  ██████╔╝██║░░██║██████╔╝╚█████╔╝██████╔╝\r\n░╚════╝░░╚════╝░░╚═════╝░░╚════╝░  ╚═════╝░╚══════╝  ╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═════╝░");
        Console.WriteLine("Digite 1 para iniciar ou qualquer outra tecla para finalizar: ");
        int iniciar = int.Parse(Console.ReadLine());

        if (iniciar == 1)
        {
            ConfigurarJogadores();
            ExecutarRodadas();
            VerificarVencedor();
        }
        else
        {
            Environment.Exit(0);
        }
    }

    private void ConfigurarJogadores()
    {
        Console.WriteLine("Digite o nome do primeiro jogador: ");
        jogador1.Nome = Console.ReadLine();
        Console.WriteLine("Digite o nome do segundo jogador: ");
        jogador2.Nome = Console.ReadLine();

        Console.WriteLine($"Nome dos jogadores: {jogador1.Nome} e {jogador2.Nome}");
        Console.WriteLine("Digite alguma tecla para continuar....");
        Console.ReadLine();
        Console.Clear();
    }

    private void ExecutarRodadas()
    {
        for (int rodada = 1; rodada <= 3; rodada++)
        {
            Console.WriteLine($"Iniciando Rodada {rodada}");
            Thread.Sleep(2000);

            int resultadoJogador1, resultadoJogador2;

            jogador1.JogarDados(out resultadoJogador1);
            jogador2.JogarDados(out resultadoJogador2);

            Console.Clear();
            Console.WriteLine($"{jogador1.Nome} Jogou os dados e retirou: {resultadoJogador1}");
            Console.WriteLine($"{jogador2.Nome} Jogou os dados e retirou: {resultadoJogador2}");

            AtualizarPontuacao(resultadoJogador1, resultadoJogador2);
            Thread.Sleep(5000);
            Console.Clear();
        }
    }

    private void AtualizarPontuacao(int resultadoJogador1, int resultadoJogador2)
    {
        if (resultadoJogador1 > resultadoJogador2)
        {
            Console.WriteLine($"{jogador1.Nome} Venceu a rodada!");
            jogador1.IncrementarPontuacao();
        }
        else if (resultadoJogador2 > resultadoJogador1)
        {
            Console.WriteLine($"{jogador2.Nome} Venceu a rodada!");
            jogador2.IncrementarPontuacao();
        }
        else
        {
            Console.WriteLine("Empate na rodada!");
        }

        Console.WriteLine($"Pontuação de {jogador1.Nome}: {jogador1.Pontuacao}");
        Console.WriteLine($"Pontuação de {jogador2.Nome}: {jogador2.Pontuacao}");
    }

    private void VerificarVencedor()
    {
        Console.WriteLine("\r\n██████╗░███████╗░██████╗██╗░░░██╗██╗░░░░░████████╗░█████╗░██████╗░░█████╗░\r\n██╔══██╗██╔════╝██╔════╝██║░░░██║██║░░░░░╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗\r\n██████╔╝█████╗░░╚█████╗░██║░░░██║██║░░░░░░░░██║░░░███████║██║░░██║██║░░██║\r\n██╔══██╗██╔══╝░░░╚═══██╗██║░░░██║██║░░░░░░░░██║░░░██╔══██║██║░░██║██║░░██║\r\n██║░░██║███████╗██████╔╝╚██████╔╝███████╗░░░██║░░░██║░░██║██████╔╝╚█████╔╝\r\n╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚══════╝░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░░╚════╝░\r\n\r\n███████╗██╗███╗░░██╗░█████╗░██╗░░░░░██╗\r\n██╔════╝██║████╗░██║██╔══██╗██║░░░░░╚═╝\r\n█████╗░░██║██╔██╗██║███████║██║░░░░░░░░\r\n██╔══╝░░██║██║╚████║██╔══██║██║░░░░░░░░\r\n██║░░░░░██║██║░╚███║██║░░██║███████╗██╗\r\n╚═╝░░░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝╚═╝");
        Console.WriteLine("Verificando vencedor....");

        if (jogador1.Pontuacao > jogador2.Pontuacao)
        {
            Console.WriteLine($"{jogador1.Nome} Venceu o jogo!");
        }
        else if (jogador2.Pontuacao > jogador1.Pontuacao)
        {
            Console.WriteLine($"{jogador2.Nome} Venceu o jogo!");
        }
        else
        {
            Console.WriteLine("O jogo terminou em empate!");
        }
    }
}

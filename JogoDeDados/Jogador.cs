using System;

public class Jogador
{
    public string Nome { get; set; }
    public int Pontuacao { get; private set; }

    public void IncrementarPontuacao()
    {
        Pontuacao++;
    }

    public void JogarDados(Random random, out int resultado)
    {
        resultado = random.Next(1, 7);
    }
}
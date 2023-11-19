using System;

public class Jogador
{
    public string Nome { get; set; }
    public int Pontuacao { get; private set; }

    public void IncrementarPontuacao()
    {
        Pontuacao++;
    }

    public void JogarDados(out int resultado)
    {
        Random random = new Random();
        resultado = random.Next(1, 7);
    }
}
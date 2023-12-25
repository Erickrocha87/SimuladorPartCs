

public class Jogador
{
    public string nome;
    public string nickname;
    public int pontos;

    public Random pontoRandom;
    public void jogar()
    {
    
        this.pontos = this.pontoRandom.Next(100);
    
    }

    public Jogador()
    {
        
        this.pontos = 0;
        this.pontoRandom = new Random();
    }
}

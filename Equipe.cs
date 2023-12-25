using System.Collections;
public class Equipe
{
    public ArrayList Jogadores;

    public string NomeDaEquipe;
    public int pontuacao;
    public void PontosTotal()
    {
        //Precisa retorna a soma dos pontos de todos jogadores
    }
 
    public Equipe()
    {
        this.Jogadores = new ArrayList();
        this.pontuacao = 0;

    }

    public void pontostotais()
    {
        foreach(Jogador jogador in this.Jogadores){
            jogador.jogar();
            this.pontuacao += jogador.pontos;
        }
    }

    public void AdicionarJogador()
    {
        Jogador jogador = new Jogador();
        Console.WriteLine("Escolha o nome:");
        jogador.nome = Console.ReadLine();
        Console.WriteLine("Escolha o nickname");
        jogador.nickname = Console.ReadLine();
        this.Jogadores.Add(jogador);
    }

    public void  CriarEquipe()
    {
        Console.WriteLine("Escolha o nome da equipe 1:");
        string NomeDaEquipe = Console.ReadLine();
        this.NomeDaEquipe = NomeDaEquipe;
        Console.WriteLine($"Equipe {NomeDaEquipe} criada com sucesso");
        Console.WriteLine("Agora cadastre os jogadores:");
        while (this.Jogadores.Count <= 4) { this.AdicionarJogador(); }
        Console.WriteLine("Os jogadores foram criados com sucesso!");

    }
}


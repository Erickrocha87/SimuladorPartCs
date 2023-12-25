public class Campeonato
{
    public string NomeCampeonato;
    public string EquipesParticipantes;
    public void IniciarPartida(Equipe e1, Equipe e2)
    {
        Jogador jogador = new jogador();
        
        foreach(Jogador jogador in e1){
            jogador.jogar();
        }
    }
    public void Classificacao()
    {

    }
}


Console.WriteLine("Seja bem-vindo ao campeonato de CS");
Console.WriteLine("----------------------------------");
Console.WriteLine("Escolha o nome da equipe 1 e o nome de seus jogadores e nicknames: ");


Equipe e1 = new Equipe();
e1.CriarEquipe();

Console.WriteLine("Ótimo, equipe criada com sucesso!");
Console.WriteLine("Agora iremos criar a equipe 2");

Equipe e2 = new Equipe();
e2.CriarEquipe();


Console.WriteLine("Equipe 2 formada com sucesso.");
Console.WriteLine("Agora iremos começar a partida");

Campeonato camp = new Campeonato();
camp.IniciarPartida();


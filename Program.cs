string? escolhaDoJogador;
Random random = new Random();
int númeroAleatório = random.Next(1, 4);
string[] escolhasParaOComputador = new [] {"pedra", "papel", "tesoura" };

Console.WriteLine("Bem-vindo ao jogo Pedra, Papel e Tesoura!");

do
{
    númeroAleatório = random.Next(1, 4);
    string escolhaDoComputador = "";

    Console.WriteLine("Escolha uma opção: Pedra, Papel, Tesoura Ou Sair para encerrar o jogo.");

    escolhaDoJogador = Console.ReadLine();
    
    Console.WriteLine($"\nVocê escolheu: {escolhaDoJogador}.");

    escolhaDoJogador = escolhaDoJogador?.ToLower();
    
    switch (escolhaDoJogador)
    {
        
        case "pedra":
        break;
        case "papel":
        break;
        case "tesoura":
        break;
        case "sair":
            Console.WriteLine("Encerrando o jogo. Obrigado por jogar!");
            continue;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha Pedra, Papel, Tesoura ou Sair.\n");
            continue;
    }

    switch (númeroAleatório)
    {
       case 1:
       escolhaDoComputador = escolhasParaOComputador[0];
       break;
       case 2:
       escolhaDoComputador = escolhasParaOComputador[1];
       break;
       case 3:
       escolhaDoComputador = escolhasParaOComputador[2];
       break;
    }

    Console.WriteLine($"O computador escolheu: {escolhaDoComputador}.\n");

    if (escolhaDoJogador == escolhaDoComputador)
    {
        Console.WriteLine("Empate!\n");
    }
    else if ((escolhaDoJogador == "pedra" && escolhaDoComputador == "tesoura") ||
             (escolhaDoJogador == "papel" && escolhaDoComputador == "pedra") ||
             (escolhaDoJogador == "tesoura" && escolhaDoComputador == "papel"))
    {
        Console.WriteLine("Você venceu!\n");
    }
    else
    {
        Console.WriteLine("O computador venceu!");
    }
} while (escolhaDoJogador != "sair");
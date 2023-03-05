using ExerciciosCSharp.Calculadora;
using ExerciciosCSharp.Conversao;
using ExerciciosCSharp.Moeda;
using ExerciciosCSharp.Ordenar;

int numeroExercicio;

do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;

    string titulo = @"
          _    _      _ _         __          __        _     _ _
         | |  | |    | | |        \ \        / /       | |   | | |
         | |__| | ___| | | ___     \ \  /\  / /__  _ __| | __| | |
         |  __  |/ _ \ | |/ _ \     \ \/  \/ / _ \| '__| |/ _` | |
         | |  | |  __/ | | (_) |     \  /\  / (_) | |  | | (_| |_|
         |_|  |_|\___|_|_|\___( )     \/  \/ \___/|_|  |_|\__,_(_)

    ";

    foreach (char item in titulo)
    {
        Console.Write(item);
        Thread.Sleep(1);
    }

    Console.ForegroundColor = ConsoleColor.White;

    bool tenteNovamente;
    Console.SetCursorPosition(0, Console.CursorTop); // Posicionar o cursor na posição desejada antes de imprimir o texto.
    Console.WriteLine("0: Sair do Programa");
    Console.WriteLine("1: Sorteio");
    Console.WriteLine("2: Calcular consumo de combustível");
    Console.WriteLine("3: Diálogo");
    Console.WriteLine("4: Calculadora");
    Console.WriteLine("5: Conversão de moedas");
    Console.WriteLine("6: Ordenar arrays em C#");
    numeroExercicio = Convert.ToInt32(Console.ReadLine());

    switch (numeroExercicio)
    {
        case 0:
            break;

        case 1:
            tenteNovamente = true;
            Console.Clear();
            while (tenteNovamente)
            {
                try
                {
                    string[] nomes = { "Gustavo C", "Gustavo A", "José", "Diego", "Fickert", "Tulio", "Paulo D", "Paulo C", "Antonio", "Rogerio", "Daniel" };
                    Random aleatorio = new();
                    string sorteio = nomes[aleatorio.Next(nomes.Length)];
                    Console.WriteLine("O nome sorteado é: " + sorteio);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Aperte ENTER para voltar ao menu!");
                    Console.ReadLine();
                    tenteNovamente = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor digite apenas números inteiros!");
                    Thread.Sleep(1);
                    Console.Clear();
                }
            }
            break;

        case 2:
            tenteNovamente = true;
            Console.Clear();
            while (tenteNovamente)
            {
                try
                {
                    Console.WriteLine("Digite a quilometragem inicial:");
                    double kmInicial = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a quilometragem final:");
                    double kmFinal = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a quantidade de combustível abastecida (em litros):");
                    double litrosAbastecidos = double.Parse(Console.ReadLine());

                    double mediaConsumo = (kmFinal - kmInicial) / litrosAbastecidos;

                    Console.WriteLine("A média de consumo de combustível é: " + mediaConsumo.ToString("F2") + " km/l");
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Aperte ENTER para voltar ao menu!");
                    Console.ReadLine();
                    tenteNovamente = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor digite apenas números inteiros!");
                    Thread.Sleep(1);
                    Console.Clear();
                }
            }
            break;

        case 3:
            tenteNovamente = true;
            Console.Clear();
            while (tenteNovamente)
            {
                try
                {
                    Console.WriteLine("Olá, qual é o seu nome?");
                    string nome = Console.ReadLine();

                    Console.WriteLine($"Bem-vindo(a), {nome}! Qual é a sua idade?");
                    int idade = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Legal, então você tem {idade} anos. Eu sou o C Sharp. Prazer em conhecê-lo(a)!");

                    Console.WriteLine("E você, como está se sentindo hoje?");
                    string sentimento = Console.ReadLine();

                    Console.WriteLine($"Entendi, você está se sentindo {sentimento}. Espero que seu dia melhore!");

                    Console.WriteLine("Bem, foi bom conversar com você. Tchau!");
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Aperte ENTER para voltar ao menu!");
                    Console.ReadLine();
                    tenteNovamente = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor digite apenas números inteiros!");
                    Thread.Sleep(1);
                    Console.Clear();
                }
            }
            break;

        case 4:
            tenteNovamente = true;
            Console.Clear();
            while (tenteNovamente)
            {
                try
                {
                    Calculadora.Menu();

                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Calculadora.Somar();
                            break;

                        case "2":
                            Calculadora.Subtrair();
                            break;

                        case "3":
                            Calculadora.Multiplicar();
                            break;

                        case "4":
                            Calculadora.Dividir();
                            break;

                        case "0":
                            break;

                        default:
                            Calculadora.Menu();
                            break;
                    }

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Aperte ENTER para voltar ao menu!");
                    Console.ReadLine();
                    tenteNovamente = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor digite apenas números inteiros!");
                    Thread.Sleep(1);
                    Console.Clear();
                }
            }
            break;

        case 5:
            tenteNovamente = true;
            Console.Clear();
            while (tenteNovamente)
            {
                try
                {
                    Console.Clear();
                    ConversaoMoeda conversaoMoeda = new(EMoeda.Real);
                    Console.WriteLine("Você está usando a moeda Real (BLR).");
                    EMoeda tipoMoedaAConverter = ConversaoMoeda.EscolherMoedaConversao();
                    decimal valorEmRealParaConverter = ConversaoMoeda.LerQuantidadeConverter();
                    decimal valorConvertido = conversaoMoeda.Converter(tipoMoedaAConverter, valorEmRealParaConverter);

                    Console.WriteLine($@"{valorEmRealParaConverter.ToString("C", conversaoMoeda.BuscarCultureMoeda(EMoeda.Real))} convertido para {tipoMoedaAConverter.ToString()} é: ");
                    Console.WriteLine($@"{valorConvertido.ToString("C", conversaoMoeda.BuscarCultureMoeda(tipoMoedaAConverter))}");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Aperte ENTER para voltar ao menu!");
                    Console.ReadLine();
                    tenteNovamente = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor digite apenas números inteiros!");
                    Thread.Sleep(1);
                    Console.Clear();
                }
            }
            break;

        case 6:
            tenteNovamente = true;
            Console.Clear();
            while (tenteNovamente)
            {
                try
                {
                    Ordenar.Menu();

                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Ordenar.Crescente();
                            break;

                        case "2":
                            Ordenar.Decrescente();
                            break;

                        case "3":
                            Ordenar.Aleatoria();
                            break;

                        case "0":
                            break;

                        default:
                            Ordenar.Menu();
                            break;
                    }

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Aperte ENTER para voltar ao menu!");
                    Console.ReadLine();
                    tenteNovamente = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor digite apenas números inteiros!");
                    Thread.Sleep(1);
                    Console.Clear();
                }
            }
            break;
    }
}
while (numeroExercicio != 0);
﻿int numeroExercicio;

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
        //Thread.Sleep(1);
    }

    Console.ForegroundColor = ConsoleColor.White;
    Thread.Sleep(500);

    bool tenteNovamente;
    Console.WriteLine("0: Sair do Programa.");
    Console.WriteLine("1: Sorteio.");
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
                    string[] nomes = { "Gustavo C", "Gustavo A", "José", "Diego", "Fickert", "Tulio", "Paulo" };
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
                    Thread.Sleep(1200);
                    Console.Clear();
                }
            }
            break;
    }
}
while (numeroExercicio != 0);
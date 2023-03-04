// Sorteio
string[] nomes = { "Gustavo C", "Gustavo A", "José", "Diego", "Fickert", "Tulio", "Paulo" };
Random aleatorio = new();
string sorteio = nomes[aleatorio.Next(nomes.Length)];
Console.WriteLine("O nome sorteado é: " + sorteio);
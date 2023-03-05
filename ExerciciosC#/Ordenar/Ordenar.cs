namespace ExerciciosCSharp.Ordenar
{
    public class Ordenar
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Ordem crescente");
            Console.WriteLine("2 - Ordem decrescente");
            Console.WriteLine("3 - Ordem aleatória");
            Console.WriteLine("0 - Sair");
        }

        public static void Crescente()
        {
            int[] numeros = new int[10];

            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite um número: ");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numeros);
            Console.Write("\n\n");
            foreach (int p in numeros) Console.WriteLine(p);
        }

        public static void Decrescente()
        {
            int[] numeros = new int[10];

            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite um número: ");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\n");

            Array.Reverse(numeros);
            foreach (int p in numeros)
            {
                for (int i = 2; i <= p; i++)
                {
                    if (p % i == 0 && i != p)
                    {
                        Console.WriteLine(p); // não é primo
                        break;
                    }

                    if (p % i == 0 && i == p)
                    {
                        Console.WriteLine(p + " é primo");
                        break;
                    }
                }
            }
        }

        public static void Aleatoria()
        {
            string[] estudantes = new string[] {
                       "Anderson", "Castro", "Denise",
                       "Karla", "Katia", "Lazaro",
                       "Lucas", "Luciana", "Michel",
                       "Norma", "Priscila", "Rodrigo",
                       "Sergio", "Stenio", "Toninho" };

            // Para ordenar de forma aleatória precisamos de uma variável auxiliar.
            Random sorteio = new();
            for (int i = 0; i < estudantes.Length - 1; i++)
            {
                int j = sorteio.Next(i, estudantes.Length);
                (estudantes[j], estudantes[i]) = (estudantes[i], estudantes[j]);
            }

            int x = 0, grupo = 1;
            foreach (string p in estudantes)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine("\n\nGrupo " + grupo + ":");
                    grupo++;
                }
                Console.WriteLine(" > " + p);
                x++;
            }
        }
    }
}
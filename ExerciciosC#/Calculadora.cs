namespace ExerciciosCSharp
{
    public class Calculadora
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto da divisão");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("0 - Sair");
        }

        public static void Somar()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
            Console.ReadLine();
            //Menu();
        }

        public static void Subtrair()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
            Console.ReadLine();
            //Menu();
        }

        public static void Multiplicar()
        {
            double valor1, valor2;

            Console.WriteLine("Entre com o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");
            Console.ReadLine();
            //Menu();
        }

        public static void Dividir()
        {
            double dividendo, divisor;

            Console.WriteLine("Informe o dividendo:");
            dividendo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o divisor:");
            divisor = double.Parse(Console.ReadLine());

            if (divisor != 0)
                Console.WriteLine($"{dividendo} / {divisor} = {dividendo / divisor}");
            else
                Console.WriteLine("Não é possível dividir por zero.");

            Console.ReadLine();
            //Menu();
        }
    }
}
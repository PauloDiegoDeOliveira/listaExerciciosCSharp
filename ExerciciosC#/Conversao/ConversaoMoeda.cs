using System.Globalization;
using ExerciciosCSharp.Moeda;

namespace ExerciciosCSharp.Conversao
{
    public class ConversaoMoeda
    {
        /// <summary>
        /// Propriedade utilizada para identificar a moeda que deve ser convertida.
        /// </summary>
        /// <value></value>
        public EMoeda MoedaTipo { get; private set; }

        /// <summary>
        /// Contém a lista com os valores de cada moeda em real (BLR)
        /// </summary>
        /// <value></value>
        private static Dictionary<EMoeda, decimal> ValoresMoedas
        {
            get
            {
                Dictionary<EMoeda, decimal> dicionarioValoresMoedas = new()
                {
                    { EMoeda.Real, 1m },
                    { EMoeda.Dolar, 5.20m },
                    { EMoeda.Euro, 6.20m },
                    { EMoeda.Iene, 0.052m },
                    { EMoeda.Libra, 6.95m }
                };

                return dicionarioValoresMoedas;
            }
        }

        /// <summary>
        /// Contém a lista com os valores de cada moeda em real (BLR)
        /// </summary>
        /// <value></value>
        private Dictionary<EMoeda, CultureInfo> CultureMoedas
        {
            get
            {
                Dictionary<EMoeda, CultureInfo> dicionarioCultureMoedas = new()
                {
                    { EMoeda.Real, CultureInfo.CreateSpecificCulture("pt-BR") },
                    { EMoeda.Dolar, CultureInfo.CreateSpecificCulture("en-US") },
                    { EMoeda.Euro, CultureInfo.CreateSpecificCulture("fr-FR") }, // pode ser utilizado outras cultures da europa
                    { EMoeda.Iene, CultureInfo.CreateSpecificCulture("jp-JP") },
                    { EMoeda.Libra, CultureInfo.CreateSpecificCulture("en-GB") }
                };

                return dicionarioCultureMoedas;
            }
        }

        /// <summary>
        /// Construtor recebe a moeda 'originaria' que será convertida para as outras disponíveis.
        /// </summary>
        /// <param name="Moeda">Tipo da moeda 'originaria'.</param>
        public ConversaoMoeda(EMoeda Moeda)
        {
            MoedaTipo = Moeda;
        }

        /// <summary>
        /// Converte uma moeda específica para valores em real (BLR).
        /// </summary>
        /// <param name="moedaConversao">Moeda para qual deseja converter o real.</param>
        /// <returns>Retornar o valor convertido.</returns>
        public decimal Converter(EMoeda moedaConversao, decimal valorReal)
        {
            decimal valorMoedaConversao = BuscarValorMoeda(moedaConversao);
            return valorReal * valorMoedaConversao;
        }

        public CultureInfo BuscarCultureMoeda(EMoeda Moeda) => CultureMoedas.GetValueOrDefault(Moeda);

        private static decimal BuscarValorMoeda(EMoeda Moeda) => ValoresMoedas.GetValueOrDefault(Moeda);

        public static EMoeda EscolherMoedaConversao()
        {
            Console.WriteLine("Escolha para qual moeda deseja fazer a conversão:");
            Console.WriteLine("1- Dolar: moeda norte americana");
            Console.WriteLine("2- Euro: moeda europeia");
            Console.WriteLine("3- Iene: moeda japonesa");
            Console.WriteLine("4- Libra esterlina: moeda do Reino Unido");

            int opcao = int.Parse(Console.ReadLine());
            return (EMoeda)opcao;
        }

        public static decimal LerQuantidadeConverter()
        {
            Console.Clear();
            Console.WriteLine("Informe o valor em real (BLR) que deseja converter:");
            return decimal.Parse(Console.ReadLine());
        }
    }
}
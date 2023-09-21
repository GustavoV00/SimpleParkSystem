
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            bool placaExiste = false;
            do
            {
                Console.Write("Digite a placa do veículo para estacionar:");
                string? placa = Console.ReadLine();
                if (placa != null)
                {
                    if (!veiculos.Contains(placa))
                    {
                        veiculos.Add(placa);
                        placaExiste = true;
                        Console.WriteLine("Placa cadastrada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Placa já está cadastrada, digite outra!");
                    }
                }
                else
                {
                    Console.WriteLine("Você não digitou nenhum valor para placa, tente novamente!");
                }

            } while (!placaExiste);

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string? placa = Console.ReadLine();

            if (placa != null)
            {
                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    Console.Write("Quanto tempo o veículo ficou estacinado: ");
                    string? horas = Console.ReadLine();
                    int x = 0;
                    decimal valorTotal;
                    if (Int32.TryParse(horas, out x))
                    {
                        valorTotal = precoInicial + (precoPorHora * x);
                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                        veiculos.Remove(placa);
                    }
                    else
                    {
                        Console.WriteLine("Digite apenas números válidso!");
                    }


                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            else
            {
                Console.WriteLine("Placa não existe!");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                Console.WriteLine("------------------------------------------------");
                int counter = 0;
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine("Veículo " + counter + " - " + veiculo);
                    counter += 1;
                }
                Console.WriteLine("------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
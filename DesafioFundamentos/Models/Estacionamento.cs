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
            //Implementado com sucesso!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            //Implementado com sucesso!
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                //Implementado com sucesso!
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                //Implementado com sucesso!

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //Implementado com sucesso!
                foreach (string carros in veiculos)
                {
                    Console.WriteLine($"{carros}");
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

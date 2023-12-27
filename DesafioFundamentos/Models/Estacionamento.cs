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
            // *IMPLEMENTE AQUI*
            Console.Clear();
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine().ToUpper();
            if(placa.Length == 7)
            {
                veiculos.Add(placa);
                Console.WriteLine("Veiculo adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("A placa deve conter 7 digitos (apenas letras e números).");
            }
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.Write("Digite a placa do veículo para remover: ");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                bool sucesso = int.TryParse(Console.ReadLine(), out int horas);
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                if(sucesso)
                {
                    veiculos.Remove(placa.ToUpper());
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("O número de horas inserido é inválido");
                }
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
                Console.Clear();
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach(string item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

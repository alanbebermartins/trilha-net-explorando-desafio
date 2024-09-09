namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // *IMPLEMENTADO*
            if (Suite == null)
            {
                throw new InvalidOperationException("A suíte deve ser cadastrada antes de adicionar hóspedes.");
            }
            
            if (Suite.Capacidade < hospedes.Count)
            {
                throw new InvalidOperationException($"A quantidade de hóspedes ({hospedes.Count}) não pode ser maior que a capacidade da suíte ({Suite.Capacidade}).");
            }
            
            Hospedes = hospedes;
            Console.WriteLine("Reserva efetuada com sucesso!");
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = Suite.ValorDiaria;
            decimal valorTotal;

            // *IMPLEMENTADO*
             if (DiasReservados >= 10)
            {
                valorDiaria *= 0.9M; // Aplicar o desconto de 10%
            }

            valorTotal = DiasReservados * valorDiaria;

            Console.WriteLine($"O valor da diária é de: {valorDiaria:C}");
            Console.WriteLine($"O valor total é de: {valorTotal:C}");

            return valorDiaria;
        }
    }
}
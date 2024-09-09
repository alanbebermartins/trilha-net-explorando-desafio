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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (true)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return 0;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0M;

            // *IMPLEMENTADO*
            if (DiasReservados >= 10)
            {
                Suite.ValorDiaria = Suite.ValorDiaria * 0.9;
                valor = (DiasReservados * Suite.ValorDiaria);

                Console.WriteLine($"O valor da diária com desconto fica em: {Suite.ValorDiaria:C}");
                Console.WriteLine($"O valor total é de: {valor:C}");
            } else {
                valor = (DiasReservados * Suite.ValorDiaria);

                Console.WriteLine($"O valor da diária é de: {Suite.ValorDiaria:C}");
                Console.WriteLine($"O valor total é de: {valor:C}");
            }

            return valor;
        }
    }
}
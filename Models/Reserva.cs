namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suites { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

            if (Suites != null && Suites.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implementado: "Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido"
                throw new InvalidOperationException("A capacidade da suite escolhida é menor que o numero de hospedes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suites = suite;

        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado: "Retorna a quantidade de hóspedes (propriedade Hospedes)"
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado: "Retorna o valor da diária"
            decimal valor = DiasReservados * Suites.ValorDiaria;

            // Implementado conforme a regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10m;
            }

            return valor;
        }
    }
}
namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade <= 0)
                throw new Exception("Suíte não disponível para hóspedes!");
            
            if (hospedes.Count > Suite.Capacidade)
                throw new Exception("Quantidade de hóspedes não permitida para este suíte!");

            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            var valor = DiasReservados * Suite.ValorDiaria;
            var desconto = (decimal)0.1;

            if (DiasReservados >= 10)
            {
                valor -= valor * desconto;
            }

            return valor;
        }
    }
}
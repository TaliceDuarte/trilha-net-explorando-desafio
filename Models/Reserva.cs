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
            // IMPLEMENTADO
            
            bool dentroDaCapacidadePermitida = hospedes.Count <= Suite.Capacidade ? true : false;

            if (dentroDaCapacidadePermitida)
            {
        
                Hospedes = hospedes;
              
            }
            else
            {
                // IMPLEMENTADO
                throw new Exception($"Excedida a capacidade máxima de {Suite.Capacidade} hóspedes na suíte.");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            int quantidadeHospedes = Hospedes.Count();
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            bool desconto = DiasReservados >=10 ? true : false ;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // IMPLEMENTADO
            if (desconto)
            {
                valor = valor - valor * 0.1M;
            }

            return valor;
        }
    }
}
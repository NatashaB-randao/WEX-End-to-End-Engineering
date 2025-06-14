namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        // Propriedades

        // Capacidade máxima de hóspedes da suíte
        public List<Pessoa> Hospedes { get; set; }

        // Propriedade que representa a suíte reservada
        public Suite Suite { get; set; }

        // Propriedade que representa a quantidade de dias reservados
        public int DiasReservados { get; set; }


        // Construtores
        // Construtor padrão
        public Reserva() { }

        // Construtor que recebe a quantidade de dias reservados
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        // Métodos
        // Método que recebe uma lista de hóspedes e cadastra na reserva
        // 🔍 PASSO 1: Verificar se a suíte comporta todos os hóspedes
            // Exemplo: Suíte para 2, lista com 2 pessoas = OK
            // Exemplo: Suíte para 2, lista com 3 pessoas = ERRO
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                // Cabe todo mundo! Cadastra os hóspedes
                Hospedes = hospedes;
            }
            else
            {
                // Não cabe! Lança um erro explicativo
                throw new Exception($"A suíte selecionada comporta no máximo {Suite.Capacidade} hóspedes, mas foram informados {hospedes.Count} hóspedes.");
            }
        }

        // Método que recebe uma suíte e cadastra na reserva
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (propriedade Hospedes)
            // Exemplo: Lista [João, Maria] → Retorna 2
            return Hospedes.Count;
        }


        // Método que calcula o valor da diária
        public decimal CalcularValorDiaria()
        {
            // PASSO 1: Calcular valor básico (dias × diária)
            // Exemplo: 5 dias × R$ 30 = R$ 150
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // PASSO 2: Verificar se ganha desconto (10+ dias = 10% off)
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                // Aplicar desconto de 10%
                // Pagar 90% do valor = multiplicar por 0.9
                // Exemplo: R$ 360 × 0.9 = R$ 324
                valor = valor * 0.9m;   // O 'm' indica que é decimal
            }

            
            // PASSO 3: Retornar o valor final

            return valor;
        }
    }
}
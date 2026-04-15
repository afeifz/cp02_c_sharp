namespace AppPagamento.Model
{
    public class PagamentoCartao : Pagamento
    {
        private string numeroCartao;

        public string NumeroCartao
        {
            get { return numeroCartao; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Número do cartão inválido.");

                numeroCartao = value;
            }
        }

        public PagamentoCartao(decimal valor, string numeroCartao)
            : base(valor)
        {
            NumeroCartao = numeroCartao;
        }

        public override string ProcessarPagamento()
        {
            return $"Processando pagamento de R$ {Valor:F2} via Cartão (Número: {NumeroCartao}) na data {Data:dd/MM/yyyy}.";
        }
    }
}
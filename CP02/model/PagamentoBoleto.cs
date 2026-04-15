namespace AppPagamento.Model
{
    public class PagamentoBoleto : Pagamento
    {
        private string codigoBarras;

        public string CodigoBarras
        {
            get { return codigoBarras; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Código de barras inválido.");

                codigoBarras = value;
            }
        }

        public PagamentoBoleto(decimal valor, string codigoBarras)
            : base(valor)
        {
            CodigoBarras = codigoBarras;
        }

        public override string ProcessarPagamento()
        {
            return $"Processando pagamento de R$ {Valor:F2} via Boleto (Cod Barra: {CodigoBarras}) na data {Data:dd/MM/yyyy}.";
        }
    }
}
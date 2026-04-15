namespace AppPagamento.Model
{
    public class Pagamento
    {
        private decimal valor;

        public decimal Valor
        {
            get { return valor; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("O valor deve ser maior que zero.");

                valor = value;
            }
        }

        public DateTime Data { get; private set; }

        public Pagamento(decimal valor)
        {
            Valor = valor;
            Data = DateTime.Now;
        }

        public virtual string ProcessarPagamento()
        {
            return "Pagamento processado.";
        }
    }
}
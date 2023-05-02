using System;

namespace eRoupas.Model
{
    public class Pagamento
    {
        public long PagamentoID { get; set; }
        public long CompraID { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string FormaPagamento { get; set; } = string.Empty;
    }
}
namespace eRoupas.Model
{
    public class Promocao
    {
        public string _tipo { get; set; } = string.Empty;
        private double _valorDesconto { get; set; }
        public List<ProdutoModel> _produtos;
        public string _tipoDesconto { get; set; }


        public enum TiposDesconto
        {
            Porcentagem,
            ValorFixo
        }


        public Promocao(string tipo, double valorDesconto, List<ProdutoModel> produtos, string tipoDesconto)
        {
            _tipo = tipo;
            _valorDesconto = valorDesconto;
            _produtos = produtos;
            _tipoDesconto = tipoDesconto.ToString();
        }


        public double CalcularDesconto(double preco)
        {
            switch (_tipoDesconto)
            {
                case "porcentagem":
                    return preco * (_valorDesconto / 100);
                case "valorFixo":
                    return _valorDesconto;
                default:
                    throw new ArgumentException("Tipo de desconto inválido");
            }
        }
    }
}
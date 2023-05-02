using System;

namespace eRoupas.Model
{
    public class CarrinhoCompras
    {
        public long CompraProdutoID { get; set; }
        public ProdutoModel? Produto { get; set; }
        public double Quantidade { get; set; }
        public double PrecoUnitario { get; set; }

        public double Subtotal
        {
            get { return Quantidade * PrecoUnitario; }
        }
    }
}
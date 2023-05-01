using System;

namespace eRoupas.Model
{
	public class Produto
	{
        public long? ProdutoID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }
        
    }

    public class Camisa : Produto
    {
        public string Tamanho { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }

    public class Calca : Produto
    {
        public string Tamanho { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }
}
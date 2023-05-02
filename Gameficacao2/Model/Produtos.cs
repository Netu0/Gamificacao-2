using System;

namespace eRoupas.Model
{
	public abstract class ProdutoModel
	{
        public long? ProdutoID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }
        
    }

    public class Camisa : ProdutoModel
    {
        public string Tamanho { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }

    public class Calca : ProdutoModel
    {
        public string Tamanho { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }

    public class Vestido : ProdutoModel
    {
        public string Tamanho { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }

    public class Sapato : ProdutoModel
    {
        public string Tamanho { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }

    public class Bolsa : ProdutoModel
    {
        public string Tamanho { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }

    abstract class Acessorio
    {
        
    }

    enum CategoriaProduto
    {
        Camisa,
        Calca,
        Vestido,
        Sapato,
        Bolsa,
        Acessorio
    }
}
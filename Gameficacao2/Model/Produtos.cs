using System;
using System.Collections.Generic;

namespace eRoupas.Model
{
	public abstract class ProdutoModel
	{
        public long? ProdutoID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }

        internal bool Any()
        {
            throw new NotImplementedException();
        }
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
        enum CategoriaProduto
        {
            Camisa,
            Calca,
            Vestido
        }
    
}
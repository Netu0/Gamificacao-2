using System;

namespace eRoupas.Model
{
	
    public abstract class Acessorio
    {
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }
    }

    public class Sapato : Acessorio
    {
        public string Tamanho { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }

    public class Bolsa : Acessorio
    {
        public string Tamanho { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }

    enum CategoriaAcessorio
    {
        Sapato,
        Bolsa
    }
}
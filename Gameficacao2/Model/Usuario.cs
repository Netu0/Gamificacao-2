using System;

namespace eRoupas.UI
{
    public abstract class Pessoa 
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Pessoa(string nome, string senha) {
            Nome = nome;
            Senha = senha;
        }

    public abstract bool Autenticar(string senha);
    }
        public class Cliente : Pessoa 
        {
        public int NumeroConta { get; set; }

        public Cliente(string nome, string senha, int numeroConta) : base(nome, senha) {
            NumeroConta = numeroConta;
        }

        public override bool Autenticar(string senha) {
            return Senha == senha;
        }
    }

    public class Funcionario : Pessoa 
    {
        public string Cargo { get; set; }

        public Funcionario(string nome, string senha, string cargo) : base(nome, senha) {
            Cargo = cargo;
        }

        public override bool Autenticar(string senha) {
            return Senha == senha;
        }
    }
}
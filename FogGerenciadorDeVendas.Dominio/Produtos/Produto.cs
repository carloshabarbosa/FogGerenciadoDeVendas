using System;

namespace FogGerenciadorDeVendas.Dominio.Produtos
{
    public class Produto
    {
        public Produto(string nome, string descricao, decimal valor)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            DataDeCadastro = DateTime.Now;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public bool Situacao { get; private set; }
        public DateTime DataDeCadastro { get; private set; }

        public bool Validar()
        {
            return !string.IsNullOrEmpty(Nome) &&
                Valor > 0;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarDescricacao(string descricao)
        {
            Descricao = descricao;
        }

        public void AlterarValor(decimal valor)
        {
            Valor = valor;
        }
    }
}

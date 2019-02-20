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

        //Campos para nota fiscar
        public bool EmiteNota { get; set; }
        public string Ncm { get; set; }
        public int Cfop { get; set; }
        public string UnidadeComercial { get; set; }
        public decimal QuantidadeComercial { get; set; }
        public decimal ValorUnitarioComercializacao { get; set; }
        public decimal ValorDoProduto { get; set; }
        public decimal ValorDoDesconto{ get; set; }
        public string UnidadeTributavel { get; set; }
        public decimal QuantidadeTributavel { get; set; }
        public decimal ValorUnitarioTributacao { get; set; }

        

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

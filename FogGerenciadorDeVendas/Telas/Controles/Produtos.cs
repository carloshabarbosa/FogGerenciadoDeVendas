using FogGerenciadorDeVendas.Dominio.Produtos;
using MetroFramework.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FogGerenciadorDeVendas.Telas.Controles
{
    public partial class Produtos : MetroUserControl
    {
        private readonly IProdutosRepositorio _produtosRepositorio;

        public Produtos(IProdutosRepositorio produtosRepositorio)
        {
            _produtosRepositorio = produtosRepositorio;
            InitializeComponent();
            RecuperarProdutos();
        }
        

        public void RecuperarProdutos(string codigoOuNome = "")
        {
            produtos_grid.DataSource = null;
            produtos_grid.DataSource = _produtosRepositorio.PesquisarPorCodigoOuNome(codigoOuNome)
                .Select(c => new
                {
                    Codigo = c.Id,
                    c.Nome,
                    c.Descricao,
                    Valor = string.Format("{0:C}", c.Valor),
                    c.DataDeCadastro
                })
                .ToList();

            produtos_grid.Columns[2].HeaderText = "Descrição";
            produtos_grid.Columns[4].HeaderText = "Data de cadastro";
            produtos_grid.ClearSelection();
        }

        private void txt_codigo_nome_KeyUp(object sender, KeyEventArgs e)
        {
            var codigoOuNome = txt_codigo_nome.Text;
            if (codigoOuNome.Length % 3 == 0 || codigoOuNome.Length == 1)
            {
                RecuperarProdutos(codigoOuNome);
            }
        }
    }
}
